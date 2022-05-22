namespace ActiveFilterSimulator
{
    partial class AmpPropertiesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBPscientiffic = new System.Windows.Forms.NumericUpDown();
            this.lGBPScientiffic = new System.Windows.Forms.Label();
            this.GBPvalue = new System.Windows.Forms.NumericUpDown();
            this.lGBP = new System.Windows.Forms.Label();
            this.lOpenLoopGain = new System.Windows.Forms.Label();
            this.lGBPunit = new System.Windows.Forms.Label();
            this.OpenLoopGainUnit = new System.Windows.Forms.Label();
            this.OpenLoopGainControl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GBPscientiffic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBPvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenLoopGainControl)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPscientiffic
            // 
            this.GBPscientiffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GBPscientiffic.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBPscientiffic.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.GBPscientiffic.Location = new System.Drawing.Point(121, 26);
            this.GBPscientiffic.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.GBPscientiffic.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            -2147483648});
            this.GBPscientiffic.Name = "GBPscientiffic";
            this.GBPscientiffic.ReadOnly = true;
            this.GBPscientiffic.Size = new System.Drawing.Size(56, 24);
            this.GBPscientiffic.TabIndex = 17;
            this.GBPscientiffic.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lGBPScientiffic
            // 
            this.lGBPScientiffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lGBPScientiffic.AutoSize = true;
            this.lGBPScientiffic.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGBPScientiffic.Location = new System.Drawing.Point(103, 26);
            this.lGBPScientiffic.Name = "lGBPScientiffic";
            this.lGBPScientiffic.Size = new System.Drawing.Size(19, 23);
            this.lGBPScientiffic.TabIndex = 16;
            this.lGBPScientiffic.Text = "e";
            // 
            // GBPvalue
            // 
            this.GBPvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBPvalue.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBPvalue.Location = new System.Drawing.Point(12, 26);
            this.GBPvalue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            262144});
            this.GBPvalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GBPvalue.Name = "GBPvalue";
            this.GBPvalue.Size = new System.Drawing.Size(89, 24);
            this.GBPvalue.TabIndex = 15;
            this.GBPvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GBPvalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lGBP
            // 
            this.lGBP.AutoSize = true;
            this.lGBP.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGBP.Location = new System.Drawing.Point(10, 6);
            this.lGBP.Name = "lGBP";
            this.lGBP.Size = new System.Drawing.Size(140, 17);
            this.lGBP.TabIndex = 14;
            this.lGBP.Text = "Gain Bandwidth Product";
            // 
            // lOpenLoopGain
            // 
            this.lOpenLoopGain.AutoSize = true;
            this.lOpenLoopGain.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOpenLoopGain.Location = new System.Drawing.Point(12, 53);
            this.lOpenLoopGain.Name = "lOpenLoopGain";
            this.lOpenLoopGain.Size = new System.Drawing.Size(96, 17);
            this.lOpenLoopGain.TabIndex = 18;
            this.lOpenLoopGain.Text = "Open Loop Gain";
            // 
            // lGBPunit
            // 
            this.lGBPunit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lGBPunit.AutoSize = true;
            this.lGBPunit.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGBPunit.Location = new System.Drawing.Point(179, 26);
            this.lGBPunit.Name = "lGBPunit";
            this.lGBPunit.Size = new System.Drawing.Size(29, 23);
            this.lGBPunit.TabIndex = 19;
            this.lGBPunit.Text = "Hz";
            // 
            // OpenLoopGainUnit
            // 
            this.OpenLoopGainUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLoopGainUnit.AutoSize = true;
            this.OpenLoopGainUnit.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenLoopGainUnit.Location = new System.Drawing.Point(179, 73);
            this.OpenLoopGainUnit.Name = "OpenLoopGainUnit";
            this.OpenLoopGainUnit.Size = new System.Drawing.Size(30, 23);
            this.OpenLoopGainUnit.TabIndex = 21;
            this.OpenLoopGainUnit.Text = "dB";
            // 
            // OpenLoopGainControl
            // 
            this.OpenLoopGainControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLoopGainControl.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenLoopGainControl.Location = new System.Drawing.Point(12, 73);
            this.OpenLoopGainControl.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            262144});
            this.OpenLoopGainControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OpenLoopGainControl.Name = "OpenLoopGainControl";
            this.OpenLoopGainControl.Size = new System.Drawing.Size(165, 24);
            this.OpenLoopGainControl.TabIndex = 20;
            this.OpenLoopGainControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OpenLoopGainControl.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // AmpPropertiesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenLoopGainUnit);
            this.Controls.Add(this.OpenLoopGainControl);
            this.Controls.Add(this.lGBPunit);
            this.Controls.Add(this.lOpenLoopGain);
            this.Controls.Add(this.GBPscientiffic);
            this.Controls.Add(this.lGBPScientiffic);
            this.Controls.Add(this.GBPvalue);
            this.Controls.Add(this.lGBP);
            this.Name = "AmpPropertiesUC";
            this.Size = new System.Drawing.Size(210, 400);
            ((System.ComponentModel.ISupportInitialize)(this.GBPscientiffic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBPvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenLoopGainControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown GBPscientiffic;
        private Label lGBPScientiffic;
        private NumericUpDown GBPvalue;
        private Label lGBP;
        private Label lOpenLoopGain;
        private Label lGBPunit;
        private Label OpenLoopGainUnit;
        private NumericUpDown OpenLoopGainControl;
    }
}
