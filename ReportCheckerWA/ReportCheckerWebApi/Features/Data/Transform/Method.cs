using System;
using System.Text;
using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.Transform
{
    public class Method
    {
        private string reverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        private string transformOption2String(string str)
        {
            string originalCharArray = this.reverseString(str);
            var outputCharArray = new List<char>();

            int i = 0;
            bool haveDigitBefore = false;
            bool getDigit = false;
            var tmpDigitCharArr = new List<char>();

            while (i < originalCharArray.Length)
            {
                int codeInt = Convert.ToInt16(originalCharArray[i]);

                if (codeInt > 47 && codeInt < 58)
                {
                    if (!haveDigitBefore)
                    {
                        haveDigitBefore = true;
                        tmpDigitCharArr.Clear();
                    }
                    tmpDigitCharArr.Add(originalCharArray[i++]);
                    continue;
                }
                if (haveDigitBefore)
                {
                    haveDigitBefore = false;
                    getDigit = true;
                    outputCharArray.Add(originalCharArray[i++]);
                    continue;
                }
                int codeIntOfCharBefore = Convert.ToInt16(originalCharArray[i - 1]);
                if (codeInt == 32 && codeIntOfCharBefore > 64 && getDigit)
                {
                    for (int j = 0; j < tmpDigitCharArr.Count; j++)
                    {
                        outputCharArray.Add(tmpDigitCharArr[j]);
                    }
                    getDigit = false;
                    outputCharArray.Add(originalCharArray[i++]);
                    continue;
                }
                outputCharArray.Add(originalCharArray[i++]);
            }

            var outputStringReverse = new string(outputCharArray.ToArray());

            return this.reverseString(outputStringReverse);
        }
        private string formatString(string str, byte option)
        {
            var originalCharArray = new char[str.Length + 1];
            var outputCharArray = new char[str.Length + 1];

            originalCharArray = option == 0 ? str.Trim().ToLower().ToCharArray() : this.transformOption2String(str.Trim()).ToCharArray();

            int count = 0;
            int i = 0;
            bool isSpaceRemoved = false;
            while (i < originalCharArray.Length)
            {
                int codeInt = Convert.ToInt16(originalCharArray[i]);
                if (codeInt == 10)
                {
                    outputCharArray[count++] = ' ';
                    i++;
                    continue;
                }

                if (isSpaceRemoved && codeInt == 32)
                {
                    i++;
                    continue;
                }

                if (codeInt > 47 && codeInt < 58)
                {
                    isSpaceRemoved = true;
                    outputCharArray[count++] = originalCharArray[i];
                    i++;
                    continue;
                }

                isSpaceRemoved = false;
                outputCharArray[count++] = originalCharArray[i];
                i++;
            }

            return new String(outputCharArray).Trim();
        }
        private int getIndexOfColor(string str)
        {
            var Colors = new List<string>();
            var colors = DBEntity.Method.getAllColors();
            foreach (var item in colors)
            {
                Colors.Add(item.Name.ToLower());
            }

            str = str.ToLower();

            int minIndex = int.MaxValue;
            foreach (var color in Colors)
            {
                int index = str.IndexOf(color);
                if (index != -1 && index < minIndex)
                {
                    minIndex = index;
                }
            }

            return (minIndex == int.MaxValue) ? -1 : minIndex;
        }
        private string toTitleCase(string str)
        {
            char[] ch = str.Trim().ToCharArray();
            ch[0] = str[0].ToString().ToUpper()[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    ch[i + 1] = ch[i + 1].ToString().ToUpper()[0];
                }
            }

            return new String(ch);
        }
        private string getNameColor(string str)
        {
            char[] ch = str.ToCharArray();
            int lastIndex = -1;
            for (int i = 0; i < ch.Length; i++)
            {
                int codeInt = Convert.ToInt16(ch[i]);
                if (codeInt > 47 && codeInt < 58)
                {
                    lastIndex = i - 1;
                    break;
                }
            }
            string nameColor = this.toTitleCase(str.Substring(0, lastIndex).Trim());

            return nameColor;
        }
        private List<CItem> filterStringData(string sourceInput, byte option)
        {
            var Items = new List<CItem>();

            try
            {
                while (true)
                {
                    int indexColor = this.getIndexOfColor(sourceInput);
                    if (indexColor == -1)
                    {
                        return Items;
                    }

                    var item = new CItem()
                    {
                        Name = this.toTitleCase(sourceInput.Substring(0, indexColor - 1))
                    };
                    sourceInput = sourceInput.Substring(indexColor);

                    while (true)
                    {
                        string nameColor = this.getNameColor(sourceInput);
                        var color = new CColor()
                        {
                            Name = nameColor
                        };

                        sourceInput = sourceInput.Substring(nameColor.Length).Trim();

                        while (true)
                        {
                            var size = new CSize();

                            if (sourceInput[0] < 48 || sourceInput[0] > 57)
                            {
                                break;
                            }

                            int count = 0;
                            while (true)
                            {
                                if (sourceInput[count] == ' ')
                                {
                                    sourceInput = sourceInput.Substring(count).Trim();
                                    color.Sizes.Add(size);
                                    break;
                                }
                                int codeInt = Convert.ToInt16(sourceInput[count]);
                                if (codeInt > 47 && codeInt < 58)
                                {
                                    size.Quantity += sourceInput[count];
                                }
                                else if (codeInt != 0)
                                {
                                    size.Name += sourceInput[count].ToString().ToUpper();
                                }

                                count++;
                                if (count >= sourceInput.Length)
                                {
                                    item.Colors.Add(color);
                                    Items.Add(item);
                                    color.Sizes.Add(size);
                                    return Items;
                                }
                            }
                        }

                        item.Colors.Add(color);

                        indexColor = this.getIndexOfColor(sourceInput);
                        if (indexColor != 0)
                        {
                            break;
                        }
                    }

                    Items.Add(item);
                }
            }
            catch
            {
                return null;
            }
        }
        public List<CItem> Execute(string pureString, byte option)
        {
            string strFormater;
            try
            {
                strFormater = this.formatString(pureString, option);
            }
            catch
            {
                strFormater = null;
            }
            if (string.IsNullOrEmpty(strFormater))
            {
                return null;
            }

            var items = this.filterStringData(strFormater, option);

            return items;
        }
    }
}