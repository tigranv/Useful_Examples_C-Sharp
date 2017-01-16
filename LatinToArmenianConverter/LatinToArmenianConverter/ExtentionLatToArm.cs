using System.Collections.Generic;

namespace LatinToArmenianConverter
{
    static class ExtentionLatToArm
    {
        // Extention method 
        public static string LatToArmConverter(this string value)
        {
            value.ToLower();
            var dictionary = new Dictionary<string, string>();
            string toArm = string.Empty;
            string alph = "qwertyuiopasdfghjklzxcvbnm@&";

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
            dictionary.Add("i", "ի");
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
                        case "ts":
                            toArm += "ծ";
                            i++;
                            break;

                        default:
                            if (alph.Contains(value[i].ToString()))
                            {
                                toArm += dictionary[value[i].ToString()];
                            }
                            else
                            {
                                toArm += value[i].ToString();
                            }
                            break;
                    }
                }
                else
                {
                    if (alph.Contains(value[i].ToString()))
                    {
                        toArm += dictionary[value[i].ToString()];
                    }
                    else
                    {
                        toArm += value[i].ToString();
                    }
                    break;
                }
            }
            return toArm;
        }
    }
}
