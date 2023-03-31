using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predi_Test
{
    //clasovete sa slojni tipove
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Vladun";
            p1.Age = 16;

            Person p2 = new Person();
            p2.Name = "Viktorel";
            p2.Age = 30;

            Person p3 = new Person();
            p3.Name = "Vlaiko";
            p3.Age = 10;

            p1.RecordMyEGN("P235JkLMS&+");
            p1.PrintMyEGN();

            Person[] people = {p1, p2, p3 };
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age < 18)
                {
                    people[i].AgeUp();
                }
            }
        }
    }
    public class Person
    {
        //sustoqnie (danni kakvo ima kato informaciq)
        private string EGN = "";
        public string Name { get; set; }
        public int Age { get; set; } = 10;
        //povedenie (metodi pravqt deistvia)
        public void AgeUp()
        {
            Age++;
            Console.WriteLine($"{Name} aged up and is now {Age} years old");
        }
        public void PrintMyEGN()
        {
            Console.WriteLine("****" + EGN.Substring(3,4));
        }
        public void RecordMyEGN(string egn)
        {
            EGN = egn;
        }
    }
}
