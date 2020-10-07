using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1,s2;
            s1 = new student();
            s2 = new student();

            s1.name = "alex";
            s2.name = "cristian";

            string ss = s1.getNameTwice();
        }
    }
}
