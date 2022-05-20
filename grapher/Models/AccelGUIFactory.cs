﻿using grapher.Models.Calculations;
using grapher.Models.Devices;
using grapher.Models.Mouse;
using grapher.Models.Options;
using grapher.Models.Options.Cap;
using grapher.Models.Options.Directionality;
using grapher.Models.Options.LUT;
using grapher.Models.Serialized;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using grapher.Models.Theming.Controls;

namespace grapher.Models
{
    public static class AccelGUIFactory
    {
        #region Methods

        public static AccelGUI Construct(
            RawAcceleration form,
            Chart accelerationChart,
            Chart accelerationChartY,
            Chart velocityChart,
            Chart velocityChartY,
            Chart gainChart,
            Chart gainChartY,
            TableLayoutPanel chartContainer,
            ThemeableComboBox accelTypeDropX,
            ThemeableComboBox accelTypeDropY,
            ThemeableComboBox lutApplyDropdownX,
            ThemeableComboBox lutApplyDropdownY,
            ThemeableComboBox capTypeDropdownXClassic,
            ThemeableComboBox capTypeDropdownYClassic,
            ThemeableComboBox capTypeDropdownXPower,
            ThemeableComboBox capTypeDropdownYPower,
            Button writeButton,
            Button toggleButton,
            ToolStripMenuItem showVelocityGainToolStripMenuItem,
            ToolStripMenuItem showLastMouseMoveMenuItem,
            ToolStripMenuItem autoWriteMenuItem,
            ToolStripMenuItem deviceMenuItem,
            ToolStripMenuItem scaleMenuItem,
            ToolStripMenuItem themeMenuItem,
            ToolStripTextBox dpiTextBox,
            ToolStripTextBox pollRateTextBox,
            Panel directionalityPanel,
            ThemeableTextBox sensitivityBoxX,
            ThemeableTextBox sensitivityBoxY,
            ThemeableTextBox rotationBox,
            ThemeableTextBox inCapBoxXClassic,
            ThemeableTextBox inCapBoxYClassic,
            ThemeableTextBox outCapBoxXClassic,
            ThemeableTextBox outCapBoxYClassic,
            ThemeableTextBox inCapBoxXPower,
            ThemeableTextBox inCapBoxYPower,
            ThemeableTextBox outCapBoxXPower,
            ThemeableTextBox outCapBoxYPower,
            ThemeableTextBox inputJumpBoxX,
            ThemeableTextBox inputJumpBoxY,
            ThemeableTextBox outputJumpBoxX,
            ThemeableTextBox outputJumpBoxY,
            ThemeableTextBox inputOffsetBoxX,
            ThemeableTextBox inputOffsetBoxY,
            ThemeableTextBox outputOffsetBoxX,
            ThemeableTextBox outputOffsetBoxY,
            ThemeableTextBox accelerationBoxX,
            ThemeableTextBox accelerationBoxY,
            ThemeableTextBox decayRateBoxX,
            ThemeableTextBox decayRateBoxY,
            ThemeableTextBox growthRateBoxX,
            ThemeableTextBox growthRateBoxY,
            ThemeableTextBox smoothBoxX,
            ThemeableTextBox smoothBoxY,
            ThemeableTextBox scaleBoxX,
            ThemeableTextBox scaleBoxY,
            ThemeableTextBox limitBoxX,
            ThemeableTextBox limitBoxY,
            ThemeableTextBox powerClassicBoxX,
            ThemeableTextBox powerClassicBoxY,
            ThemeableTextBox expBoxX,
            ThemeableTextBox expBoxY,
            ThemeableTextBox midpointBoxX,
            ThemeableTextBox midpointBoxY,
            ThemeableTextBox domainBoxX,
            ThemeableTextBox domainBoxY,
            ThemeableTextBox rangeBoxX,
            ThemeableTextBox rangeBoxY,
            ThemeableTextBox lpNormBox,
            CheckBox sensXYLock,
            CheckBox byComponentXYLock,
            CheckBox fakeBox,
            CheckBox wholeCheckBox,
            CheckBox byComponentCheckBox,
            CheckBox gainSwitchX,
            CheckBox gainSwitchY,
            RichTextBox xLutActiveValuesBox,
            RichTextBox yLutActiveValuesBox,
            RichTextBox xLutPointsBox,
            RichTextBox yLutPointsBox,
            Label lockXYLabel,
            Label sensitivityLabel,
            Label yxRatioLabel,
            Label rotationLabel,
            Label inCapLabelXClassic,
            Label inCapLabelYClassic,
            Label outCapLabelXClassic,
            Label outCapLabelYClassic,
            Label capTypeLabelXClassic,
            Label capTypeLabelYClassic,
            Label inCapLabelXPower,
            Label inCapLabelYPower,
            Label outCapLabelXPower,
            Label outCapLabelYPower,
            Label capTypeLabelXPower,
            Label capTypeLabelYPower,
            Label inputJumpLabelX,
            Label inputJumpLabelY,
            Label outputJumpLabelX,
            Label outputJumpLabelY,
            Label inputOffsetLabelX,
            Label inputOffsetLabelY,
            Label outputOffsetLabelX,
            Label outputOffsetLabelY,
            Label constantOneLabelX,
            Label constantOneLabelY,
            Label decayRateLabelX,
            Label decayRateLabelY,
            Label growthRateLabelX,
            Label growthRateLabelY,
            Label smoothLabelX,
            Label smoothLabelY,
            Label scaleLabelX,
            Label scaleLabelY,
            Label limitLabelX,
            Label limitLabelY,
            Label powerClassicLabelX,
            Label powerClassicLabelY,
            Label expLabelX,
            Label expLabelY,
            Label lutTextLabelX,
            Label lutTextLabelY,
            Label constantThreeLabelX,
            Label constantThreeLabelY,
            Label activeValueTitleX,
            Label activeValueTitleY,
            Label sensitivityActiveLabel,
            Label yxRatioActiveLabel,
            Label rotationActiveLabel,
            Label inCapActiveXLabelClassic,
            Label inCapActiveYLabelClassic,
            Label outCapActiveXLabelClassic,
            Label outCapActiveYLabelClassic,
            Label capTypeActiveXLabelClassic,
            Label capTypeActiveYLabelClassic,
            Label inCapActiveXLabelPower,
            Label inCapActiveYLabelPower,
            Label outCapActiveXLabelPower,
            Label outCapActiveYLabelPower,
            Label capTypeActiveXLabelPower,
            Label capTypeActiveYLabelPower,
            Label inputJumpActiveLabelX,
            Label inputJumpActiveLabelY,
            Label outputJumpActiveLabelX,
            Label outputJumpActiveLabelY,
            Label inputOffsetActiveLabelX,
            Label inputOffsetActiveLabelY,
            Label outputOffsetActiveLabelX,
            Label outputOffsetActiveLabelY,
            Label accelerationActiveLabelX,
            Label accelerationActiveLabelY,
            Label decayRateActiveLabelX,
            Label decayRateActiveLabelY,
            Label growthRateActiveLabelX,
            Label growthRateActiveLabelY,
            Label smoothActiveLabelX,
            Label smoothActiveLabelY,
            Label scaleActiveLabelX,
            Label scaleActiveLabelY,
            Label limitActiveLabelX,
            Label limitActiveLabelY,
            Label powerClassicActiveLabelX,
            Label powerClassicActiveLabelY,
            Label expActiveLabelX,
            Label expActiveLabelY,
            Label midpointActiveLabelX,
            Label midpointActiveLabelY,
            Label accelTypeActiveLabelX,
            Label accelTypeActiveLabelY,
            Label gainSwitchActiveLabelX,
            Label gainSwitchActiveLabelY,
            Label optionSetXTitle,
            Label optionSetYTitle,
            Label mouseLabel,
            Button directionalityLabel,
            Label directionalityX,
            Label directionalityY,
            Label direcionalityActiveValueTitle,
            Label lpNormLabel,
            Label lpNormActiveLabel,
            Label domainLabel,
            Label domainActiveValueX,
            Label domainActiveValueY,
            Label rangeLabel,
            Label rangeActiveValueX,
            Label rangeActiveValueY,
            Label lutApplyLabelX,
            Label lutApplyLabelY,
            Label lutApplyActiveValueX,
            Label lutApplyActiveValueY)
        {
            fakeBox.Checked = false;
            fakeBox.Hide();

            var accelCalculator = new AccelCalculator(
                new Field(dpiTextBox.TextBox, form, Constants.DefaultDPI, 1),
                new Field(pollRateTextBox.TextBox, form, Constants.DefaultPollRate, 1));

            var accelCharts = new AccelCharts(
                                form,
                                new ChartXY(accelerationChart, accelerationChartY, Constants.SensitivityChartTitle),
                                new ChartXY(velocityChart, velocityChartY, Constants.VelocityChartTitle),
                                new ChartXY(gainChart, gainChartY, Constants.GainChartTitle),
                                chartContainer,
                                showVelocityGainToolStripMenuItem,
                                showLastMouseMoveMenuItem,
                                writeButton,
                                accelCalculator);

            var sensitivity = new Option(
                sensitivityBoxX,
                form,
                1,
                sensitivityLabel,
                0,
                new ActiveValueLabel(sensitivityActiveLabel, activeValueTitleX),
                "Sens Multiplier");

            var yxRatio = new LockableOption(
                new Option(
                    sensitivityBoxY,
                    form,
                    1,
                    yxRatioLabel,
                    0,
                    new ActiveValueLabel(yxRatioActiveLabel, activeValueTitleX),
                    "Y/X Ratio"),
                sensXYLock,
                1);

            var rotation = new Option(
                rotationBox,
                form,
                0,
                rotationLabel,
                0,
                new ActiveValueLabel(rotationActiveLabel, activeValueTitleX),
                "Rotation");

            var optionSetYLeft = activeValueTitleX.Left + activeValueTitleX.Width;

            var directionalityLeft = directionalityPanel.Left;

            var inputJumpX = new Option(
                inputJumpBoxX,
                form,
                0,
                inputJumpLabelX,
                0,
                new ActiveValueLabel(inputJumpActiveLabelX, activeValueTitleX),
                "Jump");

            var inputJumpY = new Option(
                inputJumpBoxY,
                form,
                0,
                inputJumpLabelY,
                optionSetYLeft,
                new ActiveValueLabel(inputJumpActiveLabelY, activeValueTitleY),
                "Jump");

            var outputJumpX = new Option(
                outputJumpBoxX,
                form,
                0,
                outputJumpLabelX,
                0,
                new ActiveValueLabel(outputJumpActiveLabelX, activeValueTitleX),
                "Jump");

            var outputJumpY = new Option(
                outputJumpBoxY,
                form,
                0,
                outputJumpLabelY,
                optionSetYLeft,
                new ActiveValueLabel(outputJumpActiveLabelY, activeValueTitleY),
                "Jump");

            var inputOffsetX = new Option(
                inputOffsetBoxX,
                form,
                0,
                inputOffsetLabelX,
                0,
                new ActiveValueLabel(inputOffsetActiveLabelX, activeValueTitleX),
                "Offset");

            var inputOffsetY = new Option(
                inputOffsetBoxY,
                form,
                0,
                inputOffsetLabelY,
                optionSetYLeft,
                new ActiveValueLabel(inputOffsetActiveLabelY, activeValueTitleY),
                "Offset");

            var outputOffsetX = new Option(
                outputOffsetBoxX,
                form,
                0,
                outputOffsetLabelX,
                0,
                new ActiveValueLabel(outputOffsetActiveLabelX, activeValueTitleX),
                "Offset");

            var outputOffsetY = new Option(
                outputOffsetBoxY,
                form,
                0,
                outputOffsetLabelY,
                optionSetYLeft,
                new ActiveValueLabel(outputOffsetActiveLabelY, activeValueTitleY),
                "Offset");

            var accelerationX = new Option(
                new Field(accelerationBoxX, form, 0),
                constantOneLabelX,
                new ActiveValueLabel(accelerationActiveLabelX, activeValueTitleX),
                0);

            var accelerationY = new Option(
                new Field(accelerationBoxY, form, 0),
                constantOneLabelY,
                new ActiveValueLabel(accelerationActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var decayRateX = new Option(
                new Field(decayRateBoxX, form, 0),
                decayRateLabelX,
                new ActiveValueLabel(decayRateActiveLabelX, activeValueTitleX),
                0);

            var decayRateY = new Option(
                new Field(decayRateBoxY, form, 0),
                decayRateLabelY,
                new ActiveValueLabel(decayRateActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var growthRateX = new Option(
                new Field(growthRateBoxX, form, 0),
                growthRateLabelX,
                new ActiveValueLabel(growthRateActiveLabelX, activeValueTitleX),
                0);

            var growthRateY = new Option(
                new Field(growthRateBoxY, form, 0),
                growthRateLabelY,
                new ActiveValueLabel(growthRateActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var smoothX = new Option(
                new Field(smoothBoxX, form, 0),
                smoothLabelX,
                new ActiveValueLabel(smoothActiveLabelX, activeValueTitleX),
                0);

            var smoothY = new Option(
                new Field(smoothBoxY, form, 0),
                smoothLabelY,
                new ActiveValueLabel(smoothActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var scaleX = new Option(
                new Field(scaleBoxX, form, 0),
                scaleLabelX,
                new ActiveValueLabel(scaleActiveLabelX, activeValueTitleX),
                0);

            var scaleY = new Option(
                new Field(scaleBoxY, form, 0),
                scaleLabelY,
                new ActiveValueLabel(scaleActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var limitX = new Option(
                new Field(limitBoxX, form, 2),
                limitLabelX,
                new ActiveValueLabel(limitActiveLabelX, activeValueTitleX),
                0);

            var limitY = new Option(
                new Field(limitBoxY, form, 2),
                limitLabelY,
                new ActiveValueLabel(limitActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var powerClassicX = new Option(
                new Field(powerClassicBoxX, form, 2),
                powerClassicLabelX,
                new ActiveValueLabel(powerClassicActiveLabelX, activeValueTitleX),
                0);

            var powerClassicY = new Option(
                new Field(powerClassicBoxY, form, 2),
                powerClassicLabelY,
                new ActiveValueLabel(powerClassicActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var exponentX = new Option(
                new Field(expBoxX, form, 2),
                expLabelX,
                new ActiveValueLabel(expActiveLabelX, activeValueTitleX),
                0);

            var exponentY = new Option(
                new Field(expBoxY, form, 2),
                expLabelY,
                new ActiveValueLabel(expActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var midpointX = new Option(
                new Field(midpointBoxX, form, 0),
                constantThreeLabelX,
                new ActiveValueLabel(midpointActiveLabelX, activeValueTitleX),
                0);

            var midpointY = new Option(
                new Field(midpointBoxY, form, 0),
                constantThreeLabelY,
                new ActiveValueLabel(midpointActiveLabelY, activeValueTitleY),
                optionSetYLeft);

            var inCapXClassic = new Option(
                inCapBoxXClassic,
                form,
                0,
                inCapLabelXClassic,
                0,
                new ActiveValueLabel(inCapActiveXLabelClassic, activeValueTitleX),
                "Cap: Input");

            var inCapYClassic = new Option(
                inCapBoxYClassic,
                form,
                0,
                inCapLabelYClassic,
                optionSetYLeft,
                new ActiveValueLabel(inCapActiveYLabelClassic, activeValueTitleY),
                "Cap");

            var outCapXClassic = new Option(
                outCapBoxXClassic,
                form,
                0,
                outCapLabelXClassic,
                0,
                new ActiveValueLabel(outCapActiveXLabelClassic, activeValueTitleX),
                "Cap: Input");

            var outCapYClassic = new Option(
                outCapBoxYClassic,
                form,
                0,
                outCapLabelYClassic,
                optionSetYLeft,
                new ActiveValueLabel(outCapActiveYLabelClassic, activeValueTitleY),
                "Cap");

            var capTypeXClassic = new CapTypeOptions(
                capTypeLabelXClassic,
                capTypeDropdownXClassic,
                new ActiveValueLabel(capTypeActiveXLabelClassic, activeValueTitleX),
                0);

            var capTypeYClassic = new CapTypeOptions(
                capTypeLabelYClassic,
                capTypeDropdownYClassic,
                new ActiveValueLabel(capTypeActiveYLabelClassic, activeValueTitleY),
                optionSetYLeft);

            var classicCapOptionsX = new CapOptions(
                capTypeXClassic,
                inCapXClassic,
                outCapXClassic,
                accelerationX);

            var classicCapOptionsY = new CapOptions(
                capTypeYClassic,
                inCapYClassic,
                outCapYClassic,
                accelerationY);

            var inCapXPower = new Option(
                inCapBoxXPower,
                form,
                0,
                inCapLabelXPower,
                0,
                new ActiveValueLabel(inCapActiveXLabelPower, activeValueTitleX),
                "Cap: Input");

            var inCapYPower = new Option(
                inCapBoxYPower,
                form,
                0,
                inCapLabelYPower,
                optionSetYLeft,
                new ActiveValueLabel(inCapActiveYLabelPower, activeValueTitleY),
                "Cap");

            var outCapXPower = new Option(
                outCapBoxXPower,
                form,
                0,
                outCapLabelXPower,
                0,
                new ActiveValueLabel(outCapActiveXLabelPower, activeValueTitleX),
                "Cap: Input");

            var outCapYPower = new Option(
                outCapBoxYPower,
                form,
                0,
                outCapLabelYPower,
                optionSetYLeft,
                new ActiveValueLabel(outCapActiveYLabelPower, activeValueTitleY),
                "Cap");

            var capTypeXPower = new CapTypeOptions(
                capTypeLabelXPower,
                capTypeDropdownXPower,
                new ActiveValueLabel(capTypeActiveXLabelPower, activeValueTitleX),
                0);

            var capTypeYPower = new CapTypeOptions(
                capTypeLabelYPower,
                capTypeDropdownYPower,
                new ActiveValueLabel(capTypeActiveYLabelPower, activeValueTitleY),
                optionSetYLeft);

            var lpNorm = new Option(
                new Field(lpNormBox, form, 2),
                lpNormLabel,
                new ActiveValueLabel(lpNormActiveLabel, direcionalityActiveValueTitle),
                directionalityLeft);

            var domain = new OptionXY(
                domainBoxX,
                domainBoxY,
                fakeBox,
                form,
                1,
                domainLabel,
                new ActiveValueLabelXY(
                    new ActiveValueLabel(domainActiveValueX, direcionalityActiveValueTitle),
                    new ActiveValueLabel(domainActiveValueY, direcionalityActiveValueTitle)),
                false);

            var range = new OptionXY(
                rangeBoxX,
                rangeBoxY,
                fakeBox,
                form,
                1,
                rangeLabel,
                new ActiveValueLabelXY(
                    new ActiveValueLabel(rangeActiveValueX, direcionalityActiveValueTitle),
                    new ActiveValueLabel(rangeActiveValueY, direcionalityActiveValueTitle)),
                false);


            var lutTextX = new TextOption(lutTextLabelX);
            var lutTextY = new TextOption(lutTextLabelY);
            var gainSwitchOptionX = new CheckBoxOption(
                                            gainSwitchX,
                                            new ActiveValueLabel(gainSwitchActiveLabelX, activeValueTitleX));
            var gainSwitchOptionY = new CheckBoxOption(
                                            gainSwitchY,
                                            new ActiveValueLabel(gainSwitchActiveLabelY, activeValueTitleY));

            var powerCapOptionsX = new CapOptions(
                capTypeXPower,
                inCapXPower,
                outCapXPower,
                scaleX,
                outputOffsetX,
                gainSwitchOptionX);

            var powerCapOptionsY = new CapOptions(
                capTypeYPower,
                inCapYPower,
                outCapYPower,
                scaleY,
                outputOffsetY,
                gainSwitchOptionY);

            var accelerationOptionsX = new AccelTypeOptions(
                accelTypeDropX,
                gainSwitchOptionX,
                classicCapOptionsX,
                powerCapOptionsX,
                outputJumpX,
                outputOffsetX,
                decayRateX,
                growthRateX,
                smoothX,
                inputJumpX,
                inputOffsetX,
                limitX,
                powerClassicX,
                exponentX,
                midpointX,
                lutTextX,
                new LUTPanelOptions(xLutPointsBox, xLutActiveValuesBox),
                new LutApplyOptions(
                    lutApplyLabelX,
                    lutApplyDropdownX,
                    new ActiveValueLabel(lutApplyActiveValueX, activeValueTitleX)),
                writeButton,
                new ActiveValueLabel(accelTypeActiveLabelX, activeValueTitleX));

            var accelerationOptionsY = new AccelTypeOptions(
                accelTypeDropY,
                gainSwitchOptionY,
                classicCapOptionsY,
                powerCapOptionsY,
                outputJumpY,
                outputOffsetY,
                decayRateY,
                growthRateY,
                smoothY,
                inputJumpY,
                inputOffsetY,
                limitY,
                powerClassicY,
                exponentY,
                midpointY,
                lutTextY,
                new LUTPanelOptions(yLutPointsBox, yLutActiveValuesBox),
                new LutApplyOptions(
                    lutApplyLabelY,
                    lutApplyDropdownY,
                    new ActiveValueLabel(lutApplyActiveValueY, activeValueTitleY)),
                writeButton,
                new ActiveValueLabel(accelTypeActiveLabelY, activeValueTitleY));

            var optionsSetX = new AccelOptionSet(
                optionSetXTitle,
                activeValueTitleX,
                rotationBox.Top + rotationBox.Height + Constants.OptionVerticalSeperation,
                accelerationOptionsX);

            var optionsSetY = new AccelOptionSet(
                optionSetYTitle,
                activeValueTitleY,
                rotationBox.Top + rotationBox.Height + Constants.OptionVerticalSeperation,
                accelerationOptionsY);

            var directionalOptions = new DirectionalityOptions(
                directionalityPanel,
                directionalityLabel,
                directionalityX,
                directionalityY,
                direcionalityActiveValueTitle,
                lpNorm,
                domain,
                range,
                wholeCheckBox,
                byComponentCheckBox,
                Constants.DirectionalityVerticalOffset);

            var applyOptions = new ApplyOptions(
                byComponentXYLock,
                optionsSetX,
                optionsSetY,
                directionalOptions,
                sensitivity,
                yxRatio,
                rotation,
                lockXYLabel,
                accelCharts);

            var settings = new SettingsManager(
                accelCalculator.DPI,
                accelCalculator.PollRate,
                autoWriteMenuItem,
                showLastMouseMoveMenuItem,
                showVelocityGainToolStripMenuItem,
                themeMenuItem,
                form
                );

            var mouseWatcher = new MouseWatcher(form, mouseLabel, accelCharts, settings);

            return new AccelGUI(
                form,
                accelCalculator,
                accelCharts,
                settings,
                applyOptions,
                writeButton,
                toggleButton,
                mouseWatcher,
                scaleMenuItem,
                deviceMenuItem);
        }

        #endregion Methods
    }
}
