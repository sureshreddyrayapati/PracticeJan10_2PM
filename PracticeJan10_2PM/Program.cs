 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace PracticeJan10_2PM
{
    [Serializable] 
    public class School
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Address { get; set; }
    }
    public class StudentInfo
    {
        public void Se_soap()
        {
            School se = new School();
            se.id = 2;
            se.name = "Pavani";
            se.Address = "Andra Pradesh";
            FileStream fs11 = new FileStream("C:\\Users\\dell\\source\\repos\\Serialization\\suresh1.txt", FileMode.Create, FileAccess.Write);
            SoapFormatter sp=new SoapFormatter();
            sp.Serialize(fs11, se);
        }
        public void de_soap()
        {
            School s4;
            SoapFormatter sp1=new SoapFormatter();
            FileStream fs11 = new FileStream("C:\\Users\\dell\\source\\repos\\Serialization\\suresh1.txt", FileMode.Open, FileAccess.Read);
            s4=(School)sp1.Deserialize(fs11);
            Console.WriteLine(s4.id);
            Console.WriteLine(s4.name);
            Console.WriteLine(s4.Address);
        }   
    }
    public class TestSchool
    {
        public void se_Deatils()
        {
            School s = new School();
            s.id= 1;
            s.name = "suresh";
            s.Address = "Hydrabad";
            FileStream f = new FileStream("C:\\Users\\dell\\source\\repos\\Serialization\\suresh.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(f,s);
            f.Close();
            bf = null;
        }
        public void de_Details()
        {
            School s;
            BinaryFormatter bf1=new BinaryFormatter();
            FileStream f1 = new FileStream("C:\\Users\\dell\\source\\repos\\Serialization\\suresh.txt", FileMode.Open, FileAccess.Read);
            s=(School)bf1.Deserialize(f1);
            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
            Console.WriteLine(s.Address);

        }
        public static void Main(string[] args)
        {
            TestSchool s1 = new TestSchool();
            // s1.se_Deatils();
            //s1.de_Details();
            StudentInfo studentInfo = new StudentInfo();
            //studentInfo.Se_soap();
            studentInfo.de_soap();
        }
    }
       
}
