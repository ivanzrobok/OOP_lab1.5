using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OOP.lab._1._5
{
    public class RightTriAngle
    {
        double CatetOne;
        double CatetTwo;
        public double FirstCount
        {
            get { return CatetOne; }
            set { if (value != 0) CatetOne = value; }
        }
        public double SecondCount
        {
            get { return CatetTwo; }
            set { if (value != 0) CatetTwo = value; }
        }
        public double Hipotenusa()
        {
            return Math.Sqrt(CatetOne * CatetOne + CatetTwo * CatetTwo);
        }
        public double Square()
        {//
            return (CatetTwo * CatetOne) / 2;
        }
        
        public void Read()
        {
            Console.WriteLine("Input first count: ");
            CatetOne = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Input second count: ");
            CatetTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Display();
        }
        public double Multiplay()
        {
            return CatetOne * CatetTwo;
        }
        public void Display()
        {
            Console.WriteLine(CatetOne.ToString() + " -First catet");
            Console.WriteLine(CatetTwo.ToString() + " -Second catet");
            Console.WriteLine("Multiplay - " + Multiplay());
            Console.WriteLine("Square - " + Square());
            Console.WriteLine("Hipotenusa - " + Hipotenusa());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            RightTriAngle rightTriAngle = new RightTriAngle();
            rightTriAngle.FirstCount = 3;
            rightTriAngle.SecondCount = 4;
            rightTriAngle.Display();
            rightTriAngle.Read();
        }
    }
}
