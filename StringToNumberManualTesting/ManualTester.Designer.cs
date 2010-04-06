﻿// <auto-generated />
namespace StringToNumberManualTesting
{
  public partial class ManualTester
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.StringToConvert = new System.Windows.Forms.TextBox();
        this.TargetType = new System.Windows.Forms.ComboBox();
        this.ConvertString = new System.Windows.Forms.Button();
        this.CultureToUse = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.AsExtensionMethod = new System.Windows.Forms.RadioButton();
        this.AsTryParseMethod = new System.Windows.Forms.RadioButton();
        this.AsTryToXxxMethod = new System.Windows.Forms.RadioButton();
        this.AsToXxxMethod = new System.Windows.Forms.RadioButton();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.useLongScale = new System.Windows.Forms.RadioButton();
        this.useShortScale = new System.Windows.Forms.RadioButton();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // StringToConvert
        // 
        this.StringToConvert.Location = new System.Drawing.Point(102, 12);
        this.StringToConvert.Name = "StringToConvert";
        this.StringToConvert.Size = new System.Drawing.Size(178, 20);
        this.StringToConvert.TabIndex = 0;
        this.StringToConvert.Text = "one hundred and eighty";
        // 
        // TargetType
        // 
        this.TargetType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        this.TargetType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.TargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.TargetType.FormattingEnabled = true;
        this.TargetType.Items.AddRange(new object[] {
            "ToByte",
            "ToSByte",
            "ToInt16",
            "ToUInt16",
            "ToShort",
            "ToUShort",
            "ToInt32",
            "ToUInt32",
            "ToInt",
            "ToUInt",
            "ToInt64",
            "ToUInt64",
            "ToLong",
            "ToULong"});
        this.TargetType.Location = new System.Drawing.Point(102, 39);
        this.TargetType.Name = "TargetType";
        this.TargetType.Size = new System.Drawing.Size(178, 21);
        this.TargetType.TabIndex = 1;
        // 
        // ConvertString
        // 
        this.ConvertString.Location = new System.Drawing.Point(12, 204);
        this.ConvertString.Name = "ConvertString";
        this.ConvertString.Size = new System.Drawing.Size(75, 23);
        this.ConvertString.TabIndex = 4;
        this.ConvertString.Text = "&Convert";
        this.ConvertString.UseVisualStyleBackColor = true;
        this.ConvertString.Click += new System.EventHandler(this.ConvertString_Click);
        // 
        // CultureToUse
        // 
        this.CultureToUse.Location = new System.Drawing.Point(102, 66);
        this.CultureToUse.Name = "CultureToUse";
        this.CultureToUse.Size = new System.Drawing.Size(100, 20);
        this.CultureToUse.TabIndex = 2;
        this.CultureToUse.Text = "en-GB";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.AsExtensionMethod);
        this.groupBox1.Controls.Add(this.AsTryParseMethod);
        this.groupBox1.Controls.Add(this.AsTryToXxxMethod);
        this.groupBox1.Controls.Add(this.AsToXxxMethod);
        this.groupBox1.Location = new System.Drawing.Point(13, 92);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(267, 50);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Operation";
        // 
        // AsExtensionMethod
        // 
        this.AsExtensionMethod.AutoSize = true;
        this.AsExtensionMethod.Location = new System.Drawing.Point(183, 19);
        this.AsExtensionMethod.Name = "AsExtensionMethod";
        this.AsExtensionMethod.Size = new System.Drawing.Size(71, 17);
        this.AsExtensionMethod.TabIndex = 3;
        this.AsExtensionMethod.TabStop = true;
        this.AsExtensionMethod.Text = "Extension";
        this.AsExtensionMethod.UseVisualStyleBackColor = true;
        // 
        // AsTryParseMethod
        // 
        this.AsTryParseMethod.AutoSize = true;
        this.AsTryParseMethod.Location = new System.Drawing.Point(110, 20);
        this.AsTryParseMethod.Name = "AsTryParseMethod";
        this.AsTryParseMethod.Size = new System.Drawing.Size(67, 17);
        this.AsTryParseMethod.TabIndex = 2;
        this.AsTryParseMethod.Text = "TryParse";
        this.AsTryParseMethod.UseVisualStyleBackColor = true;
        // 
        // AsTryToXxxMethod
        // 
        this.AsTryToXxxMethod.AutoSize = true;
        this.AsTryToXxxMethod.Location = new System.Drawing.Point(50, 19);
        this.AsTryToXxxMethod.Name = "AsTryToXxxMethod";
        this.AsTryToXxxMethod.Size = new System.Drawing.Size(53, 17);
        this.AsTryToXxxMethod.TabIndex = 1;
        this.AsTryToXxxMethod.Text = "TryTo";
        this.AsTryToXxxMethod.UseVisualStyleBackColor = true;
        // 
        // AsToXxxMethod
        // 
        this.AsToXxxMethod.AutoSize = true;
        this.AsToXxxMethod.Checked = true;
        this.AsToXxxMethod.Location = new System.Drawing.Point(6, 19);
        this.AsToXxxMethod.Name = "AsToXxxMethod";
        this.AsToXxxMethod.Size = new System.Drawing.Size(38, 17);
        this.AsToXxxMethod.TabIndex = 0;
        this.AsToXxxMethod.TabStop = true;
        this.AsToXxxMethod.Text = "To";
        this.AsToXxxMethod.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(10, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(86, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "String to Convert";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(10, 66);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(40, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "Culture";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(10, 39);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(65, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Target Type";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.useLongScale);
        this.groupBox2.Controls.Add(this.useShortScale);
        this.groupBox2.Location = new System.Drawing.Point(16, 148);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(267, 50);
        this.groupBox2.TabIndex = 8;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Scale";
        // 
        // useLongScale
        // 
        this.useLongScale.AutoSize = true;
        this.useLongScale.Location = new System.Drawing.Point(62, 19);
        this.useLongScale.Name = "useLongScale";
        this.useLongScale.Size = new System.Drawing.Size(49, 17);
        this.useLongScale.TabIndex = 1;
        this.useLongScale.Text = "Long";
        this.useLongScale.UseVisualStyleBackColor = true;
        // 
        // useShortScale
        // 
        this.useShortScale.AutoSize = true;
        this.useShortScale.Checked = true;
        this.useShortScale.Location = new System.Drawing.Point(6, 19);
        this.useShortScale.Name = "useShortScale";
        this.useShortScale.Size = new System.Drawing.Size(50, 17);
        this.useShortScale.TabIndex = 0;
        this.useShortScale.TabStop = true;
        this.useShortScale.Text = "Short";
        this.useShortScale.UseVisualStyleBackColor = true;
        // 
        // ManualTester
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(295, 240);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.CultureToUse);
        this.Controls.Add(this.ConvertString);
        this.Controls.Add(this.TargetType);
        this.Controls.Add(this.StringToConvert);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "ManualTester";
        this.Text = "StringToNumber";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox StringToConvert;
    private System.Windows.Forms.ComboBox TargetType;
    private System.Windows.Forms.Button ConvertString;
    private System.Windows.Forms.TextBox CultureToUse;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton AsTryParseMethod;
    private System.Windows.Forms.RadioButton AsTryToXxxMethod;
    private System.Windows.Forms.RadioButton AsToXxxMethod;
    private System.Windows.Forms.RadioButton AsExtensionMethod;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton useLongScale;
    private System.Windows.Forms.RadioButton useShortScale;
  }
}
