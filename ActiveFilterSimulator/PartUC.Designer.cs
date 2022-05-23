namespace ActiveFilterSimulator
{
    partial class PartUC
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
            this.PartSymbolPannel = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PartSymbolPannel
            // 
            this.PartSymbolPannel.Location = new System.Drawing.Point(0, 0);
            this.PartSymbolPannel.Name = "PartSymbolPannel";
            this.PartSymbolPannel.Size = new System.Drawing.Size(75, 75);
            this.PartSymbolPannel.TabIndex = 0;
            this.PartSymbolPannel.Click += new System.EventHandler(this.InvokeClickedEvent);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(81, 5);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 23);
            this.lName.TabIndex = 1;
            this.lName.Click += new System.EventHandler(this.InvokeClickedEvent);
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lValue.Location = new System.Drawing.Point(81, 28);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(0, 23);
            this.lValue.TabIndex = 2;
            this.lValue.Click += new System.EventHandler(this.InvokeClickedEvent);
            // 
            // PartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.PartSymbolPannel);
            this.Name = "PartUC";
            this.Size = new System.Drawing.Size(200, 75);
            this.Click += new System.EventHandler(this.InvokeClickedEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PartSymbolPannel;
        private Label lName;
        private Label lValue;
    }
}
