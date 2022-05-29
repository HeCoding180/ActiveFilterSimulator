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

        //Pen netPen = new Pen(Color.Black, 2);

        PartUC PartPropertySelectReference;

        PropertySelect currentProperty;

        List<PartUC> PartUCrefList;
        ComplexPartTreeEngine partTreeEngine;

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

            //Part UserControls
            //PartUC list for naming rule checking and more
            PartUCrefList = new List<PartUC>();
            PartUCrefList.Add(PartZ1A1);
            PartUCrefList.Add(PartZ1A2);
            PartUCrefList.Add(PartZ1A3);
            PartUCrefList.Add(PartZ1B1);
            PartUCrefList.Add(PartZ1B2);
            PartUCrefList.Add(PartZ1B3);

            PartUCrefList.Add(PartZ2A1);
            PartUCrefList.Add(PartZ2A2);
            PartUCrefList.Add(PartZ2A3);
            PartUCrefList.Add(PartZ2B1);
            PartUCrefList.Add(PartZ2B2);
            PartUCrefList.Add(PartZ2B3);

            foreach (PartUC PartUCref in PartUCrefList)
            {
                PartUCref.PartClicked += PartClickedEvent;
                PartUCref.BackColor = BACKCOLOR_PART;
                //Set the default part names
                PartUCref.PartName = PartUCref.Name.Replace("Part", "");
            }

            SelectPropertyType(PropertySelect.AmpProperties);
            loadProperties();

            //ComplexPartTreeEngine initialization
            partTreeEngine = new ComplexPartTreeEngine();
        }

        private void PartClickedEvent(PartUC sender)
        {
            SelectPropertyType(PropertySelect.PartProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
            if (sender != null)
            {
                PartPropertySelectReference = sender;
                PartPropertySelectReference.BackColor = BACKCOLOR_PART_SELECTED;
            }
            loadProperties();
        }

        private void MainPannelSplitContainer_Panel1_Click(object sender, EventArgs e)
        {
            SelectPropertyType(PropertySelect.AmpProperties);
            if (PartPropertySelectReference != null) PartPropertySelectReference.BackColor = BACKCOLOR_PART;
        }

        //Makes the window movable, even though the form is borderless (was copied from GitHub: https://stackoverflow.com/a/28437841)
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
            currentProperty = type;
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
                    break;
                case PropertySelect.PartProperties:
                    partPropertyControl.PartName = PartPropertySelectReference.PartName;
                    partPropertyControl.PartValue = PartPropertySelectReference.PartValue;
                    partPropertyControl.PartType = PartPropertySelectReference.PartType;
                    break;
            }
        }
        private void StoreProperties(object sender, EventArgs e)
        {
            switch (currentProperty)
            {
                case PropertySelect.AmpProperties:
                    break;
                case PropertySelect.PartProperties:
                    bool invalidName = false;
                    foreach (PartUC PartUCref in PartUCrefList)
                    {
                        if ((PartUCref.PartName == partPropertyControl.PartName) && (PartUCrefList.IndexOf(PartUCref) != PartUCrefList.IndexOf(PartPropertySelectReference)))
                            invalidName = true;
                    }
                    if (!invalidName)
                        PartPropertySelectReference.PartName = partPropertyControl.PartName;
                    else
                    {
                        MessageBox.Show("Another part with the name '" + partPropertyControl.PartName + "' already exists", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        partPropertyControl.PartName = PartPropertySelectReference.PartName;
                    }
                    PartPropertySelectReference.PartValue = partPropertyControl.PartValue;
                    PartPropertySelectReference.PartType = partPropertyControl.PartType;
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

        private void bZ1AB1Net_Click(object sender, EventArgs e)
        {

        }

        private void bZ1AB2Net_Click(object sender, EventArgs e)
        {

        }

        private void bZ2AB1Net_Click(object sender, EventArgs e)
        {

        }
    }
}