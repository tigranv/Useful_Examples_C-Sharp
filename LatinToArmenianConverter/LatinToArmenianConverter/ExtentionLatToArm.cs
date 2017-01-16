using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinToArmenianConverter
{
    static class ExtentionLatToArm
    {
        // Extention method 
        public static string LatToArmConverter(this string value)
        {
            value.ToLower();
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("&", "ճ");
            dictionary.Add("@", "ը");
            dictionary.Add("a", "ա");
            dictionary.Add("b", "բ");
            dictionary.Add("c", "ց");
            dictionary.Add("d", "դ");
            dictionary.Add("e", "ե");
            dictionary.Add("f", "ֆ");
            dictionary.Add("g", "գ");
            dictionary.Add("h", "հ");
            dictionary.Add("j", "ջ");
            dictionary.Add("k", "կ");
            dictionary.Add("l", "լ");
            dictionary.Add("m", "մ");
            dictionary.Add("n", "ն");
            dictionary.Add("o", "օ");
            dictionary.Add("p", "պ");
            dictionary.Add("q", "ք");
            dictionary.Add("r", "ր");
            dictionary.Add("s", "ս");
            dictionary.Add("t", "տ");
            dictionary.Add("u", "ու");
            dictionary.Add("v", "վ");
            dictionary.Add("w", "ո");
            dictionary.Add("x", "խ");
            dictionary.Add("y", "յ");
            dictionary.Add("z", "զ");
            dictionary.Add(" ", " ");
            dictionary.Add(".", ".");
            dictionary.Add(",", ",");
            dictionary.Add(":", ":");
            dictionary.Add("(", "(");
            dictionary.Add(")", ")");
            dictionary.Add("[", "[");
            dictionary.Add("]", "]"); 
            dictionary.Add("{", "}");
            dictionary.Add("]", "]");


            string toArm = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                if (i != value.Length - 1)
                {
                    switch (value.Substring(i, 2))
                    {
                        case "dz":
                            toArm += "ձ";
                            i++;
                            break;
                        case "ev":
                            toArm += "և";
                            i++;
                            break;
                        case "jh":
                            toArm += "ժ";
                            i++;
                            break;
                        case "ch":
                            toArm += "չ";
                            i++;
                            break;
                        case "gh":
                            toArm += "ղ";
                            i++;
                            break;
                        case "sh":
                            toArm += "շ";
                            i++;
                            break;

                        default:
                            toArm += dictionary[value[i].ToString()];
                            break;
                    }
                }
                else
                {
                    toArm += dictionary[value[i].ToString()];
                }
            }
            return toArm;
        }
    }
}
