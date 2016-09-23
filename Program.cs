using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Developed on Sep 23 2016 Aravind Vadamalaimuthu
namespace RemReq
{
    class Program
    {
        static void Main(string[] args)
        {
            string Full = "Full.csv";
            string ToRemove = "ToRemove.csv";
            string Required = "Required.csv";

            var array1 = File.ReadAllLines(Full);
            var array2 = File.ReadAllLines(ToRemove);

            var noduplicates = Array.FindAll(array1, line => !Array.Exists(array2, line2 => line.StartsWith(line2)));

            //Writes all the non duplicates to a different file
            File.WriteAllLines(Required, noduplicates);
        }
    }
}
