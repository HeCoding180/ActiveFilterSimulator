namespace ActiveFilterSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPannel = new System.Windows.Forms.Panel();
            this.MainPannelSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ValueScientifficBox = new System.Windows.Forms.NumericUpDown();
            this.lValueScientiffic = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.lValue = new System.Windows.Forms.Label();
            this.NameProperty = new System.Windows.Forms.TextBox();
            this.lNameProperty = new System.Windows.Forms.Label();
            this.lProperties = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bMaximize = new System.Windows.Forms.Button();
            this.MainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPannelSplitContainer)).BeginInit();
            this.MainPannelSplitContainer.Panel2.SuspendLayout();
            this.MainPannelSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueScientifficBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPannel
            // 
            this.MainPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPannel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPannel.Controls.Add(this.MainPannelSplitContainer);
            this.MainPannel.Location = new System.Drawing.Point(0, 26);
            this.MainPannel.Name = "MainPannel";
            this.MainPannel.Size = new System.Drawing.Size(800, 425);
            this.MainPannel.TabIndex = 1;
            // 
            // MainPannelSplitContainer
            // 
            this.MainPannelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPannelSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainPannelSplitContainer.Name = "MainPannelSplitContainer";
            this.MainPannelSplitContainer.Panel1MinSize = 200;
            // 
            // MainPannelSplitContainer.Panel2
            // 
            this.MainPannelSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.ValueScientifficBox);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.lValueScientiffic);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.ValueBox);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.lValue);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.NameProperty);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.lNameProperty);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.lProperties);
            this.MainPannelSplitContainer.Panel2MinSize = 200;
            this.MainPannelSplitContainer.Size = new System.Drawing.Size(800, 425);
            this.MainPannelSplitContainer.SplitterDistance = 586;
            this.MainPannelSplitContainer.TabIndex = 0;
            this.MainPannelSplitContainer.TabStop = false;
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
            this.ValueScientifficBox.Location = new System.Drawing.Point(150, 96);
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
            this.ValueScientifficBox.Size = new System.Drawing.Size(48, 24);
            this.ValueScientifficBox.TabIndex = 7;
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
            this.lValueScientiffic.Location = new System.Drawing.Point(130, 96);
            this.lValueScientiffic.Name = "lValueScientiffic";
            this.lValueScientiffic.Size = new System.Drawing.Size(19, 23);
            this.lValueScientiffic.TabIndex = 6;
            this.lValueScientiffic.Text = "e";
            // 
            // ValueBox
            // 
            this.ValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBox.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueBox.Location = new System.Drawing.Point(13, 96);
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
            this.ValueBox.TabIndex = 5;
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
            this.lValue.Location = new System.Drawing.Point(13, 76);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(38, 17);
            this.lValue.TabIndex = 3;
            this.lValue.Text = "Value";
            // 
            // NameProperty
            // 
            this.NameProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameProperty.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameProperty.Location = new System.Drawing.Point(13, 49);
            this.NameProperty.Name = "NameProperty";
            this.NameProperty.Size = new System.Drawing.Size(185, 24);
            this.NameProperty.TabIndex = 2;
            // 
            // lNameProperty
            // 
            this.lNameProperty.AutoSize = true;
            this.lNameProperty.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameProperty.Location = new System.Drawing.Point(13, 29);
            this.lNameProperty.Name = "lNameProperty";
            this.lNameProperty.Size = new System.Drawing.Size(41, 17);
            this.lNameProperty.TabIndex = 1;
            this.lNameProperty.Text = "Name";
            // 
            // lProperties
            // 
            this.lProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProperties.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lProperties.Location = new System.Drawing.Point(0, 0);
            this.lProperties.Name = "lProperties";
            this.lProperties.Size = new System.Drawing.Size(210, 25);
            this.lProperties.TabIndex = 0;
            this.lProperties.Text = "Properties";
            this.lProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lTitle.Location = new System.Drawing.Point(2, 1);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(165, 23);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Active Filter Simulator";
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackgroundImage = global::ActiveFilterSimulator.Properties.Resources.CloseIcon_Red;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.Red;
            this.bClose.Location = new System.Drawing.Point(774, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(26, 26);
            this.bClose.TabIndex = 3;
            this.bClose.TabStop = false;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bMinimize
            // 
            this.bMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bMinimize.BackgroundImage = global::ActiveFilterSimulator.Properties.Resources.MinimizeIcon_2;
            this.bMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bMinimize.Location = new System.Drawing.Point(720, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(26, 26);
            this.bMinimize.TabIndex = 4;
            this.bMinimize.TabStop = false;
            this.bMinimize.UseVisualStyleBackColor = false;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bMaximize
            // 
            this.bMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMaximize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bMaximize.BackgroundImage = global::ActiveFilterSimulator.Properties.Resources.MaximizeIcon_2;
            this.bMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bMaximize.Location = new System.Drawing.Point(747, 0);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Size = new System.Drawing.Size(26, 26);
            this.bMaximize.TabIndex = 5;
            this.bMaximize.TabStop = false;
            this.bMaximize.UseVisualStyleBackColor = false;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMaximize);
            this.Controls.Add(this.bMinimize);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.MainPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPannel.ResumeLayout(false);
            this.MainPannelSplitContainer.Panel2.ResumeLayout(false);
            this.MainPannelSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPannelSplitContainer)).EndInit();
            this.MainPannelSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValueScientifficBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel MainPannel;
        private Label lTitle;
        private Button bClose;
        private Button bMinimize;
        private Button bMaximize;
        private SplitContainer MainPannelSplitContainer;
        private Label lProperties;
        private Label lNameProperty;
        private TextBox NameProperty;
        private Label lValueScientiffic;
        private NumericUpDown ValueBox;
        private Label lValue;
        private NumericUpDown ValueScientifficBox;
    }
}