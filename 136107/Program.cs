using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136107
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bohater> postacie = new List<Bohater>();
            postacie.Add(new Bohater(10));
            postacie.Add(new Bohater(8));
            postacie.Add(new Elf(15, "fireball"));
            postacie.Add(new Elf(20, "frostlance"));
            postacie.Add(new Ork(40, 60));
            postacie.Add(new Ork(20, 50));
            postacie.Sort();
            postacie.Reverse();
            foreach (var item in postacie)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();


            
            DateTime thisDay = DateTime.Today;
            
           
            Console.WriteLine();

            Console.WriteLine(thisDay.ToString());
            
            Console.ReadKey();
            Console.WriteLine();

            int[] Student = { 136107, 136110, 136206 };
            int p = 0;
            foreach(int i in Student)
                if(i % 2 == 0)
                {
                    p++;
                }
            Console.WriteLine("Są " + p + " Parzyste Elementy" );
            
            Console.ReadKey();
            Console.WriteLine();

            SortedList<string, double> lista = new SortedList<string, double>();
            lista.Add("Papier", 2.2);
            lista.Add("Kamień", 4.5);
            lista.Add("Nożyce", 5.2212);
            lista.Add("Woda", 4.23213);
            foreach(var a in lista)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
    public class Bohater : IComparable
    {
        private int hp;

        public Bohater(int hp)
        {
            this.hp = hp;
        }

        public override string ToString()
        {
            return hp.ToString();
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Bohater otherBohater = obj as Bohater;
            if (otherBohater != null)
                return this.hp.CompareTo(otherBohater.hp);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public virtual void ZadajCios(int obrazenia)
        {
            if (obrazenia < 20)
            {
                Console.WriteLine("dobrze");
            }
            else
            {
                Console.WriteLine("źle");
            }
        }
    }
    public class Elf : Bohater
    {
        private string magia;

        public Elf(int hp, string magia)
            : base(hp)
        {
            this.magia = magia;
        }

        public override void ZadajCios(int obrazenia)
        {
            if (obrazenia > 10)
            {
                Console.WriteLine("dobrze");
            }
            else
            {
                Console.WriteLine("źle");
            }
        }
    }
    public class Ork : Bohater
    {
        private int walka;

        public Ork(int hp, int walka)
            : base(hp)
        {
            this.walka = walka;
        }

        public override void ZadajCios(int obrazenia)
        {
            if (obrazenia > 30)
            {
                Console.WriteLine("dobrze");
            }
            else
            {
                Console.WriteLine("źle");
            }
        }
    }
    public class Student
    {

        private int rok;
        private int numerGrupy;
        private int nrAlbumu;

        public Student(int rok, int numerGrupy, int nrAlbumu)
        
        {

            this.rok = rok; ;
            this.numerGrupy = numerGrupy;
            this.nrAlbumu = nrAlbumu;
            

        }
        public class Sklep:IOperacje
        {
            private string zamowienie;
            public Sklep(string zamowienie)
            {
                this.zamowienie = zamowienie;
            }
            

            public bool Przyjmij(string zamowienie)
            {
                throw new NotImplementedException();
            }

            

            public bool Wydaj(int zamowienie)
            {
                throw new NotImplementedException();
            }
        }
        interface IOperacje
        {
            bool Przyjmij(string zamowienie);
            bool Wydaj(int zamowienie);
        }
        

       
    }


}
