using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;


namespace ConsoleApp1
{
    public class AddressBookRecords 
    { 
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Program
    {
        

        static void Main(string[] args)
        {
            var list = new List<AddressBookRecords>()
            {
                new AddressBookRecords{ID = 1,Name = "Nutan"},
                new AddressBookRecords{ID = 2,Name = "Pooja"},
                new AddressBookRecords{ID = 3,Name = "Richa"}
            };
            
            using(var writer = new StreamWriter {@"" })
            {
                using (var helper = new CsvWriter { writer, Cultureinfo.Inv }) {
                    helper.WriteRecord<AddressBookRecords>();
                }
            }
        }
    }
}
