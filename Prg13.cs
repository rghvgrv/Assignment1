using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Patient
    {
        static int PatientNo = 1000;
        public Patient()
        {
            PatientID = ++PatientNo;
        }

        public Patient(int id)
        {
            PatientID = id;
        }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public double PhNo { get; set; }
        public double BillAmount { get; set; }
        public override string ToString()
        {
            return $"{PatientID}, {PatientName}, {PhNo}, {BillAmount}";
        }
    }
    class Prg13
	{
        const string fileName = "PatientDetails.txt";
        static void writeToFile(Patient pt)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(pt);
            writer.Close();
            fs.Close();
        }

        static Patient readFromFile()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string data = reader.ReadLine();
                string[] details = data.Split(',');
                Patient pt = new Patient(int.Parse(details[0]));
                pt.PatientName = details[1];
                pt.PhNo = int.Parse(details[2]);
                pt.BillAmount = int.Parse(details[3]);
                fs.Close();
                return pt;
            }
            throw new Exception("File does not exist");
        }
        static void Main(string[] args)
		{
            writeToFile(new Patient { PatientName = "Gaurav", PhNo = 123456789, BillAmount = 67000 });
            Console.WriteLine(readFromFile());
            
        }
    }
}
