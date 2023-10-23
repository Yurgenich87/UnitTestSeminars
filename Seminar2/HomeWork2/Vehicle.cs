using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2.HomeWork2
{
    public abstract class Vehicle
    {
        private string Сompany;
        private string Model;
        private int YearRelease;
        private int NumWheels;
        private int Speed;

        public abstract void TestDrive();
        public abstract void Park();
    }
}
