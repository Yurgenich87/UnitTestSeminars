using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2.HomeWork2
{
    public class Car : Vehicle
    {
        private string Company;
        private string Model;
        private int YearRelease;
        private int NumWheels;
        private int Speed;
        public Car(string company, string model, int year)
        {
            this.Company = company;
            this.Model = model; 
            this.YearRelease = year;
            this.NumWheels = 4;
            this.Speed = 0;
        }

        public override void TestDrive()
        {
            this.Speed = 60;
        }

        public override void Park()
        {
            this.Speed = 0;
        }

        public string GetCompany()
        {
            return Company;
        }

        public string GetModel()
        {
            return Model;
        }

        public int GetYearRelease()
        {
            return YearRelease;
        }

        public int GetNumWheels()
        {
            return NumWheels;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public override string ToString()
        {
            return "This car is a " + YearRelease + " " + Company + " " + Model + "";
        }

    }
}
