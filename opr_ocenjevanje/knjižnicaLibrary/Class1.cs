namespace knjižnicaLibrary
{
    public abstract class Gradivo
    {
        public string Naslov { get; set; }
        public int LetoIzdaje { get; set; }

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

    public interface IIzposodljivo
    {
        void Izposodi(Član član);
        void Vrni();
        bool JeIzposojeno { get; }
    }

    public delegate void IzposojaHandler(string msg);

    public abstract class IzposodljivoGradivo : Gradivo, IIzposodljivo
    {
        public bool JeIzposojeno { get; private set; }

        public event IzposojaHandler ObIzposoji;

        protected IzposodljivoGradivo(string naslov, int leto) : base(naslov, leto)
        {
            JeIzposojeno = false;
        }

        public virtual void Izposodi(Član član)
        {
            JeIzposojeno = true;
            ObIzposoji?.Invoke($"Gradivo '{Naslov}' je bilo izposojeno.");
        }

        public virtual void Vrni()
        {
            JeIzposojeno = false;
        }
    }

    public class Knjiga : IzposodljivoGradivo
    {
        public string Avtor { get; set; }

        public Knjiga(string naslov, string avtor, int letoIzdaje) : base(naslov, letoIzdaje)
        {
            Avtor = avtor;
        }

        public override void Izposodi(Član član)
        {
            base.Izposodi(član);
            Console.WriteLine($"Knjiga '{Naslov}' izposojena članu {član.Ime}");
            član += 1.5m;
        }

        public override string ToString()
        {
            return $"{Naslov} – {Avtor} ({LetoIzdaje})";
        }
    }

    public class DVD : IzposodljivoGradivo
    {
        public int Trajanje { get; set; }

        public DVD(string naslov, int letoIzdaje, int trajanje) : base(naslov, letoIzdaje)
        {
            Trajanje = trajanje;
        }

        public override void Izposodi(Član član)
        {
            base.Izposodi(član);
            Console.WriteLine($"DVD '{Naslov}' izposojen članu {član.Ime}");
            član += 2.0m;
        }

        public override string ToString()
        {
            return $"{Naslov} ({LetoIzdaje}) – DVD, {Trajanje} min";
        }
    }

    public class Revija : IzposodljivoGradivo
    {
        public int Številka { get; set; }

        public Revija(string naslov, int leto, int številka) : base(naslov, leto)
        {
            Številka = številka;
        }

        public override void Izposodi(Član član)
        {
            base.Izposodi(član);
            Console.WriteLine($"Revija '{Naslov}' izposojena.");
            član += 0.5m;
        }

        public override string ToString()
        {
            return $"{Naslov} ({LetoIzdaje}) – Revija št. {Številka}";
        }
    }

    public class Članek : IzposodljivoGradivo
    {
        public string Tema { get; set; }

        public Članek(string naslov, int leto, string tema) : base(naslov, leto)
        {
            Tema = tema;
        }

        public override void Izposodi(Član član)
        {
            base.Izposodi(član);
            Console.WriteLine($"Članek '{Naslov}' izposojen.");
            član += 0.2m;
        }

        public override string ToString()
        {
            return $"{Naslov} ({LetoIzdaje}) – Tema: {Tema}";
        }
    }

    public class Član
    {
        public const int NajvečIzposoj = 5;

        private static int skupnoČlanov = 0;
        public static int SkupnoČlanov => skupnoČlanov;

        public readonly int ČlanId;
        public string Ime { get; set; }
        public decimal Zamudnina { get; set; }

        public Član(string ime)
        {
            Ime = ime;
            Zamudnina = 0m;
            ČlanId = ++skupnoČlanov;
        }

        public static Član operator +(Član c, decimal znesek)
        {
            c.Zamudnina += znesek;
            return c;
        }

        public static Član operator -(Član c, decimal znesek)
        {
            c.Zamudnina -= znesek;
            if (c.Zamudnina < 0) c.Zamudnina = 0;
            return c;
        }

        public override string ToString()
        {
            return $"{Ime} (ID: {ČlanId}, Zamudnina: {Zamudnina:0.00} €)";
        }

        ~Član()
        {
            Console.WriteLine($"Član {Ime} (ID: {ČlanId}) je odstranjen iz sistema.");
        }

        public static bool operator ==(Član a, Član b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.ČlanId == b.ČlanId;
        }

        public static bool operator !=(Član a, Član b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Član other)
                return this == other;

            return false;
        }

        public override int GetHashCode()
        {
            return ČlanId.GetHashCode();
        }
    }

    public class IzposojenoGradivo
    {
        public Gradivo Gradivo { get; set; }
        public DateTime DatumIzposoje { get; set; }
        public Član Izposojevalec { get; set; }

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
    }

    public class KnjižnicaSistem
    {
        private List<Gradivo> seznam = new List<Gradivo>();

        public void Dodaj(Gradivo g)
        {
            seznam.Add(g);
        }

        public Gradivo this[int index]
        {
            get { return seznam[index]; }
            set { seznam[index] = value; }
        }

        public int Število => seznam.Count;
    }

    internal class knjižnica
    {
        static KnjižnicaSistem sistem = new KnjižnicaSistem();
        static List<Član> člani = new List<Član>();
        static List<IzposojenoGradivo> izposoje = new List<IzposojenoGradivo>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("KNJIŽNIČNI SISTEM");
                Console.WriteLine("1. Dodaj člana");
                Console.WriteLine("2. Dodaj knjigo");
                Console.WriteLine("3. Dodaj DVD");
                Console.WriteLine("4. Dodaj revijo");
                Console.WriteLine("5. Dodaj članek");
                Console.WriteLine("6. Prikaži gradiva");
                Console.WriteLine("7. Prikaži člane");
                Console.WriteLine("8. Izposodi gradivo");
                Console.WriteLine("0. Izhod");
                Console.Write("\nIzbira: ");

                switch (Console.ReadLine())
                {
                    case "1": DodajČlana(); break;
                    case "2": DodajKnjigo(); break;
                    case "3": DodajDVD(); break;
                    case "4": DodajRevijo(); break;
                    case "5": DodajČlanek(); break;
                    case "6": PrikažiGradiva(); break;
                    case "7": PrikažiČlane(); break;
                    case "8": IzposodiGradivo(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Napačna izbira.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void IzpisDogodka(string msg)
        {
            Console.WriteLine("DOGODEK: " + msg);
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

            sistem.Dodaj(new Knjiga(naslov, avtor, leto));
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

            sistem.Dodaj(new DVD(naslov, leto, trajanje));
            Console.WriteLine("DVD dodan.");
            Console.ReadKey();
        }

        static void DodajRevijo()
        {
            Console.Write("Naslov: ");
            string naslov = Console.ReadLine();
            Console.Write("Leto: ");
            int leto = int.Parse(Console.ReadLine());
            Console.Write("Številka: ");
            int št = int.Parse(Console.ReadLine());

            sistem.Dodaj(new Revija(naslov, leto, št));
            Console.WriteLine("Revija dodana.");
            Console.ReadKey();
        }

        static void DodajČlanek()
        {
            Console.Write("Naslov: ");
            string naslov = Console.ReadLine();
            Console.Write("Leto: ");
            int leto = int.Parse(Console.ReadLine());
            Console.Write("Tema: ");
            string tema = Console.ReadLine();

            sistem.Dodaj(new Članek(naslov, leto, tema));
            Console.WriteLine("Članek dodan.");
            Console.ReadKey();
        }

        static void PrikažiGradiva()
        {
            Console.WriteLine("\nGradiva:");
            for (int i = 0; i < sistem.Število; i++)
            {
                Console.WriteLine($"{i}: {sistem[i]}");
            }
            Console.ReadKey();
        }

        static void PrikažiČlane()
        {
            Console.WriteLine("\nČlani:");
            for (int i = 0; i < člani.Count; i++)
            {
                Console.WriteLine($"{i}: {člani[i]}");
            }
            Console.ReadKey();
        }

        static void IzposodiGradivo()
        {
            if (člani.Count == 0 || sistem.Število == 0)
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

            if (sistem[g] is IzposodljivoGradivo ig)
            {
                ig.ObIzposoji += IzpisDogodka;
            }

            if (sistem[g] is IIzposodljivo izposodljivo)
            {
                izposodljivo.Izposodi(člani[c]);
                izposoje.Add(new IzposojenoGradivo(sistem[g], člani[c]));
            }

            Console.WriteLine("Gradivo izposojeno.");
            Console.ReadKey();
        }
    }
}
