namespace ActiveFilterSimulator
{
    partial class PartPropertiesUC
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
            this.ValueScientifficBox = new System.Windows.Forms.NumericUpDown();
            this.lValueScientiffic = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.lValue = new System.Windows.Forms.Label();
            this.NameProperty = new System.Windows.Forms.TextBox();
            this.lNameProperty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValueScientifficBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueScientifficBox
            // 
            this.ValueScientifficBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueScientifficBox.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueScientifficBox.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ValueScientifficBox.Location = new System.Drawing.Point(149, 73);
            this.ValueScientifficBox.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ValueScientifficBox.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            -2147483648});
            this.ValueScientifficBox.Name = "ValueScientifficBox";
            this.ValueScientifficBox.ReadOnly = true;
            this.ValueScientifficBox.Size = new System.Drawing.Size(48, 24);
            this.ValueScientifficBox.TabIndex = 13;
            this.ValueScientifficBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // lValueScientiffic
            // 
            this.lValueScientiffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lValueScientiffic.AutoSize = true;
            this.lValueScientiffic.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lValueScientiffic.Location = new System.Drawing.Point(129, 73);
            this.lValueScientiffic.Name = "lValueScientiffic";
            this.lValueScientiffic.Size = new System.Drawing.Size(19, 23);
            this.lValueScientiffic.TabIndex = 12;
            this.lValueScientiffic.Text = "e";
            // 
            // ValueBox
            // 
            this.ValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBox.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueBox.Location = new System.Drawing.Point(12, 73);
            this.ValueBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            262144});
            this.ValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(115, 24);
            this.ValueBox.TabIndex = 11;
            this.ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lValue.Location = new System.Drawing.Point(12, 53);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(38, 17);
            this.lValue.TabIndex = 10;
            this.lValue.Text = "Value";
            // 
            // NameProperty
            // 
            this.NameProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameProperty.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameProperty.Location = new System.Drawing.Point(12, 26);
            this.NameProperty.Name = "NameProperty";
            this.NameProperty.Size = new System.Drawing.Size(185, 24);
            this.NameProperty.TabIndex = 9;
            // 
            // lNameProperty
            // 
            this.lNameProperty.AutoSize = true;
            this.lNameProperty.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameProperty.Location = new System.Drawing.Point(12, 6);
            this.lNameProperty.Name = "lNameProperty";
            this.lNameProperty.Size = new System.Drawing.Size(41, 17);
            this.lNameProperty.TabIndex = 8;
            this.lNameProperty.Text = "Name";
            // 
            // PartPropertiesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueScientifficBox);
            this.Controls.Add(this.lValueScientiffic);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.NameProperty);
            this.Controls.Add(this.lNameProperty);
            this.Name = "PartPropertiesUC";
            this.Size = new System.Drawing.Size(210, 400);
            ((System.ComponentModel.ISupportInitialize)(this.ValueScientifficBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown ValueScientifficBox;
        private Label lValueScientiffic;
        private NumericUpDown ValueBox;
        private Label lValue;
        private TextBox NameProperty;
        private Label lNameProperty;
    }
}
