using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Part;

namespace ActiveFilterSimulator
{
    public partial class PartPropertiesUC : UserControl
    {
        public string PartName
        {
            set
            {
                NameProperty.Text = value;
            }
            get
            {
                return NameProperty.Text;
            }
        }

        private ScientifficValue _value { set; get; }
        public double PartValue
        {
            set
            {
                _value = ScientifficValue.ParseValueToScientifficValue(value);
                ValueBox.Value = Convert.ToDecimal(_value.BareValue);
                ValueScientifficBox.Value = Convert.ToDecimal(_value.ValueScientiffic);
            }
            get
            {
                _value = new ScientifficValue(Convert.ToDouble(ValueBox.Value), Convert.ToInt16(ValueScientifficBox.Value));
                return _value.constructValue();
            }
        }

        public string PartType
        {
            set
            {
                PartTypeCombobox.Text = value;
            }
            get
            {
                return PartTypeCombobox.Text;
            }
        }

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
            PartTypeCombobox.ForeColor = TextColor;
        }
        public void SetColors(Color TitleColor, Color BackColor)
        {
            //Set TitleColors
            lNameProperty.ForeColor = TitleColor;
            lValue.ForeColor = TitleColor;
            lPartType.ForeColor = TitleColor;

            //Set BackColor
            this.BackColor = BackColor;
        }
    }
}
