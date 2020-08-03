﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace grapher
{
    public class AccelGUI
    {        
        public struct MagnitudeData
        {
            public double magnitude;
            public int x;
            public int y;
        }

        public static ReadOnlyCollection<MagnitudeData> Magnitudes = GetMagnitudes();

        #region constructors

        public AccelGUI(
            RawAcceleration accelForm,
            AccelCharts accelCharts,
            ManagedAccel managedAccel,
            AccelOptions accelOptions,
            OptionXY sensitivity,
            Option rotation,
            OptionXY weight,
            OptionXY cap,
            Option offset,
            Option acceleration,
            Option limtOrExp,
            Option midpoint)
        {
            AccelForm = accelForm;
            AccelCharts = accelCharts;
            ManagedAcceleration = managedAccel;
            AccelerationOptions = accelOptions;
            Sensitivity = sensitivity;
            Rotation = rotation;
            Weight = weight;
            Cap = cap;
            Offset = offset;
            Acceleration = acceleration;
            LimitOrExponent = limtOrExp;
            Midpoint = midpoint;

            ManagedAcceleration.ReadFromDriver();
            UpdateGraph();
        }

        #endregion constructors

        #region properties

        public RawAcceleration AccelForm { get; }

        public AccelCharts AccelCharts { get; }

        public ManagedAccel ManagedAcceleration { get; }

        public AccelOptions AccelerationOptions { get; }

        public OptionXY Sensitivity { get; }

        public Option Rotation { get; }

        public OptionXY Weight { get; }

        public OptionXY Cap { get; }

        public Option Offset { get; }

        public Option Acceleration { get; }

        public Option LimitOrExponent { get; }

        public Option Midpoint { get; }

        public Button WriteButton { get; }

        #endregion properties

        #region methods

        public static ReadOnlyCollection<MagnitudeData> GetMagnitudes()
        {
            var magnitudes = new List<MagnitudeData>();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    MagnitudeData magnitudeData;
                    magnitudeData.magnitude = Magnitude(i, j);
                    magnitudeData.x = i;
                    magnitudeData.y = j;
                    magnitudes.Add(magnitudeData);
                }
            }

            magnitudes.Sort((m1, m2) => m1.magnitude.CompareTo(m2.magnitude));

            return magnitudes.AsReadOnly();
        }

        public static double Magnitude(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public static double Magnitude(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void UpdateGraph()
        {
            var orderedAccelPoints = new SortedDictionary<double, double>();
            var orderedVelocityPoints = new SortedDictionary<double, double>();
            var orderedGainPoints = new SortedDictionary<double, double>();

            double lastInputMagnitude = 0;
            double lastOutputMagnitude = 0;

            foreach (var magnitudeData in Magnitudes)
            {
                var output = ManagedAcceleration.Accelerate(magnitudeData.x, magnitudeData.y, 1);

                var outMagnitude = Magnitude(output.Item1, output.Item2);
                var ratio = magnitudeData.magnitude > 0 ? outMagnitude / magnitudeData.magnitude : Sensitivity.Fields.X;

                var inDiff = magnitudeData.magnitude - lastInputMagnitude;
                var outDiff = outMagnitude - lastOutputMagnitude;
                var slope = inDiff > 0 ? outDiff / inDiff : Sensitivity.Fields.X;
                lastInputMagnitude = magnitudeData.magnitude;
                lastOutputMagnitude = outMagnitude;

                if (!orderedAccelPoints.ContainsKey(magnitudeData.magnitude))
                {
                    orderedAccelPoints.Add(magnitudeData.magnitude, ratio);
                }

                if (!orderedVelocityPoints.ContainsKey(magnitudeData.magnitude))
                {
                    orderedVelocityPoints.Add(magnitudeData.magnitude, outMagnitude);
                }

                if (!orderedGainPoints.ContainsKey(magnitudeData.magnitude))
                {
                    orderedGainPoints.Add(magnitudeData.magnitude, slope);
                }
            }

            var accelSeries = AccelCharts.SensitivityChart.Series.FirstOrDefault();
            accelSeries.Points.Clear();

            foreach (var point in orderedAccelPoints)
            {
                accelSeries.Points.AddXY(point.Key, point.Value);
            }

            var velSeries = AccelCharts.VelocityChart.Series.FirstOrDefault();
            velSeries.Points.Clear();

            foreach (var point in orderedVelocityPoints)
            {
                velSeries.Points.AddXY(point.Key, point.Value);
            }

            var gainSeries = AccelCharts.GainChart.Series.FirstOrDefault();
            gainSeries.Points.Clear();

            foreach (var point in orderedGainPoints)
            {
                gainSeries.Points.AddXY(point.Key, point.Value);
            }
        }


        #endregion methods

    }

}
