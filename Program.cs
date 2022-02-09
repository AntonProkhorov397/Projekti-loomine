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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti_loomine
{
    class Kordused_Massiivid
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//VENE KEEEEELEEEE KASUTAMINE!!!!!!!!!!!!!!
            int[] arvudd = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("Kirjuta viis arvu!!!!");
                    a = int.Parse(Console.ReadLine());
                    arvudd[k] = a;
                    k++;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
            } while (k<5);
            int summa = 0;
            int korr = 1;
            foreach(int arv in arvudd)
            {
                summa += arv;
                korr *= arv;
            }
            Console.WriteLine($"Summa={summa}");
            Console.WriteLine($" Korrutis={korr}");
            Console.WriteLine($" Keskmine= {summa / arvudd.Length,4}");






            Console.WriteLine();
            //Random rnd = new Random();
            //int N = rnd.Next(1, 100);
            //int M = rnd.Next(1, 100);
            //Console.WriteLine($"N={N}");
            //Console.WriteLine($"M={M}");
            //if (N > M)
            //{
            //    int abi = N;
            //    N = M;
            //    M = abi;
            //}
            //int[] N_M = new int[M-N+1];
            //int j = 0;
            //for (int i = N; i < M+1; i++)
            //{
            //    N_M[j]= i;
            //    j++;
            //}
            //foreach (int n_m in N_M)
            //{
            //    Console.Write($"{n_m^2,5}");
            //}

            //Console.ReadKey();




            //char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            //Console.WriteLine($"Esimene täht on {Tahed[0]}");

            //foreach (char taht in Tahed)
            //{
            //    Console.Write($"{taht,3}");

            //}
            //Console.WriteLine();
            //Random rnd = new Random();
            //int[] arvud = new int[10];
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(1, 100);
            //}

            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv,4}");
            //}
            //int[,] tabel = new int[10, 5];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"rida {i}: ");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"koht {j} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }

    }
}
