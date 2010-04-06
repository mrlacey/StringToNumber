//-----------------------------------------------------------------------
// <copyright file="ManualTester.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberManualTesting
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using StringToNumber;

    public partial class ManualTester : Form
    {
        public ManualTester()
        {
            InitializeComponent();

            TargetType.SelectedIndex = 0;
        }

        private void ConvertString_Click(object sender, EventArgs e)
        {
            try
            {
                NumberParser np;

                if (string.IsNullOrEmpty(CultureToUse.Text))
                {
                    if (useShortScale.Checked)
                    {
                        np = new NumberParser();
                    }
                    else
                    {
                        np = new NumberParser(StringToNumber.Scale.Long);
                    }
                }
                else
                {
                    if (useShortScale.Checked)
                    {
                        np = new NumberParser(new CultureInfo(CultureToUse.Text));
                    }
                    else
                    {
                        np = new NumberParser(StringToNumber.Scale.Long, new CultureInfo(CultureToUse.Text));
                    }
                }

                bool result;

                // TODO : add appropriate support for scales
                // TODO : add other conversion types (14 total)
                switch (TargetType.SelectedItem.ToString())
                {
                    case "ToByte":
                        byte byteValue;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToByte(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToByte(StringToConvert.Text, out byteValue);

                            MessageBox.Show(result + @" " + byteValue);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out byteValue);

                            MessageBox.Show(result + @" " + byteValue);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToByte(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToByte(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToSByte":
                        sbyte sbyteValue;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToSByte(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToSByte(StringToConvert.Text, out sbyteValue);

                            MessageBox.Show(result + @" " + sbyteValue);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out sbyteValue);

                            MessageBox.Show(result + @" " + sbyteValue);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToSByte(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToSByte(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToUInt16":
                        UInt16 uint16Value;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToUInt16(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToUInt16(StringToConvert.Text, out uint16Value);

                            MessageBox.Show(result + @" " + uint16Value);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out uint16Value);

                            MessageBox.Show(result + @" " + uint16Value);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToUInt16(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToUInt16(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToUShort":
                        ushort ushortValue;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToUShort(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToUShort(StringToConvert.Text, out ushortValue);

                            MessageBox.Show(result + @" " + ushortValue);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out ushortValue);

                            MessageBox.Show(result + @" " + ushortValue);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToUShort(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToUShort(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToInt16":
                        Int16 int16Value;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToInt16(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToInt16(StringToConvert.Text, out int16Value);

                            MessageBox.Show(result + @" " + int16Value);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out int16Value);

                            MessageBox.Show(result + @" " + int16Value);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt16(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt16(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToShort":
                        short shortValue;

                        if (AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToShort(StringToConvert.Text).ToString());
                        }
                        else if (AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToShort(StringToConvert.Text, out shortValue);

                            MessageBox.Show(result + @" " + shortValue);
                        }
                        else if (AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out shortValue);

                            MessageBox.Show(result + @" " + shortValue);
                        }
                        else // if (AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToShort(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToShort(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToInt32":
                        Int32 int32Value;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToInt32(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToInt32(StringToConvert.Text, out int32Value);

                            MessageBox.Show(result + @" " + int32Value);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out int32Value);

                            MessageBox.Show(result + @" " + int32Value);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt32(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt32(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToInt":
                        int intValue;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToInt(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToInt(StringToConvert.Text, out intValue);

                            MessageBox.Show(result + @" " + intValue);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out intValue);

                            MessageBox.Show(result + @" " + intValue);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                if (this.useShortScale.Checked)
                                {
                                    MessageBox.Show(StringToConvert.Text.ToInt(StringToNumber.Scale.Short, CultureInfo.CurrentCulture).ToString());
                                }
                                else
                                {
                                    MessageBox.Show(StringToConvert.Text.ToInt(StringToNumber.Scale.Long, CultureInfo.CurrentCulture).ToString());
                                }
                            }
                            else
                            {
                                if (this.useShortScale.Checked)
                                {
                                    MessageBox.Show(StringToConvert.Text.ToInt(StringToNumber.Scale.Short, new CultureInfo(CultureToUse.Text)).ToString());
                                }
                                else
                                {
                                    MessageBox.Show(StringToConvert.Text.ToInt(StringToNumber.Scale.Long, new CultureInfo(CultureToUse.Text)).ToString());
                                }
                            }
                        }

                        break;

                    case "ToInt64":
                        Int64 int64Value;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToInt64(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToInt64(StringToConvert.Text, out int64Value);

                            MessageBox.Show(result + @" " + int64Value);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out int64Value);

                            MessageBox.Show(result + @" " + int64Value);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt64(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToInt64(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    case "ToLong":
                        long longValue;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToLong(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToLong(StringToConvert.Text, out longValue);

                            MessageBox.Show(result + @" " + longValue);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out longValue);

                            MessageBox.Show(result + @" " + longValue);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            if (string.IsNullOrEmpty(CultureToUse.Text))
                            {
                                MessageBox.Show(StringToConvert.Text.ToLong(CultureInfo.CurrentCulture).ToString());
                            }
                            else
                            {
                                MessageBox.Show(StringToConvert.Text.ToLong(new CultureInfo(CultureToUse.Text)).ToString());
                            }
                        }

                        break;

                    default:
                        MessageBox.Show(@"Select conversion operation");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}