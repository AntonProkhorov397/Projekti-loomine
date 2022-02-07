using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti_loomine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double hind = 10;
            hind = 10;
            string pileti_tuup="";
            Console.WriteLine("Mis on sinu nimi on?");
            string eesnimi = Console.ReadLine();
            Console.Write("Tere tulemast! {0}",eesnimi);
            if (eesnimi.ToLower() == "nikolai")
            {
                Console.WriteLine(",Tule külla! Lähme kinno!!!!!!!!!!!!!");
                string vastus = Console.ReadLine();
                if (vastus.ToLower()=="jah" || vastus.ToUpper()=="yes")
                {

                }
                else
                {
                    Console.WriteLine("Kui vana sa oled?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus < 0 || vanus > 108)
                    {
                        Console.WriteLine("Viga!");
                        pileti_tuup = "viga andmetega";
                    }
                    if (vanus < 6 || vanus>=65)
                    {
                        hind -= hind * 1;
                        pileti_tuup="See on tasuta pilet";
                    }
                    else if (vanus>=6 && vanus<12)
                    {
                        hind -= hind * 0.3;
                        pileti_tuup="See laste pilet";
                    }
                    else if (vanus>=12 && vanus<18)
                    {
                        hind -= hind * 0.1;
                        pileti_tuup="See on täis pilet";
                    }
            
                    char[] tahed = eesnimi.ToCharArray();
                    int i = 0;
                    eesnimi = "";
                    foreach (var t in tahed)
                    {
                        if (i==0)
                        {
                            eesnimi += t.ToString().ToLower();
                        }
                        else
                        {
                            eesnimi += t.ToString().ToLower();
                        }
                        i += 1;
                    }
                    Console.WriteLine("{0}, sul vaja maksta {1}",eesnimi.ToUpper(), pileti_tuup,hind);
                }

            }
            else
            {
                Console.WriteLine("Mind täna kodus pole! :(");
            }
            Console.ReadKey();

            string pinginaabrid = "((Artjom.R && Timofei)||(German && Kevin)||(Denis && Artjom.V)||(Anton && Lox))";
            Console.WriteLine("Kes on sinu pinginaaber?");
            string vastus = Console.ReadLine();
           
        }
    }
}
