using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica
{
    public abstract class Gradivo
    {
        public string Naslov {get; set;}
        public int LetoIzdaje {get; set;}

        protected Gradivo(string naslov, int letoIzdaje)
        {
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
        }

        public override string ToString()
        {
            return $"{Naslov} ({LetoIzdaje})";
        }
    }

    public class Knjiga : Gradivo
    {
        public string Avtor {get; set;}

        public Knjiga(string naslov, string avtor, int letoIzdaje)
            : base(naslov, letoIzdaje)
        {
            Avtor = avtor;
        }

        public override string ToString()
        {
            return $"{Naslov} – {Avtor} ({LetoIzdaje})";
        }
    }

    public class DVD : Gradivo
    {
        public int Trajanje {get; set;}

        public DVD(string naslov, int letoIzdaje, int trajanje)
            : base(naslov, letoIzdaje)
        {
            Trajanje = trajanje;
        }

        public override string ToString()
        {
            return $"{Naslov} ({LetoIzdaje}) – DVD, {Trajanje} min";
        }
    }

    public class Član
    {
        public const int NajvečIzposoj = 5;

        private static int skupnoČlanov = 0;
        public static int SkupnoČlanov => skupnoČlanov;

        public readonly int ČlanId;
        public string Ime {get; set;}
        public decimal Zamudnina {get; set;}

        public Član(string ime)
        {
            Ime = ime;
            Zamudnina = 0m;
            ČlanId = ++skupnoČlanov;
        }

        public static int VrniŠteviloČlanov()
        {
            return skupnoČlanov;
        }

        public override string ToString()
        {
            return $"{Ime} (ID: {ČlanId}, Zamudnina: {Zamudnina:0.00} €)";
        }
    }

    public class IzposojenoGradivo
    {
        public Gradivo Gradivo {get; set;}
        public DateTime DatumIzposoje {get; set;}
        public Član Izposojevalec {get; set;}

        public IzposojenoGradivo(Gradivo gradivo, Član član)
        {
            Gradivo = gradivo;
            Izposojevalec = član;
            DatumIzposoje = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Gradivo} – izposojeno: {Izposojevalec.Ime}";
        }

        static List<Član> člani = new List<Član>();
        static List<Gradivo> gradiva = new List<Gradivo>();
        static List<IzposojenoGradivo> izposoje = new List<IzposojenoGradivo>();

        internal class knjižnica
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("KNJIŽNIČNI SISTEM");
                    Console.WriteLine("1. Dodaj člana");
                    Console.WriteLine("2. Dodaj knjigo");
                    Console.WriteLine("3. Dodaj DVD");
                    Console.WriteLine("4. Prikaži gradiva");
                    Console.WriteLine("5. Prikaži člane");
                    Console.WriteLine("6. Izposodi gradivo");
                    Console.WriteLine("0. Izhod");
                    Console.Write("\nIzbira: ");

                    switch (Console.ReadLine())
                    {
                        case "1": DodajČlana(); break;
                        case "2": DodajKnjigo(); break;
                        case "3": DodajDVD(); break;
                        case "4": PrikažiGradiva(); break;
                        case "5": PrikažiČlane(); break;
                        case "6": IzposodiGradivo(); break;
                        case "0": return;
                        default:
                            Console.WriteLine("Napačna izbira.");
                            Console.ReadKey();
                            break;
                    }
                }
            }

            static void DodajČlana()
            {
                Console.Write("Ime člana: ");
                string ime = Console.ReadLine();
                člani.Add(new Član(ime));
                Console.WriteLine("Član dodan.");
                Console.ReadKey();
            }

            static void DodajKnjigo()
            {
                Console.Write("Naslov: ");
                string naslov = Console.ReadLine();
                Console.Write("Avtor: ");
                string avtor = Console.ReadLine();
                Console.Write("Leto izdaje: ");
                int leto = int.Parse(Console.ReadLine());

                gradiva.Add(new Knjiga(naslov, avtor, leto));
                Console.WriteLine("Knjiga dodana.");
                Console.ReadKey();
            }

            static void DodajDVD()
            {
                Console.Write("Naslov: ");
                string naslov = Console.ReadLine();
                Console.Write("Leto izdaje: ");
                int leto = int.Parse(Console.ReadLine());
                Console.Write("Trajanje (min): ");
                int trajanje = int.Parse(Console.ReadLine());

                gradiva.Add(new DVD(naslov, leto, trajanje));
                Console.WriteLine("DVD dodan.");
                Console.ReadKey();
            }

            static void PrikažiGradiva()
            {
                Console.WriteLine("\nGradiva");
                for (int i = 0; i < gradiva.Count; i++)
                {
                    Console.WriteLine($"{i}: {gradiva[i]}");
                }
                Console.ReadKey();
            }

            static void PrikažiČlane()
            {
                Console.WriteLine("\nČlani");
                for (int i = 0; i < člani.Count; i++)
                {
                    Console.WriteLine($"{i}: {člani[i]}");
                }
                Console.ReadKey();
            }

            static void IzposodiGradivo()
            {
                if (člani.Count == 0 || gradiva.Count == 0)
                {
                    Console.WriteLine("Ni članov ali gradiv.");
                    Console.ReadKey();
                    return;
                }

                PrikažiČlane();
                Console.Write("Izberi člana: ");
                int c = int.Parse(Console.ReadLine());

                PrikažiGradiva();
                Console.Write("Izberi gradivo: ");
                int g = int.Parse(Console.ReadLine());

                izposoje.Add(new IzposojenoGradivo(gradiva[g], člani[c]));
                Console.WriteLine("Gradivo izposojeno.");
                Console.ReadKey();
            }
        }
    }
}
