using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaparos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int egyenlegem = 2000;
            Random rnd = new Random();
        FőMenu:
            Console.WriteLine(@"                                                               
                                                    88                                                              
                                                    88              ,d      ,d                                      
                                                    88              88      88                                      
                                                    88  ,adPPYba, MM88MMM MM88MMM ,adPPYba, 8b,dPPYba, 8b       d8  
                                                    88 a8""     ""8a  88      88   a8P_____88 88P'   ""Y8 `8b     d8'  
                                                    88 8b       d8  88      88   8PP"""""""""""""" 88          `8b   d8'   
                                                    88 ""8a,   ,a8""  88,     88,  ""8b,   ,aa 88           `8b,d8'    
                                                    88  `""YbbdP""'   ""Y888   ""Y888 `""Ybbd8""' 88             Y88'     
                                                                                                           d8'      
                                                                                                          d8'       
");
            Console.WriteLine(@"                                                                            Szerencse játék");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(@"                                                                                 ENTER");
            Console.ReadKey();
            Console.Clear();
            goto Szerencsejáték;

            Szerencsejáték:

            Console.WriteLine(@"                                                               
                                                    88                                                              
                                                    88              ,d      ,d                                      
                                                    88              88      88                                      
                                                    88  ,adPPYba, MM88MMM MM88MMM ,adPPYba, 8b,dPPYba, 8b       d8  
                                                    88 a8""     ""8a  88      88   a8P_____88 88P'   ""Y8 `8b     d8'  
                                                    88 8b       d8  88      88   8PP"""""""""""""" 88          `8b   d8'   
                                                    88 ""8a,   ,a8""  88,     88,  ""8b,   ,aa 88           `8b,d8'    
                                                    88  `""YbbdP""'   ""Y888   ""Y888 `""Ybbd8""' 88             Y88'     
                                                                                                           d8'      
                                                                                                          d8'       
");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine (@"
                                                ██████████          ██████████          ██████████          ██████████
                                                ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██
                                                ██▒░░░░▒██          ██▒░░░░▒██          ██▒░░░░▒██          ██▒░░░░▒██
                                                ██▒░▓▓░▒██          ██▒░▓▓░▒██          ██▒░▓▓░▒██          ██▒░▓▓░▒██
                                                ██▒░▓▓░▒██          ██▒░▓▓░▒██          ██▒░▓▓░▒██          ██▒░▓▓░▒██
                                                ██▒░░░░▒██          ██▒░░░░▒██          ██▒░░░░▒██          ██▒░░░░▒██
                                                ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██          ██▒▒▒▒▒▒██
                                                ██▒▒░▒▒▒██          ██▒▒░▒▒▒██          ██▒▒░▒▒▒██          ██▒▒░▒▒▒██
                                                ██████████          ██████████          ██████████          ██████████
                                                  |300ft|            |500ft|              |800ft|            |1000ft|
");
            var valasz = Console.ReadLine();
            goto FőMenu;
            Console.WriteLine(@"Szerencse játék");
            Console.WriteLine(@"Vegyél egy jegyet 200ft ért!");
            Console.ReadLine();
        }
    }
}
