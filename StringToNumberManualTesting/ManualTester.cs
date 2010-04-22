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
                Scale scaleToUse;
                CultureInfo cultureToUse;

                if (useShortScale.Checked)
                {
                    scaleToUse = StringToNumber.Scale.Short;
                }
                else
                {
                    scaleToUse = StringToNumber.Scale.Long;
                }

                if (string.IsNullOrEmpty(CultureToUse.Text))
                {
                    cultureToUse = CultureInfo.CurrentCulture;
                }
                else
                {
                    cultureToUse = new CultureInfo(CultureToUse.Text);
                }

                NumberParser np = new NumberParser(scaleToUse, cultureToUse);

                bool result;

                switch (TargetType.SelectedItem.ToString())
                {
                    #region ToByte
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
                            MessageBox.Show(StringToConvert.Text.ToByte(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToSByte
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
                            MessageBox.Show(StringToConvert.Text.ToSByte(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToInt16
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
                            MessageBox.Show(StringToConvert.Text.ToInt16(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToUInt16
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
                            MessageBox.Show(StringToConvert.Text.ToUInt16(cultureToUse).ToString());
                        }

                        break;
#endregion
                    #region ToShort
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
                            MessageBox.Show(StringToConvert.Text.ToShort(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToUShort
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
                            MessageBox.Show(StringToConvert.Text.ToUShort(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToInt32
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
                            MessageBox.Show(StringToConvert.Text.ToInt32(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToUInt32
                    case "ToUInt32":
                        UInt32 uint32Value;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToUInt32(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToUInt32(StringToConvert.Text, out uint32Value);

                            MessageBox.Show(result + @" " + uint32Value);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out uint32Value);

                            MessageBox.Show(result + @" " + uint32Value);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            MessageBox.Show(StringToConvert.Text.ToUInt32(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToInt
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
                            MessageBox.Show(StringToConvert.Text.ToInt(cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToUInt
                    case "ToUInt":
                        uint uintValue;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToUInt(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToUInt(StringToConvert.Text, out uintValue);

                            MessageBox.Show(result + @" " + uintValue);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out uintValue);

                            MessageBox.Show(result + @" " + uintValue);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                             MessageBox.Show(StringToConvert.Text.ToUInt(cultureToUse).ToString());
                        }

                        break;
                    #endregion

                    #region ToInt64
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
                            MessageBox.Show(StringToConvert.Text.ToInt64(scaleToUse, cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToUInt64
                    case "ToUInt64":
                        UInt64 uint64Value;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToUInt64(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToUInt64(StringToConvert.Text, out uint64Value);

                            MessageBox.Show(result + @" " + uint64Value);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out uint64Value);

                            MessageBox.Show(result + @" " + uint64Value);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            MessageBox.Show(StringToConvert.Text.ToUInt64(scaleToUse, cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToLong
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
                            MessageBox.Show(StringToConvert.Text.ToLong(scaleToUse, cultureToUse).ToString());
                        }

                        break;
                    #endregion
                    #region ToULong
                    case "ToULong":
                        ulong ulongValue;

                        if (this.AsToXxxMethod.Checked)
                        {
                            MessageBox.Show(np.ToULong(StringToConvert.Text).ToString());
                        }
                        else if (this.AsTryToXxxMethod.Checked)
                        {
                            result = np.TryToULong(StringToConvert.Text, out ulongValue);

                            MessageBox.Show(result + @" " + ulongValue);
                        }
                        else if (this.AsTryParseMethod.Checked)
                        {
                            result = np.TryParse(StringToConvert.Text, out ulongValue);

                            MessageBox.Show(result + @" " + ulongValue);
                        }
                        else // if (this.AsExtensionMethod.Checked)
                        {
                            MessageBox.Show(StringToConvert.Text.ToULong(scaleToUse, cultureToUse).ToString());
                        }

                        break;
                    #endregion

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