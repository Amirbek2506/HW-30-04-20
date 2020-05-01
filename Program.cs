using System;


namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Matrix
    {
        Random rand;

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Colunm { get; set; }

        public bool NeedSecond { get; set; }

        public Matrix(int col, bool needSecond)
        {
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }

        char GetChar()
        {
            return litters.ToCharArray()[rand.Next(0, 35)];
        }


    }
}
