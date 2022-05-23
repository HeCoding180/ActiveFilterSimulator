using Part;

namespace ActiveFilterSimulator
{
    public enum PropertySelect
    {
        AmpProperties,
        PartProperties
    }

    public partial class Form1 : Form
    {
        readonly Color BACKCOLOR_DEFAULT = Color.FromArgb(87, 93, 107);
        readonly Color BACKCOLOR_PART = Color.FromArgb(77, 82, 92);
        readonly Color BACKCOLOR_PART_SELECTED = Color.FromArgb(121, 129, 145);
        readonly Color BACKCOLOR_MEDIUM = Color.FromArgb(70, 74, 84);
        readonly Color BACKCOLOR_MEDIUM_DIM = Color.FromArgb(66, 70, 79);
        readonly Color BACKCOLOR_DARK = Color.FromArgb(39, 42, 56);
        readonly Color FORECOLOR_DEFAULT = Color.FromArgb(36, 101, 255);

        Pen netPen = new Pen(Color.Black, 2);

        PartUC PartPropertySelectReference;

        PropertySelect currentProperty;

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

            //Main pannel and property pannel objects' BackColors
            lProperties.BackColor = BACKCOLOR_MEDIUM_DIM;

            //Property UserControl Colors
            partPropertyControl.SetColors(FORECOLOR_DEFAULT, BACKCOLOR_MEDIUM);
            ampPropertyControl.SetColors(FORECOLOR_DEFAULT, BACKCOLOR_MEDIUM);

            //Button Colors
            bSaveConfig.ForeColor = FORECOLOR_DEFAULT;
            bSaveConfig.BackColor = BACKCOLOR_DARK;
            bOpenGraphView.ForeColor = FORECOLOR_DEFAULT;
            bOpenGraphView.BackColor = BACKCOLOR_DARK;

            /*//Test Output
            FilterIterator ImpedanceIterator = new FilterIterator(1, 1000000, 1);
            ComplexPartTreeEngine partTreeEngine = new ComplexPartTreeEngine();
            partTreeEngine.AddPartToNet(new ComplexPart(RealPart.resistance, 10), "R1", "NetA", "NetB");
            partTreeEngine.AddPartToNet(new ComplexPart(RealPart.inductiveReactiance, 0.01), "L1", "NetB", "NetC");
            partTreeEngine.AddPartToNet(new ComplexPart(RealPart.capacitiveReactiance, 0.0000001f), "C1", "NetA", "NetC");

            List<graphPoint> ImpedancePlot = ImpedanceIterator.getImpedancePlot(partTreeEngine);
            List<graphPoint> PhasePlot = ImpedanceIterator.getImpedancePhasePlot(partTreeEngine);

            string csvString = "";
            for (int i = 0; i < PhasePlot.Count; i++)
            {
                csvString += ImpedancePlot[i].x.ToString() + ',' + ImpedancePlot[i].y.ToString() + ',' + PhasePlot[i].y.ToString() + Environment.NewLine;
            }

            File.WriteAllText(@"C:\Users\timow\Desktop\TestGraph.csv", csvString);*/

            //Part UserControl
            PartZ1A1.PartClicked += PartZ1A1_PartClicked;
            PartZ1A2.PartClicked += PartZ1A2_PartClicked;
            PartZ1A3.PartClicked += PartZ1A3_PartClicked;
            PartZ1B1.PartClicked += PartZ1B1_PartClicked;
            PartZ1B2.PartClicked += PartZ1B2_PartClicked;
            PartZ1B3.PartClicked += PartZ1B3_PartClicked;

            PartZ2A1.PartClicked += PartZ2A1_PartClicked;
            PartZ2A2.PartClicked += PartZ2A2_PartClicked;
            PartZ2A3.PartClicked += PartZ2A3_PartClicked;
            PartZ2B1.PartClicked += PartZ2B1_PartClicked;
            PartZ2B2.PartClicked += PartZ2B2_PartClicked;
            PartZ2B3.PartClicked += PartZ2B3_PartClicked;

            PartZ1A1.BackColor = BACKCOLOR_PART;
            PartZ1A2.BackColor = BACKCOLOR_PART;
            PartZ1A3.BackColor = BACKCOLOR_PART;
            PartZ1B1.BackColor = BACKCOLOR_PART;
            PartZ1B2.BackColor = BACKCOLOR_PART;
            PartZ1B3.BackColor = BACKCOLOR_PART;

            PartZ2A1.BackColor = BACKCOLOR_PART;
            PartZ2A2.BackColor = BACKCOLOR_PART;
            PartZ2A3.BackColor = BACKCOLOR_PART;
            PartZ2B1.BackColor = BACKCOLOR_PART;
            PartZ2B2.BackColor = BACKCOLOR_PART;
            PartZ2B3.BackColor = BACKCOLOR_PART;
        }

        private void PartZ2B3_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2B3;
            loadProperties();
        }

        private void PartZ2B2_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2B2;
            loadProperties();
        }

        private void PartZ2B1_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2B1;
            loadProperties();
        }

        private void PartZ2A3_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2A3;
            loadProperties();
        }

        private void PartZ2A2_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2A2;
            loadProperties();
        }

        private void PartZ2A1_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ2A1;
            loadProperties();
        }

        private void PartZ1B3_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1B3;
            loadProperties();
        }

        private void PartZ1B2_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1B2;
            loadProperties();
        }

        private void PartZ1B1_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1B1;
            loadProperties();
        }

        private void PartZ1A3_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1A3;
            loadProperties();
        }

        private void PartZ1A2_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1A2;
            loadProperties();
        }

        private void PartZ1A1_PartClicked(object? sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            PartPropertySelectReference = PartZ1A1;
            loadProperties();
        }

        private void MainPannelSplitContainer_Panel1_Click(object sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.AmpProperties);
            PartPropertySelectReference = PartZ2B3;
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

        public void SelectPropertyType(PropertySelect type)
        {
            if (type == PropertySelect.PartProperties)
            {
                partPropertyControl.BringToFront();
            }
            else
            {
                ampPropertyControl.BringToFront();
            }
        }

        public void loadProperties()
        {
            switch (currentProperty)
            {
                case PropertySelect.AmpProperties:
                    PartPropertySelectReference.BackColor = BACKCOLOR_PART_SELECTED;
                    partPropertyControl.PartName = PartPropertySelectReference.PartName;
                    partPropertyControl.PartValue = PartPropertySelectReference.PartValue;
                    partPropertyControl.PartType = PartPropertySelectReference.PartType;
                    break;
                case PropertySelect.PartProperties:
                    break;
            }
        }
        private void StoreProperties(object sender, EventArgs e)
        {
            switch (currentProperty)
            {
                case PropertySelect.AmpProperties:
                    PartPropertySelectReference.PartName = partPropertyControl.PartName;
                    PartPropertySelectReference.PartValue = partPropertyControl.PartValue;
                    PartPropertySelectReference.PartType = partPropertyControl.PartType;
                    break;
                case PropertySelect.PartProperties:
                    break;
            }
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

        private void bPartConfig_Click(object sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.PartProperties);
        }

        private void bAmpConfig_Click(object sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.AmpProperties);
        }
    }
}