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

    public class EngineNetPart
    {
        public complexNumber zValue;

        public string netA { set; get; }
        public string netB { set; get; }

        public EngineNetPart(ComplexNetPart zNetPart)
        {
            netA = zNetPart.netA;
            netB = zNetPart.netB;
            zValue = zNetPart.zPart.ComplexResistiveProperty;
        }
        public EngineNetPart(EngineNetPart zNetPart)
        {
            netA = zNetPart.netA;
            netB = zNetPart.netB;
            zValue = zNetPart.zValue;
        }
        public EngineNetPart(complexNumber value, string NetA, string NetB)
        {
            netA = NetA;
            netB = NetB;
            zValue = value;
        }
    }

    public class ComplexPartTreeEngine
    {
        List<ComplexNetPart> netPartList;

        public ComplexPartTreeEngine()
        {
            netPartList = new List<ComplexNetPart>();
        }

        public void AddPartToNet(ComplexPart zPart, string PartName, string NetAName, string NetBName)
        {
            netPartList.Add(new ComplexNetPart(zPart, PartName, NetAName, NetBName));
        }
        public void AddPartToNet(ComplexNetPart zNetPart)
        {
            netPartList.Add(zNetPart);
        }

        public void RemovePartFromNet(string PartName)
        {
            netPartList.RemoveAt(indexOf(PartName));
        }

        public int indexOf(string PartName)
        {
            for (int i = 0; i < netPartList.Count; i++)
            {
                if (netPartList[i].Name == PartName)
                {
                    return i;
                }
            }
            //Unable to find Part with the name Specified
            return -1;
        }

        public void setPartValue(string PartName, double PartValue)
        {
            for (int i = 0; i < netPartList.Count; i++)
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
            for (int i = 0; i < netPartList.Count; i++)
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
            List<EngineNetPart> IterationList = new List<EngineNetPart>();

            foreach (ComplexNetPart netPart in netPartList)
            {
                netPart.zPart.frequency = frequency;
                IterationList.Add(new EngineNetPart(netPart));
            }

            //Tree Iterations
            while (IterationList.Count != 1)
            {
                bool MergeOccurred = false;
                //Check for parallel occurrences
                for (int indexA = 0; indexA < (IterationList.Count - 1); indexA++)
                {
                    for (int indexB = indexA + 1; indexB < IterationList.Count; indexB++)
                    {
                        if ((IterationList[indexA].netA == IterationList[indexB].netA) && (IterationList[indexA].netB == IterationList[indexB].netB))
                        {
                            //Parallel occurrence detected
                            complexNumber replacementNumber = complexNumber.reciprocal(complexNumber.reciprocal(IterationList[indexA].zValue) + complexNumber.reciprocal(IterationList[indexB].zValue));
                            mergeParts(ref IterationList, indexA, indexB, new EngineNetPart(replacementNumber, IterationList[indexA].netA, IterationList[indexA].netB));
                            MergeOccurred = true;
                            break;
                        }
                    }
                    if (MergeOccurred) break;
                }
                if (MergeOccurred) continue;

                for (int indexA = 0; indexA < (IterationList.Count - 1); indexA++)
                {
                    for (int indexB = indexA + 1; indexB < IterationList.Count; indexB++)
                    {
                        if (IterationList[indexA].netB == IterationList[indexB].netA)
                        {
                            //Series type A->B occurrence detected
                            complexNumber replacementNumber = IterationList[indexA].zValue + IterationList[indexB].zValue;
                            mergeParts(ref IterationList, indexA, indexB, new EngineNetPart(replacementNumber, IterationList[indexA].netA, IterationList[indexB].netB));
                            MergeOccurred = true;
                            break;
                        }
                        else if (IterationList[indexB].netB == IterationList[indexA].netA)
                        {
                            //Series type B->A occurrence detected
                            complexNumber replacementNumber = IterationList[indexA].zValue + IterationList[indexB].zValue;
                            mergeParts(ref IterationList, indexA, indexB, new EngineNetPart(replacementNumber, IterationList[indexB].netA, IterationList[indexA].netB));
                            MergeOccurred = true;
                            break;
                        }
                    }
                    if (MergeOccurred) break;
                }
                if (MergeOccurred) continue;

                if (IterationList.Count != 1)
                {
                    //Invalid Formation
                    throw new Exception("Invalid Part Formation");
                }
            }

            return IterationList[0].zValue;
        }

        private void mergeParts(ref List<EngineNetPart> IterationList, int IndexA, int IndexB, EngineNetPart replacementPart)
        {
            if (IndexB > IndexA)
            {
                IterationList.RemoveAt(IndexB);
                IterationList.RemoveAt(IndexA);
            }
            else
            {
                IterationList.RemoveAt(IndexA);
                IterationList.RemoveAt(IndexB);
            }
            IterationList.Add(replacementPart);
        }
    }
}
