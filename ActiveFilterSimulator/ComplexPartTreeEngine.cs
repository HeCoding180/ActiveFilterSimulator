using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part;

namespace ActiveFilterSimulator
{
    public class ComplexNetPart
    {
        public ComplexPart zPart;

        public string Name { set; get; }

        public string netA { set; get; }
        public string netB { set; get; }

        public ComplexNetPart(ComplexPart part, string partName, string NetA, string NetB)
        {
            Name = partName;

            netA = NetA;
            netB = NetB;

            zPart = part;
        }
    }

    public class ComplexPartTreeEngine
    {
        ComplexNetPart[] netPartList;

        public ComplexPartTreeEngine()
        {

        }

        public void AddPartToNet(ComplexPart zPart, string PartName, string NetAName, string NetBName)
        {
            netPartList.Append(new ComplexNetPart(zPart, PartName, NetAName, NetBName));
        }
        public void AddPartToNet(ComplexNetPart zNetPart)
        {
            netPartList.Append(zNetPart);
        }

        public int indexOf(string PartName)
        {
            for (int i = 0; i < netPartList.Length; i++)
            {
                if (netPartList[i].Name == PartName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void setPartValue(string PartName, double PartValue)
        {
            for (int i = 0; i < netPartList.Length; i++)
            {
                if (netPartList[i].Name == PartName)
                {
                    netPartList[i].zPart.PartValue = PartValue;
                }
            }
        }
        public void setPartValue(int index, double PartValue)
        {
            netPartList[index].zPart.PartValue = PartValue;
        }

        public void renamePart(string PartNameOld, string PartNameNew)
        {
            for (int i = 0; i < netPartList.Length; i++)
            {
                if (netPartList[i].Name == PartNameOld)
                {
                    netPartList[i].Name = PartNameNew;
                }
            }
        }
        public void renamePart(int index, string PartName)
        {
            netPartList[index].Name = PartName;
        }

        public complexNumber getComplexImpedance(double frequency)
        {
            complexNumber result = new complexNumber();
            ComplexNetPart[] IterationArray = new ComplexNetPart[netPartList.Length];

            for(int i = 0; i < netPartList.Length; i++)
            {
                netPartList[i].zPart.frequency = frequency;
                IterationArray.Append(netPartList[i]);
            }

            //Tree Iterations
            while (IterationArray.Length != 0)
            for (int indexA = 0; indexA < netPartList.Length; indexA++)
            {
                for (int indexB = indexA + 1; indexB < netPartList.Length; indexB++)
                {
                    if ((IterationArray[indexA].netA == IterationArray[indexB].netA) && (IterationArray[indexA].netB == IterationArray[indexB].netB))
                    {
                        //Parallel Occurrence Detected
                        complexNumber replacementImpedance
                        IterationArray[indexA].zPart.ComplexResistiveProperty
                    }
                }
            }

            return result;
        }
    }
}
