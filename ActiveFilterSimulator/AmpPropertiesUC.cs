using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveFilterSimulator
{
    public partial class AmpPropertiesUC : UserControl
    {
        public AmpPropertiesUC()
        {
            InitializeComponent();
        }

        public void SetColors(Color TitleColor, Color TextColor, Color BackColor)
        {
            SetColors(TitleColor, BackColor);

            //Set TextColors
            GBPvalue.ForeColor = TextColor;
            GBPscientiffic.ForeColor = TextColor;
            OpenLoopGainControl.ForeColor = TextColor;
        }
        public void SetColors(Color TitleColor, Color BackColor)
        {
            //Set TitleColors
            lGBP.ForeColor = TitleColor;
            lOpenLoopGain.ForeColor = TitleColor;

            //Set BackColor
            this.BackColor = BackColor;
        }
    }
}
