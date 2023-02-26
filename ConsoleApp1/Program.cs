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

            void WriteTest()
            {
                // Write sample data to CSV file
                using (CsvFileWriter writer = new CsvFileWriter("WriteTest.csv"))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        CsvRow row = new CsvRow();
                        for (int j = 0; j < 5; j++)
                            row.Add(String.Format("Column{0}", j));
                        writer.WriteRow(row);
                    }
                }
            }

            void ReadTest()
            {
                // Read sample data from CSV file
                using (CsvFileReader reader = new CsvFileReader("ReadTest.csv"))
                {
                    CsvRow row = new CsvRow();
                    while (reader.ReadRow(row))
                    {
                        foreach (string s in row)
                        {
                            Console.Write(s);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
            }
    }
}
