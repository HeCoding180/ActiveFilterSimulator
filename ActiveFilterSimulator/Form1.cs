namespace ActiveFilterSimulator
{
    public partial class Form1 : Form
    {
        readonly Color BACKCOLOR_DEFAULT = Color.FromArgb(87, 93, 107);
        readonly Color BACKCOLOR_MEDIUM = Color.FromArgb(70, 74, 84);
        readonly Color BACKCOLOR_MEDIUM_DIM = Color.FromArgb(66, 70, 79);
        readonly Color BACKCOLOR_DARK = Color.FromArgb(39, 42, 56);
        readonly Color FORECOLOR_DEFAULT = Color.FromArgb(36, 101, 255);

        public Form1()
        {
            InitializeComponent();

            //Title Bar & Pannel Colors
            this.BackColor = BACKCOLOR_DARK;
            bMinimize.ForeColor = BACKCOLOR_DEFAULT;
            bMaximize.ForeColor = BACKCOLOR_DEFAULT;
            bMinimize.BackColor = BACKCOLOR_DEFAULT;
            bMaximize.BackColor = BACKCOLOR_DEFAULT;
            lTitle.ForeColor = FORECOLOR_DEFAULT;
            MainPannelSplitContainer.Panel1.BackColor = BACKCOLOR_DEFAULT;
            MainPannelSplitContainer.Panel2.BackColor = BACKCOLOR_MEDIUM;

            //Main pannel and property pannel objects' ForeColors
            lProperties.ForeColor = FORECOLOR_DEFAULT;

            lNameProperty.ForeColor = FORECOLOR_DEFAULT;
            lValue.ForeColor = FORECOLOR_DEFAULT;

            //Main pannel and property pannel objects' BackColors
            lProperties.BackColor = BACKCOLOR_MEDIUM_DIM;
        }

        //Makes the window movable, even tho that it has no titlebar, was copied from GitHub (https://stackoverflow.com/a/28437841)
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                bMaximize.BackgroundImage = Properties.Resources.MaximizeIcon_2;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                bMaximize.BackgroundImage = Properties.Resources.MinimizeIcon;
            }
        }
    }
}