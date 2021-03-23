using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.OrtalamaHesaplama.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç öğrenci kayı etmek istersiniz?");
            int mevcut = int.Parse(Console.ReadLine());
            string[,] ogrenciler = new string[mevcut + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf Notu";

            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    
                    int ortalama;
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Ad giriniz:");
                            Console.ReadLine();
                            break;
                        case 1:
                            Console.WriteLine("Soyad giriniz:");
                            Console.ReadLine();
                            break;
                        case 2:
                            
                            Console.WriteLine("Vize notunu giriniz:");
                            int vize = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            
                            Console.WriteLine("Final notunu giriniz:");
                            int final = Convert.ToInt32(Console.ReadLine());

                            break;

                            
                            ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
                            Console.WriteLine();
                            Console.WriteLine("Ortalamanız = {0}", ortalama);
                            Console.WriteLine();

                            if (ortalama > 89)
                            {
                                Console.WriteLine("Harf Notu: AA");
                            }
                            else if (ortalama > 79)
                            {
                                Console.WriteLine("Harf Notu: BA");
                            }
                            else if (ortalama > 69)
                            {
                                Console.WriteLine("Harf Notu: BB");
                            }
                            else if (ortalama > 50)
                            {
                                Console.WriteLine("Harf Notu: CB");
                            }
                            else if (ortalama > 40)
                            {
                                Console.WriteLine("Koşullu geçtiniz.");
                            }
                            else
                            {
                                Console.WriteLine("Helal olsun. Dersi geçtiniz.");
                            }

                    }

                }

            }

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Bir şeyi eksik yaptım ama bir türlü çözemedim.
        }
    }
}
