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
    public delegate void PartUCEventHandler(PartUC sender);

    public partial class PartUC : UserControl
    {
        public event PartUCEventHandler PartClicked;

        private string _partName { set; get; }
        public string PartName
        {
            set
            {
                _partName = value;
                if ((_partType == "Open") || (_partType == "Connection"))
                    lName.Text = "";
                else
                    lName.Text = _partName;
            }
            get
            {
                return _partName;
            }
        }

        private double _partValue { set; get; }
        public double PartValue
        {
            set
            {
                _partValue = value;
                ScientifficValue scientifficValue = ScientifficValue.ParseValueToScientifficValue(value);

                if ((PartType == "Open") || (PartType == "Connection"))
                    lValue.Text = "";
                else
                    lValue.Text = scientifficValue.BareValue.ToString() + GetExtension(_partType, scientifficValue.ValueScientiffic);
            }
            get
            {
                return _partValue;
            }
        }

        private string _partType { set; get; }
        public string PartType
        {
            set
            {
                _partType = value;
                switch (_partType)
                {
                    case "Connection":
                        PartSymbolPannel.BackgroundImage = Image.FromFile(getPrivateImageFolder() + "Connection.png");
                        break;
                    case "Resistor":
                        PartSymbolPannel.BackgroundImage = Image.FromFile(getPrivateImageFolder() + "Resistor.png");
                        break;
                    case "Capacitor":
                        PartSymbolPannel.BackgroundImage = Image.FromFile(getPrivateImageFolder() + "Capacitor.png");
                        break;
                    case "Inductor":
                        PartSymbolPannel.BackgroundImage = Image.FromFile(getPrivateImageFolder() + "Inductor.png");
                        break;
                    default:
                        //Open Connection / Not Connected
                        _partType = "Open";
                        PartSymbolPannel.BackgroundImage = Image.FromFile(getPrivateImageFolder() + "Open.png");
                        break;
                }

                PartName = _partName;
                PartValue = _partValue;
            }
            get
            {
                return _partType;
            }
        }

        public PartUC()
        {
            InitializeComponent();

            PartName = "";
            PartValue = 1.0f;
            PartType = "Open";
        }

        private void InvokeClickedEvent(object sender, EventArgs e)
        {
            PartUCEventHandler handler = PartClicked;
            handler?.Invoke(this);
        }

        private string getPrivateImageFolder()
        {
            string CurrentDir = Directory.GetCurrentDirectory();
            CurrentDir = CurrentDir.Replace(@"bin\Debug\net6.0-windows", @"PartSymbols\");
            return CurrentDir;
        }

        private string GetExtension(string type, int scientiffic)
        {
            string scientifficCharacter;

            switch (scientiffic)
            {
                case 18:
                    scientifficCharacter = "E"; //Exa
                    break;
                case 15:
                    scientifficCharacter = "P"; //Peta
                    break;
                case 12:
                    scientifficCharacter = "T"; //Tera
                    break;
                case 9:
                    scientifficCharacter = "G"; //Giga
                    break;
                case 6:
                    scientifficCharacter = "M"; //Mega
                    break;
                case 3:
                    scientifficCharacter = "k"; //kilo
                    break;
                case 0:
                    scientifficCharacter = ""; //1
                    break;
                case -3:
                    scientifficCharacter = "m"; //milli
                    break;
                case -6:
                    scientifficCharacter = "µ"; //micro
                    break;
                case -9:
                    scientifficCharacter = "n"; //nano
                    break;
                case -12:
                    scientifficCharacter = "p"; //pico
                    break;
                case -15:
                    scientifficCharacter = "f"; //femto
                    break;
                case -18:
                    scientifficCharacter = "a"; //Atto
                    break;
                default:
                    scientifficCharacter = "*"; //Extension prefix out of range
                    break;
            }

            switch (_partType)
            {
                case "Connection":
                    return "";
                case "Resistor":
                    return scientifficCharacter + "Ω";
                case "Capacitor":
                    return scientifficCharacter + "F";
                case "Inductor":
                    return scientifficCharacter + "H";
                default:
                    return "";
            }
        }
    }
}
