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
    public partial class PartPropertiesUC : UserControl
    {
        public PartPropertiesUC()
        {
            InitializeComponent();
        }

        public void SetColors(Color TitleColor, Color TextColor, Color BackColor)
        {
            SetColors(TitleColor, BackColor);

            //Set TextColor
            NameProperty.ForeColor = TextColor;
            ValueBox.ForeColor = TextColor;
            ValueScientifficBox.ForeColor = TextColor;
        }
        public void SetColors(Color TitleColor, Color BackColor)
        {
            //Set TitleColors
            lNameProperty.ForeColor = TitleColor;
            lValue.ForeColor = TitleColor;

            //Set BackColor
            this.BackColor = BackColor;
        }
    }
}
