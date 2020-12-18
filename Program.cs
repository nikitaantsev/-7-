using System;

namespace лаб_7
{
    class Kvadrat
    {
        protected int storona;

        public Kvadrat()
        {
            storona = 0;
        }

        public Kvadrat(int st)
        {
            storona = st;
        }

        public int Storona
        {
            get { return storona; }
            set { storona = value; }
        }

        public virtual string Info()
        {
            return string.Format("Kvadrat");
        }

        public virtual int Area()
        {
            return storona * storona;
        }

        public virtual int Perimeter()
        {
            return 4 * storona;
        }

        public virtual double Diagonal()
        {
            return Math.Sqrt(2 * storona * storona);
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            int storona;
            Console.WriteLine("Введите длину стороны :");
            storona = Convert.ToInt32(Console.ReadLine());
            Kvadrat kv1 = new Kvadrat(storona);

            Console.WriteLine(kv1.Info());
            Console.WriteLine("Area {0}", kv1.Area());
            Console.WriteLine("Volume {0}", kv1.Perimeter());
            Console.WriteLine("Diagonal {0}", kv1.Diagonal());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
