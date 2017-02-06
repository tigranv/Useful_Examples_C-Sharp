# Directory Tree  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

It is just a challenge given by my mentor.

![directory tree](https://cloud.githubusercontent.com/assets/24522089/22175859/2c1eaaa8-e017-11e6-9694-17371ac3d4be.PNG)

### Code 

```c#
public static void DirectoryTree(string fullPath)
{
    string[] directories = fullPath.Split('\\');
    string subPath = "";
    int cursorUp = 0;
    int cursorLeft = 0;

    for (int i = 0; i < directories.Length-1; i++)
    {
        subPath += directories[i] + @"\";
        DirectoryInfo directory = new DirectoryInfo(subPath);
        var files = directory.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).Select(f => f.Name).ToArray();
        var folders = directory.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).Select(f => f.Name).ToArray();             
        int longestFolder = folders.Length != 0 ? (folders).Where(s => s.Length == folders.Max(m => m.Length)).First().Length:0;
        int longestFle = files.Length != 0? (files).Where(s => s.Length == files.Max(m => m.Length)).First().Length : 0;
        int longestName =3 + (longestFolder <= longestFle ? longestFle:longestFolder)<=25? (longestFolder <= longestFle ? longestFle : longestFolder) : 26;
        int j = 0;

        for (int k = 0; k < folders.Length; k++)
        {
            folders[k] = folders[k].Length <= 25 ? folders[k] : (folders[k].Substring(0, 22) + "...");

            if (folders[k] != directories[i + 1])
            {
                Console.SetCursorPosition(cursorLeft, cursorUp + j);
                Console.WriteLine("+" + folders[k]);
                j++;
            }
            else
            {
                if (i != directories.Length - 2)
                {
                    Console.SetCursorPosition(cursorLeft, cursorUp + j);
                    Console.WriteLine("-" + folders[k] + new string('-', longestName - directories[i + 1].Length) + "--\u261B");
                    j++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(cursorLeft, cursorUp + j);
                    Console.WriteLine("***"+ folders[k] + "***");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    j++;
                }
            }
        }

        for(int k = 0; k <  files.Length; k++)
        {
            files[k] = files[k].Length <= 25 ? files[k] : (files[k].Substring(0, 22) + "...");
            Console.SetCursorPosition(cursorLeft, cursorUp + j);
            Console.WriteLine("+" + files[k]);
            j++;
        }

        cursorUp += Array.IndexOf(folders, directories[i+1]) + 1;
        cursorLeft += longestName+3;
    }
}
```


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

