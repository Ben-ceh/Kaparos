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
        static int[] jegyekArai = {300, 500, 800, 1000};
        static bool segelyElerhetoE = true;


        static int jegyMennyiseg = 0;
        static int jegy = 0;
        static void Main(string[] args)
        {



        FőMenu: //Főmenü kezdete
            Console.Clear();
            Console.WriteLine();
            Console.ReadKey();
            
            

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
            var vonal = $"---------------------------------------------------------";
            Console.SetCursorPosition((Console.WindowWidth - vonal.Length) / 2, Console.CursorTop);
            Console.WriteLine(vonal);
            string szerencsejatek = @"Szerencse játék";
            Console.SetCursorPosition((Console.WindowWidth - szerencsejatek.Length) / 2, Console.CursorTop);
            Console.WriteLine(szerencsejatek);
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            string enter = @"ENTER";
            Console.SetCursorPosition((Console.WindowWidth - enter.Length) / 2, Console.CursorTop);
            Console.WriteLine(enter);
          
            Console.ReadKey();
            Console.Clear();

            goto Szerencsejáték;


        Szerencsejáték:
            Console.Clear();
            if (egyenlegem < 301 && segelyElerhetoE == false)
            {
                var vonal4 = $"---------------------------------------------------------";
                Console.SetCursorPosition((Console.WindowWidth - vonal4.Length) / 2, Console.CursorTop);
                Console.WriteLine(vonal4);
                var segelySzoveg4 = $"Az egyenlegedről az összeg elfogyott megint. A játékot pénz nélkül nem folytathatod. :(";
                Console.SetCursorPosition((Console.WindowWidth - segelySzoveg4.Length) / 2, Console.CursorTop);
                Console.WriteLine(segelySzoveg4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (egyenlegem < 301 && segelyElerhetoE == true)
            {
                var vonal4 = $"---------------------------------------------------------";
                Console.SetCursorPosition((Console.WindowWidth - vonal4.Length) / 2, Console.CursorTop);
                Console.WriteLine(vonal4);

                var segelySzoveg = $"Sajnos nincs több fedezett az egyenlegeden, hogy tudd folytatni ezt a játékot!";
                Console.SetCursorPosition((Console.WindowWidth - segelySzoveg.Length) / 2, Console.CursorTop);
                Console.WriteLine(segelySzoveg);
                Console.WriteLine();
                var segelySzoveg2 = $"Felajánlunk egy egyszeri alkalmat. El szeretnéd adni a házadat 5000ft-ért? (igen/nem)";
                Console.SetCursorPosition((Console.WindowWidth - segelySzoveg2.Length) / 2, Console.CursorTop);
                Console.WriteLine(segelySzoveg2);
                string valasz3 = Console.ReadLine();
                if (valasz3.ToLower() == "igen")
                {
                    var segelySzoveg3 = $"Rendben, az egyenleged sikeresen feltölve. További sok szerencsét!";
                    Console.SetCursorPosition((Console.WindowWidth - segelySzoveg3.Length) / 2, Console.CursorTop);
                    Console.WriteLine(segelySzoveg3);
                    segelyElerhetoE = false;
                    egyenlegem += 5000;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    var segelySzoveg4 = $"A játékot pénz nélkül nem folytathatod. :(";
                    Console.SetCursorPosition((Console.WindowWidth - segelySzoveg4.Length) / 2, Console.CursorTop);
                    Console.WriteLine(segelySzoveg4);
                    Console.ReadKey();
                    Environment.Exit(0);
                    Console.Clear();

                }


            }
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
            
            string s = $"Egyenlegem: {egyenlegem}ft. ";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            var vonal1 = $"---------------------------------------------------------";
            Console.SetCursorPosition((Console.WindowWidth - vonal.Length) / 2, Console.CursorTop);
            Console.WriteLine(vonal1);
            Console.WriteLine();
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
            

            var vonal3 = $"---------------------------------------------------------";
            Console.SetCursorPosition((Console.WindowWidth - vonal.Length) / 2, Console.CursorTop);
            Console.WriteLine(vonal3);
            


            string jegyValasztas = @"Kérlek válasz egy tetszőleges kaparós sorsjegyet!";
            Console.SetCursorPosition((Console.WindowWidth - jegyValasztas.Length) / 2, Console.CursorTop);
            Console.WriteLine(jegyValasztas);
            try
            {
                int jegyeimOsszesen = int.Parse(Console.ReadLine()); //Melyik jegy 1.
                if (jegyeimOsszesen>4||jegyeimOsszesen<=0)
                {
                    string sikertelenKarakter = $"Nincs ilyen jegy, próbáld meg újra!(1-4)";
                    Console.SetCursorPosition((Console.WindowWidth - sikertelenKarakter.Length) / 2, Console.CursorTop);
                    Console.WriteLine(sikertelenKarakter);
                    Console.ReadKey();
                    Console.Clear();
                    goto Szerencsejáték;
                    
                }
                
                jegy = jegyeimOsszesen;
            }
            catch (Exception)
            {
                string sikertelenKarakter = $"Nem elfogadott karaktert adtál meg, próbáld meg újra!";
                Console.SetCursorPosition((Console.WindowWidth - sikertelenKarakter.Length) / 2, Console.CursorTop);
                Console.WriteLine(sikertelenKarakter);
                Console.ReadKey();
                Console.Clear();
                goto Szerencsejáték;
            }
                
            
                

                string mennyiseg = $"Mennyit szertnél nyitni (Jelenleg ennyit tudsz kaparni ebből a jegyből: {egyenlegem / jegyekArai[jegy - 1]} ?";
                Console.SetCursorPosition((Console.WindowWidth - mennyiseg.Length) / 2, Console.CursorTop);
                Console.WriteLine(mennyiseg);

            // int jegyLehetsegesNyitas = (int)Convert.ToUInt32(porgetesMennyi(jegy)); //jegyLehetsegesNyitas 3.
            try
            {
                int jegyMennyisegeim = int.Parse(Console.ReadLine()); //Mennyiség 2.
                jegyMennyiseg = jegyMennyisegeim;
            }
            catch (Exception)
            {
                string sikertelenKarakter = $"Nem elfogadott karaktert adtál meg, próbáld meg újra!";
                Console.SetCursorPosition((Console.WindowWidth - sikertelenKarakter.Length) / 2, Console.CursorTop);
                Console.WriteLine(sikertelenKarakter);
                Console.ReadKey();
                Console.Clear();
                goto Szerencsejáték;
            }
            
                if (jegyMennyiseg > egyenlegem / jegyekArai[jegy - 1]||jegyMennyiseg<0||egyenlegem<=0)
                {

                    string jegyMennyisegEll = $"Sajnos ennyi jegyre nincs elég pénzed, próbáld meg újra!";
                    Console.SetCursorPosition((Console.WindowWidth - jegyMennyisegEll.Length) / 2, Console.CursorTop);
                    Console.WriteLine(jegyMennyisegEll);
                    Console.ReadKey();
                    Console.Clear();
                    goto Szerencsejáték;

                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    goto Jatek;
                }
            
            
        Jatek: //_______________________________________ Játék
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            var jatekInformacio = $"{jegy}. számú jegyből fogsz nyitni {jegyMennyiseg}db-ot.";
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
                var nem = $"Rendben, most vissza kerülsz a menübe.";
                Console.SetCursorPosition((Console.WindowWidth - nem.Length) / 2, Console.CursorTop);
                Console.WriteLine(nem);
                Console.ReadKey();
                Console.Clear();
                goto FőMenu;
            }
            else
            {
                Console.Clear();
                goto Jatek;
            }

            var vonal2 = $"---------------------------------------------------------";
            Console.SetCursorPosition((Console.WindowWidth - vonal.Length) / 2, Console.CursorTop);
            Console.WriteLine(vonal2);
            var legutobbiNyeremeny = $"Legutóbbi nyitás profitja: {nyitasomOsszesenEddig}";
            Console.SetCursorPosition((Console.WindowWidth - legutobbiNyeremeny.Length) / 2, Console.CursorTop);
            Console.WriteLine(legutobbiNyeremeny);
            Console.ReadKey();

            Console.Clear();
            goto Szerencsejáték;
            

        }

        public static void jegyNyitasJatek(int Ticket,int TicketMennyiseg)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
            if (Ticket == 1)
            {
                int nyeremeny = 600;
                int nyitasomAra = 300;
                nyitasomOsszesenEddig = 0;
                for (int i = 0; i < TicketMennyiseg; i++)
                {
                    egyenlegem -= 300;
                    var db = $"{i+1}. kaparás";
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
                    int szamom = rnd.Next(1, 11);
                    if (szamom < 6)
                    {
                        var sikeresKaparas = $"Gratulálok nyertél: {nyeremeny}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikeresKaparas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikeresKaparas);
                        egyenlegem += 600;
                        nyitasomOsszesenEddig += 600;
                        Console.ReadKey();

                    }
                    else
                    {
                        var sikertelenNyitas = $"Sajnálom most nem nyertél: -{nyitasomAra}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikertelenNyitas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikertelenNyitas);
                        
                        nyitasomOsszesenEddig -= 300;
                        Console.ReadKey();
                    }
                }

            }
            if (Ticket == 2)
            {
                int nyeremeny = 1000;
                int nyitasomAra = 500;
                nyitasomOsszesenEddig = 0;
                for (int i = 0; i < TicketMennyiseg; i++)
                {
                    egyenlegem -= 500;
                    var db = $"{i + 1}. kaparás";
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
                    int szamom = rnd.Next(1, 11);
                    if (szamom < 6)
                    {
                        var sikeresKaparas = $"Gratulálok nyertél: {nyeremeny}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikeresKaparas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikeresKaparas);
                        egyenlegem += 1000;
                        nyitasomOsszesenEddig += 1000;
                        Console.ReadKey();

                    }
                    else
                    {
                        var sikertelenNyitas = $"Sajnálom most nem nyertél: -{nyitasomAra}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikertelenNyitas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikertelenNyitas);
                        
                        nyitasomOsszesenEddig -= 500;
                        Console.ReadKey();
                    }
                }
            }
            if (Ticket == 3)
            {
                int nyeremeny = 1600;
                int nyitasomAra = 800;
                nyitasomOsszesenEddig = 0;
                for (int i = 0; i < TicketMennyiseg; i++)
                {
                    egyenlegem -= 800;
                    var db = $"{i + 1}. kaparás";
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
                    int szamom = rnd.Next(1, 11);
                    if (szamom < 6)
                    {
                        var sikeresKaparas = $"Gratulálok nyertél: {nyeremeny}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikeresKaparas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikeresKaparas);
                        egyenlegem += 1600;
                        nyitasomOsszesenEddig += 1600;
                        Console.ReadKey();

                    }
                    else
                    {
                        var sikertelenNyitas = $"Sajnálom most nem nyertél: -{nyitasomAra}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikertelenNyitas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikertelenNyitas);
                        
                        nyitasomOsszesenEddig -= 800;
                        Console.ReadKey();
                    }
                }
            }
            if (Ticket == 4)
            {
                int nyeremeny = 2000;
                int nyitasomAra = 1000;
                nyitasomOsszesenEddig = 0;
                for (int i = 0; i < TicketMennyiseg; i++)
                {
                    egyenlegem -= 1000;
                    var db = $"{i + 1}. kaparás";
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
                    int szamom = rnd.Next(1, 11);
                    if (szamom < 6)
                    {
                        var sikeresKaparas = $"Gratulálok nyertél: {nyeremeny}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikeresKaparas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikeresKaparas);
                        egyenlegem += 2000;
                        nyitasomOsszesenEddig += 2000;
                        Console.ReadKey();

                    }
                    else
                    {
                        var sikertelenNyitas = $"Sajnálom most nem nyertél: -{nyitasomAra}ft.";
                        Console.SetCursorPosition((Console.WindowWidth - sikertelenNyitas.Length) / 2, Console.CursorTop);
                        Console.WriteLine(sikertelenNyitas);
                        
                        nyitasomOsszesenEddig -= 1000;
                        Console.ReadKey();
                    }
                }
            }
            
        }

       
    }
}
