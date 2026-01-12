using System;
using Eto;
using Eto.Forms;

namespace RiivolutionIsoBuilder
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Asu's Riivolution ISO Builder - v1.0.0 - Build Date: " + Properties.Resources.BuildDate);
            // Console.WriteLine("Special Beta Test Build - Please build all the mods you can think of with this ISO Builder and report me any bugs on discord: Asu-chan#2929\r\n\r\n");
            Platform platform = Platform.Detect;
            if (platform.IsWinForms)
            {
                try
                {
                    RiivolutionUniversalISOBuilderWin ruibWin = new RiivolutionUniversalISOBuilderWin();
                    ruibWin.Main(args);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                
                new Application(platform);
                
            }
            else
            {
                RiivolutionUniversalISOBuilderLin ruibLin = new RiivolutionUniversalISOBuilderLin();
                new Application(platform);
                ruibLin.Main(args);
            }
        }
    }

}