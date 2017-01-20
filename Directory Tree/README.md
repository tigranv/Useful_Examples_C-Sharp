# Directory Tree  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 


![directory path](https://cloud.githubusercontent.com/assets/24522089/22165681/889cf9ac-df76-11e6-8c4e-9dde6157ad66.gif)


### Code 

```c#
public static void DirectoryTree(string path)
{

    string[] directories = path.Split('\\');
    string path1 = "";
    int cursorUp = 0;
    int cursorLeft = 0;

    for (int i = 0; i < directories.Length - 1; i++)
    {
        path1 += directories[i] + @"\";
        string[] files = Directory.GetDirectories(path1).Select(Path.GetFileName).ToArray(); ;
        int j = 0;
        int longestfile = (files).Where(s => s.Length == files.Max(m => m.Length)).First().Length;

        foreach (string name in files)
        {
            if (name != directories[i + 1])
            {
                Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                Console.WriteLine("+" + name);
                j++;
            }
            else
            {
                if (i != directories.Length - 2)
                {
                    Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                    Console.WriteLine("-" + name + new string('-', longestfile - directories[i + 1].Length) + ">");
                    j++;
                }
                else
                {
                    Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                    Console.WriteLine(name);
                }

            }
        }
        cursorUp += Array.IndexOf(files, directories[i + 1]) + 1;
        cursorLeft += longestfile + 1;
    }
}
```


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

