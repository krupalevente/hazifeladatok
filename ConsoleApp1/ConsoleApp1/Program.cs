using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi_09._16
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                {

                    HelloWorld();
                    Koszones();
                    Ketszeres();
                    KetSzamMuveletek();
                    Nagyobbik();
                    LegkisebbHarom();
                    HaromszogSzerkesztheto();
                    SzamtaniMertaniKozep();
                    MasodfokuVanEMegoldas();
                    MasodfokuMegoldasok();
                    DerekszoguAtfogo();
                    TeglatestFelszinTerfogat();
                    KorKeruletTerulet();
                    KorivTeruletIv();
                }
            }

            static void HelloWorld()
            {
                Console.WriteLine("Hello world!");
            }

            static void Koszones()
            {
                Console.Write("Add meg a neved: ");
                string nev = Console.ReadLine();
                Console.WriteLine($"Szia, {nev}!");
            }

            static void Ketszeres()
            {
                Console.Write("Adj meg egy számot: ");
                double szam = double.Parse(Console.ReadLine());
                Console.WriteLine($"A szám kétszerese: {szam * 2}");
            }

            static void KetSzamMuveletek()
            {
                Console.Write("Első szám: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Második szám: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"Különbség: {a - b}");
                Console.WriteLine($"Szorzat: {a * b}");
                if (b != 0)
                    Console.WriteLine($"Hányados: {a / b}");
                else
                    Console.WriteLine("Nullával nem lehet osztani!");
            }

            static void Nagyobbik()
            {
                Console.Write("Első egész szám: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Második egész szám: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"A nagyobbik: {(a > b ? a : b)}");
            }

            static void LegkisebbHarom()
            {
                Console.Write("Első szám: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Második szám: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Harmadik szám: ");
                int c = int.Parse(Console.ReadLine());

                int min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"A legkisebb: {min}");
            }

            static void HaromszogSzerkesztheto()
            {
                Console.Write("1. oldal: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("2. oldal: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("3. oldal: ");
                double c = double.Parse(Console.ReadLine());

                if (a + b > c && a + c > b && b + c > a)
                    Console.WriteLine("Szerkeszthető háromszög.");
                else
                    Console.WriteLine("Nem szerkeszthető háromszög.");
            }

            static void SzamtaniMertaniKozep()
            {
                Console.Write("Első pozitív szám: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Második pozitív szám: ");
                double b = double.Parse(Console.ReadLine());

                if (a > 0 && b > 0)
                {
                    double szamtani = (a + b) / 2;
                    double mertani = Math.Sqrt(a * b);
                    Console.WriteLine($"Számtani közép: {szamtani}, Mértani közép: {mertani}");
                }
                else
                    Console.WriteLine("Csak pozitív számokkal működik!");
            }

            static void MasodfokuVanEMegoldas()
            {
                Console.WriteLine("Másodfokú egyenlet: ax^2 + bx + c = 0");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());

                double D = b * b - 4 * a * c;
                if (D >= 0)
                    Console.WriteLine("Van megoldás.");
                else
                    Console.WriteLine("Nincs valós megoldás.");
            }

            static void MasodfokuMegoldasok()
            {
                Console.WriteLine("Másodfokú egyenlet: ax^2 + bx + c = 0");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());

                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"Két megoldás: x1 = {x1}, x2 = {x2}");
                }
                else if (D == 0)
                {
                    double x0 = -b / (2 * a);
                    Console.WriteLine($"Egy megoldás: x = {x0}");
                }
                else
                {
                    Console.WriteLine("Nincs valós megoldás.");
                }
            }

            static void DerekszoguAtfogo()
            {
                Console.Write("Első befogó: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Második befogó: ");
                double b = double.Parse(Console.ReadLine());

                double c = Math.Sqrt(a * a + b * b);
                Console.WriteLine($"Átfogó hossza: {c:F2}");
            }

            static void TeglatestFelszinTerfogat()
            {
                Console.Write("a él: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b él: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c él: ");
                double c = double.Parse(Console.ReadLine());

                double felszin = 2 * (a * b + a * c + b * c);
                double terfogat = a * b * c;
                Console.WriteLine($"Felszín: {felszin}, Térfogat: {terfogat}");
            }

            static void KorKeruletTerulet()
            {
                Console.Write("Kör átmérője: ");
                double d = double.Parse(Console.ReadLine());
                double r = d / 2;
                double kerulet = 2 * Math.PI * r;
                double terulet = Math.PI * r * r;
                Console.WriteLine($"Kerület: {kerulet}, Terület: {terulet}");
            }

            static void KorivTeruletIv()
            {
                Console.Write("Sugár: ");
                double r = double.Parse(Console.ReadLine());
                Console.Write("Középponti szög (fok): ");
                double alfa = double.Parse(Console.ReadLine());

                double ivHossz = 2 * Math.PI * r * (alfa / 360);
                double terulet = Math.PI * r * r * (alfa / 360);
                Console.WriteLine($"Körív hossza: {ivHossz}, Szelet területe: {terulet}");
            }
        }

    }
}

        static void DerekszoguAtfogo()
        {
            Console.Write("Első befogó: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második befogó: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Átfogó hossza: {c:F2}");
        }

        static void TeglatestFelszinTerfogat()
        {
            Console.Write("a él: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b él: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c él: ");
            double c = double.Parse(Console.ReadLine());

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;
            Console.WriteLine($"Felszín: {felszin}, Térfogat: {terfogat}");
        }

        static void KorKeruletTerulet()
        {
            Console.Write("Kör átmérője: ");
            double d = double.Parse(Console.ReadLine());
            double r = d / 2;
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;
            Console.WriteLine($"Kerület: {kerulet}, Terület: {terulet}");
        }

        static void KorivTeruletIv()
        {
            Console.Write("Sugár: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Középponti szög (fok): ");
            double alfa = double.Parse(Console.ReadLine());

            double ivHossz = 2 * Math.PI * r * (alfa / 360);
            double terulet = Math.PI * r * r * (alfa / 360);
            Console.WriteLine($"Körív hossza: {ivHossz}, Szelet területe: {terulet}");
        }
    }

}