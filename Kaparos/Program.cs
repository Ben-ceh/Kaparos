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
        static int egyenlegem = 2000;
        static Random rnd = new Random();
        static int nyitasomOsszesenEddig = 0;
        static void Main(string[] args)
        {
             
            

        FőMenu: //Főmenü kezdete
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
            string s = @"Egyenlegem: ";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s + egyenlegem + "ft.");
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
                                                    1.                  2.                  3.                  4.

");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            string menu = @"Kérlek válasz egy tetszőleges kaparós sorsjegyet!";
            Console.SetCursorPosition((Console.WindowWidth - menu.Length) / 2, Console.CursorTop);
            Console.WriteLine(menu);

            int jegy = int.Parse(Console.ReadLine()); //Melyik jegy 1.

            string mennyiseg = @"Mennyit szertnél nyitni ?";
            Console.SetCursorPosition((Console.WindowWidth - mennyiseg.Length) / 2, Console.CursorTop);
            Console.WriteLine($"{mennyiseg} (Jelenleg ennyit tudsz kaparni ebből a jegyből: {porgetesMennyi(jegy)} db.)");

            int jegyLehetsegesNyitas = (int)Convert.ToUInt32(porgetesMennyi(jegy)); //jegyLehetsegesNyitas 3.
            int jegyMennyiseg = int.Parse(Console.ReadLine()); //Mennyiség 2.
            Console.ReadKey();
        Jatek:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            var jatekInformacio = $"{jegy}. számú jegyből fogsz nyitni\n{mennyiseg}db-ot.";
            Console.SetCursorPosition((Console.WindowWidth - jatekInformacio.Length) / 2, Console.CursorTop);
            Console.WriteLine(jatekInformacio);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            var rdy = $"Készen állsz a nyitásra?(igen/nem)";
            Console.SetCursorPosition((Console.WindowWidth - rdy.Length) / 2, Console.CursorTop);
            Console.WriteLine(rdy);
            string jatekValasz = Console.ReadLine();
            if (jatekValasz.ToLower()=="igen")
            {
                Console.Clear();
                jegyNyitasJatek(jegy, jegyMennyiseg);
            }else if (jatekValasz.ToLower() == "nem")
            {
                goto FőMenu;
            }
            else
            {
                Console.Clear();
                goto Jatek;
            }
            Console.WriteLine($"Ennyit nyertél a legutóbbi nyitás eredménye: {nyitasomOsszesenEddig}");
            Console.WriteLine("-------------------adasodhsadiooasudgasdaso");
            Console.ReadKey();
            goto Jatek;
            ///-------Főmenü vége
            
            



            Console.WriteLine();


            Console.WriteLine("-----------");
            Console.ReadKey();
            Console.Clear();
            goto FőMenu;
           
        }

        public static void jegyNyitasJatek(int Ticket,int TicketMennyiseg)
        {
            if (Ticket == 1)
            {
                int nyeremeny = 600;
                int nyitasomAra = 300;
                nyitasomOsszesenEddig = 0;
                for (int i = 0; i < TicketMennyiseg; i++)
                {
                    var db = $"{i}. kaparás";
                    Console.SetCursorPosition((Console.WindowWidth - db.Length) / 2, Console.CursorTop);
                    Console.WriteLine(db);
                    Console.WriteLine();
                    Console.WriteLine(@"
                                                ██████████
                                                ██▒▒▒▒▒▒██
                                                ██▒░░░░▒██
                                                ██▒░▓▓░▒██
                                                ██▒░▓▓░▒██
                                                ██▒░░░░▒██
                                                ██▒▒▒▒▒▒██
                                                ██▒▒░▒▒▒██
                                                ██████████
                                                    
");
                    int szamom = rnd.Next(1, 31);
                    if (szamom<16)
                    {
                        var sikeresKaparas = $"Gratulálok nyertél: ";
                        Console.SetCursorPosition((Console.WindowWidth - sikeresKaparas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikeresKaparas + nyeremeny+"ft");
                        egyenlegem += 600;
                        nyitasomOsszesenEddig += 600;
                        Console.ReadKey();

                    }
                    else
                    {
                        var sikertelenNyitas = $"Sajnálom most nem nyertél: -";
                        Console.SetCursorPosition((Console.WindowWidth - sikertelenNyitas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikertelenNyitas + nyitasomAra+"ft");
                        egyenlegem -= 300;
                        nyitasomOsszesenEddig -= 300;
                        Console.ReadKey();
                    }
                }

            }
            if (Ticket == 2)
            {
                
            }
            if (Ticket == 3)
            {
                
            }
            if (Ticket == 4)
            {
                
            }

        }

        public static double porgetesMennyi(int szam)
        {
            double mennyi = 0;
            if(szam == 1)
            {
                mennyi =egyenlegem % 200;

            }
            if (szam == 2)
            {
                mennyi = egyenlegem % 500;
            }
            if (szam == 3)
            {
                mennyi = egyenlegem % 800;
            }
            if (szam == 4)
            {
                mennyi = egyenlegem % 1000;
            }
            mennyi = Math.Round(mennyi);
            
            return mennyi;
        }
    }
}
