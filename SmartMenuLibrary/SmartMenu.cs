using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\" + path + "");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

            // Implement ...
        }
        public void Activate()
        {

            //int i = 0;
            //if (i = 0; i < 7; i++);
            //{
            //   string Key = Console.ReadLine();
            //}
            //else if (i = 10; i < 17; i++);

            string Key = Console.ReadLine();
            int caseSwitch = int.Parse(Key);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine(Functions.DoThis());
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine(Functions.DoThat());
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine(Functions.DoSomething("absolutely nothing"));
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.ReadLine();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                    /*ConsoleKeyInfo userinput;
                    userinput = Console.ReadKey();
                    if (userinput.Key = D1)
                    {
                        Console.WriteLine(Functions.DoThis());
                    }*/



                    // Implement ...
            }
        }
    }
}
