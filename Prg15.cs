using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Assignment1
{
    class Util
    {
        public static int GetNumber(string Question)
        {
            Console.WriteLine(Question);
            return int.Parse(Console.ReadLine());
        }
        public static double GetDouble(string Question)
        {
            Console.WriteLine(Question);
            return int.Parse(Console.ReadLine());
        }
        public static string GetString(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadLine();
        }
    }
    public class Prg15
    {
        [Serializable]
        public class Employee
        {
            static int empNo = 1000;
            public Employee()
            {
                EmpID = ++empNo;
            }

            public Employee(int id)
            {
                EmpID = id;
            }
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public string EmpAddress { get; set; }
            public int EmpSalary { get; set; }
            public override string ToString()
            {
                return $"{EmpID}, {EmpName}, {EmpAddress}, {EmpSalary}";
            }
        }
        static void saveAsXml(List<Employee> empList)
        {
            var fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(List<Employee>)); 
            formatter.Serialize(fs, empList);
            fs.Close();
        }
        static List<Employee> loadXmlData()
        {
            var fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            var formatter = new XmlSerializer(typeof(List<Employee>)); 
            var list = formatter.Deserialize(fs) as List<Employee>;
            fs.Close();
            return list;
        }
        static Employee createEmployee()
        {
            var id = Util.GetNumber("Enter the ID of the Employee");
            var name = Util.GetString("Enter the Name of the Employee");
            var address = Util.GetString("Enter the Address of the Employee");
            var salary = Util.GetNumber("Enter the Salary");
            var emp = new Employee(id)
            {
                EmpName = name,
                EmpAddress = address,
                EmpSalary = salary
            };

            return emp;
        }
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            var choice = Util.GetNumber("Enter the no of Employee that is added");
            for (int i = 0; i < choice; i++)
            {
                empList.Add(createEmployee());
            }
            saveAsXml(empList);
            empList = loadXmlData();
            foreach (var emp in empList) 
                Console.WriteLine($"The emp has ID {emp.EmpID} Name = {emp.EmpName} Address = {emp.EmpAddress} Salary = {emp.EmpSalary}");

        }
    }
}