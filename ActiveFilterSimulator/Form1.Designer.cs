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
            this.PartZ2B3 = new ActiveFilterSimulator.PartUC();
            this.PartZ2A3 = new ActiveFilterSimulator.PartUC();
            this.PartZ2B2 = new ActiveFilterSimulator.PartUC();
            this.PartZ2A2 = new ActiveFilterSimulator.PartUC();
            this.PartZ2B1 = new ActiveFilterSimulator.PartUC();
            this.PartZ2A1 = new ActiveFilterSimulator.PartUC();
            this.PartZ1B3 = new ActiveFilterSimulator.PartUC();
            this.PartZ1A3 = new ActiveFilterSimulator.PartUC();
            this.PartZ1B2 = new ActiveFilterSimulator.PartUC();
            this.PartZ1A2 = new ActiveFilterSimulator.PartUC();
            this.PartZ1B1 = new ActiveFilterSimulator.PartUC();
            this.PartZ1A1 = new ActiveFilterSimulator.PartUC();
            this.bOpenGraphView = new System.Windows.Forms.Button();
            this.bSaveConfig = new System.Windows.Forms.Button();
            this.partPropertyControl = new ActiveFilterSimulator.PartPropertiesUC();
            this.ampPropertyControl = new ActiveFilterSimulator.AmpPropertiesUC();
            this.lProperties = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bMaximize = new System.Windows.Forms.Button();
            this.MainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPannelSplitContainer)).BeginInit();
            this.MainPannelSplitContainer.Panel1.SuspendLayout();
            this.MainPannelSplitContainer.Panel2.SuspendLayout();
            this.MainPannelSplitContainer.SuspendLayout();
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
            this.MainPannel.Size = new System.Drawing.Size(1000, 575);
            this.MainPannel.TabIndex = 1;
            // 
            // MainPannelSplitContainer
            // 
            this.MainPannelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPannelSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainPannelSplitContainer.Name = "MainPannelSplitContainer";
            // 
            // MainPannelSplitContainer.Panel1
            // 
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2B3);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2A3);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2B2);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2A2);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2B1);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ2A1);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1B3);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1A3);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1B2);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1A2);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1B1);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.PartZ1A1);
            this.MainPannelSplitContainer.Panel1.Controls.Add(this.bOpenGraphView);
            this.MainPannelSplitContainer.Panel1.Click += new System.EventHandler(this.MainPannelSplitContainer_Panel1_Click);
            this.MainPannelSplitContainer.Panel1MinSize = 200;
            // 
            // MainPannelSplitContainer.Panel2
            // 
            this.MainPannelSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.bSaveConfig);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.partPropertyControl);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.ampPropertyControl);
            this.MainPannelSplitContainer.Panel2.Controls.Add(this.lProperties);
            this.MainPannelSplitContainer.Panel2MinSize = 200;
            this.MainPannelSplitContainer.Size = new System.Drawing.Size(1000, 575);
            this.MainPannelSplitContainer.SplitterDistance = 732;
            this.MainPannelSplitContainer.TabIndex = 0;
            this.MainPannelSplitContainer.TabStop = false;
            // 
            // PartZ2B3
            // 
            this.PartZ2B3.Location = new System.Drawing.Point(422, 441);
            this.PartZ2B3.Name = "PartZ2B3";
            this.PartZ2B3.Size = new System.Drawing.Size(200, 75);
            this.PartZ2B3.TabIndex = 12;
            // 
            // PartZ2A3
            // 
            this.PartZ2A3.Location = new System.Drawing.Point(216, 441);
            this.PartZ2A3.Name = "PartZ2A3";
            this.PartZ2A3.Size = new System.Drawing.Size(200, 75);
            this.PartZ2A3.TabIndex = 11;
            // 
            // PartZ2B2
            // 
            this.PartZ2B2.Location = new System.Drawing.Point(422, 360);
            this.PartZ2B2.Name = "PartZ2B2";
            this.PartZ2B2.Size = new System.Drawing.Size(200, 75);
            this.PartZ2B2.TabIndex = 10;
            // 
            // PartZ2A2
            // 
            this.PartZ2A2.Location = new System.Drawing.Point(216, 360);
            this.PartZ2A2.Name = "PartZ2A2";
            this.PartZ2A2.Size = new System.Drawing.Size(200, 75);
            this.PartZ2A2.TabIndex = 9;
            // 
            // PartZ2B1
            // 
            this.PartZ2B1.Location = new System.Drawing.Point(422, 279);
            this.PartZ2B1.Name = "PartZ2B1";
            this.PartZ2B1.Size = new System.Drawing.Size(200, 75);
            this.PartZ2B1.TabIndex = 8;
            // 
            // PartZ2A1
            // 
            this.PartZ2A1.Location = new System.Drawing.Point(216, 279);
            this.PartZ2A1.Name = "PartZ2A1";
            this.PartZ2A1.Size = new System.Drawing.Size(200, 75);
            this.PartZ2A1.TabIndex = 7;
            // 
            // PartZ1B3
            // 
            this.PartZ1B3.Location = new System.Drawing.Point(422, 182);
            this.PartZ1B3.Name = "PartZ1B3";
            this.PartZ1B3.Size = new System.Drawing.Size(200, 75);
            this.PartZ1B3.TabIndex = 6;
            // 
            // PartZ1A3
            // 
            this.PartZ1A3.Location = new System.Drawing.Point(216, 182);
            this.PartZ1A3.Name = "PartZ1A3";
            this.PartZ1A3.Size = new System.Drawing.Size(200, 75);
            this.PartZ1A3.TabIndex = 5;
            // 
            // PartZ1B2
            // 
            this.PartZ1B2.Location = new System.Drawing.Point(422, 101);
            this.PartZ1B2.Name = "PartZ1B2";
            this.PartZ1B2.Size = new System.Drawing.Size(200, 75);
            this.PartZ1B2.TabIndex = 4;
            // 
            // PartZ1A2
            // 
            this.PartZ1A2.Location = new System.Drawing.Point(216, 101);
            this.PartZ1A2.Name = "PartZ1A2";
            this.PartZ1A2.Size = new System.Drawing.Size(200, 75);
            this.PartZ1A2.TabIndex = 3;
            // 
            // PartZ1B1
            // 
            this.PartZ1B1.Location = new System.Drawing.Point(422, 20);
            this.PartZ1B1.Name = "PartZ1B1";
            this.PartZ1B1.Size = new System.Drawing.Size(200, 75);
            this.PartZ1B1.TabIndex = 2;
            // 
            // PartZ1A1
            // 
            this.PartZ1A1.Location = new System.Drawing.Point(216, 20);
            this.PartZ1A1.Name = "PartZ1A1";
            this.PartZ1A1.Size = new System.Drawing.Size(200, 75);
            this.PartZ1A1.TabIndex = 1;
            // 
            // bOpenGraphView
            // 
            this.bOpenGraphView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpenGraphView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bOpenGraphView.FlatAppearance.BorderSize = 0;
            this.bOpenGraphView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpenGraphView.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpenGraphView.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bOpenGraphView.Location = new System.Drawing.Point(0, 524);
            this.bOpenGraphView.Name = "bOpenGraphView";
            this.bOpenGraphView.Size = new System.Drawing.Size(732, 50);
            this.bOpenGraphView.TabIndex = 0;
            this.bOpenGraphView.TabStop = false;
            this.bOpenGraphView.Text = "Open Bode Plot Window";
            this.bOpenGraphView.UseVisualStyleBackColor = false;
            // 
            // bSaveConfig
            // 
            this.bSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSaveConfig.FlatAppearance.BorderSize = 0;
            this.bSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveConfig.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSaveConfig.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bSaveConfig.Location = new System.Drawing.Point(0, 524);
            this.bSaveConfig.Name = "bSaveConfig";
            this.bSaveConfig.Size = new System.Drawing.Size(264, 50);
            this.bSaveConfig.TabIndex = 2;
            this.bSaveConfig.TabStop = false;
            this.bSaveConfig.Text = "Save";
            this.bSaveConfig.UseVisualStyleBackColor = false;
            this.bSaveConfig.Click += new System.EventHandler(this.StoreProperties);
            // 
            // partPropertyControl
            // 
            this.partPropertyControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partPropertyControl.Location = new System.Drawing.Point(0, 26);
            this.partPropertyControl.Name = "partPropertyControl";
            this.partPropertyControl.Size = new System.Drawing.Size(264, 498);
            this.partPropertyControl.TabIndex = 2;
            // 
            // ampPropertyControl
            // 
            this.ampPropertyControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ampPropertyControl.Location = new System.Drawing.Point(0, 26);
            this.ampPropertyControl.Name = "ampPropertyControl";
            this.ampPropertyControl.Size = new System.Drawing.Size(264, 498);
            this.ampPropertyControl.TabIndex = 1;
            // 
            // lProperties
            // 
            this.lProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProperties.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lProperties.Location = new System.Drawing.Point(0, 0);
            this.lProperties.Name = "lProperties";
            this.lProperties.Size = new System.Drawing.Size(264, 25);
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
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.Red;
            this.bClose.Location = new System.Drawing.Point(974, 0);
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
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bMinimize.Location = new System.Drawing.Point(920, 0);
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
            this.bMaximize.FlatAppearance.BorderSize = 0;
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bMaximize.Location = new System.Drawing.Point(947, 0);
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
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.bMaximize);
            this.Controls.Add(this.bMinimize);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.MainPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPannel.ResumeLayout(false);
            this.MainPannelSplitContainer.Panel1.ResumeLayout(false);
            this.MainPannelSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPannelSplitContainer)).EndInit();
            this.MainPannelSplitContainer.ResumeLayout(false);
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
        private AmpPropertiesUC ampPropertyControl;
        private PartPropertiesUC partPropertyControl;
        private Button bSaveConfig;
        private Button bOpenGraphView;
        private PartUC PartZ2B3;
        private PartUC PartZ2A3;
        private PartUC PartZ2B2;
        private PartUC PartZ2A2;
        private PartUC PartZ2B1;
        private PartUC PartZ2A1;
        private PartUC PartZ1B3;
        private PartUC PartZ1A3;
        private PartUC PartZ1B2;
        private PartUC PartZ1A2;
        private PartUC PartZ1B1;
        private PartUC PartZ1A1;
    }
}