using Memory;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"

                       /$$                     /$$                     /$$      
                      | $$                    | $$                    | $$      
              /$$$$$$ | $$ /$$   /$$ /$$$$$$$ | $$  /$$$$$$   /$$$$$$$| $$   /$$
             /$$__  $$| $$| $$  | $$| $$__  $$| $$ /$$__  $$ /$$_____/| $$  /$$/
            | $$  \ $$| $$| $$  | $$| $$  \ $$| $$| $$  \ $$| $$      | $$$$$$/ 
            | $$  | $$| $$| $$  | $$| $$  | $$| $$| $$  | $$| $$      | $$_  $$ 
            |  $$$$$$$| $$|  $$$$$$/| $$  | $$| $$|  $$$$$$/|  $$$$$$$| $$ \  $$
             \____  $$|__/ \______/ |__/  |__/|__/ \______/  \_______/|__/  \__/
                  | $$                                                          
                  | $$                                                          
                  |__/                                                          
");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(" [qlunlock] Code written by newguy, addresses by Tactical");
        Mem m = new Mem();

        int processId = m.GetProcIdFromName("quakelive_steam");
        if (processId > 0)
        {
            m.OpenProcess(processId);

            string address = "quakelive_steam.exe+1043098";
            int value = 500;

            bool success = m.WriteMemory(address, "int", value.ToString());

            Console.WriteLine(success ? "   [qlunlock] Memory written successfully!" : "[qlunlock] Failed to write memory. Try again maybe?");
        }
        else
        {
            Console.WriteLine(" [qlunlock] Quake Live is not open!");
        }
        Console.ReadLine();
    }
}
