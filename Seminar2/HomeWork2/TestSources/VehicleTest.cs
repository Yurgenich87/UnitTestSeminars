using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest.Seminar2.HomeWork2.TestSources
{
    [TestFixture]
    public class VehicleTest
    {
        private Car car1;
        private Motorcycle motorcycle1;

        [SetUp]
        public void SetUp()
        {
            car1 = new Car("Mersedes", "190", 1988);
            motorcycle1 = new Motorcycle("Honda", "CB350", 2023);
        }

        // Проверка того, что экземпляр объекта Car также является экземпляром транспортного средства;
        [Test]
        public void TestInstanceOf()
        {
            Assert.IsInstanceOf<Car>(car1); // Проверяем, что car1 является экземпляром Car
            Assert.IsInstanceOf<Vehicle>(car1); // Проверяем, что car1 является экземпляром Vehicle
        }

        // Проверка того, объект Car создается с 4-мя колесами
        [Test]
        public void TestCarWheel()
        {
            int expectedNumCarWheels = 4;
            int actualNumCarWheels = car1.GetNumWheels();
            Assert.AreEqual(expectedNumCarWheels, actualNumCarWheels, "Неверное количество колес для автомобиля!");
        }

        // Проверка того, объект Motorcycle создается с 2-мя колесами
        [Test]
        public void TestMotorcуcleNumWheel()
        {
            int expectedNumMotorcуcleWheels = 2;
            int actualNumMotorcуcleWheels = motorcycle1.GetNumWheels();
            Assert.AreEqual(expectedNumMotorcуcleWheels, actualNumMotorcуcleWheels, "Неверное количество колес для мотоцикла!");
        }

        // Проверка того, объект Car развивает скорость 60 в режиме тестового вождения 
        [Test]
        public void TestCarTestDrive()
        {
            int expectedCarTestDrive = 60;
            car1.TestDrive();
            int actualCarTestDrive = car1.GetSpeed();
            Assert.AreEqual(expectedCarTestDrive, actualCarTestDrive);
        }

        // Проверка того, объект Motorcycle развивает скорость 75 в режиме тестового вождения
        [Test]
        public void TestMotorcycleTestDrive()
        {
            int expectedMotorcycleTestDrive = 75;
            motorcycle1.TestDrive();
            int actualeMotorcycleTestDriv = motorcycle1.GetSpeed();
            Assert.AreEqual(expectedMotorcycleTestDrive, actualeMotorcycleTestDriv);
        }

        /* Проверить, что в режиме парковки (сначала testDrive, потом park, т.е эмуляция движения транспорта) машина
        останавливается (speed = 0)
        */
        [Test]
        public void TestCarParking()
        {
            int expectedCarParkSpeed = 0;
            car1.TestDrive();
            car1.Park();
            int actualCarSpeed = car1.GetSpeed();
            Assert.AreEqual(expectedCarParkSpeed, actualCarSpeed, $"Автомобиль движется со скоростью {actualCarSpeed} км/ч.");
        }
        

        /* - проверить, что в режиме парковки (сначала testDrive, потом park  т.е эмуляция движения транспорта) мотоцикл
         останавливается (speed = 0)
        */
        [Test]
        public void TestMotorcycleParking()
        {
            int expectedMotorcycleParkSpeed = 0;
            motorcycle1.TestDrive();
            motorcycle1.Park();
            int actualMotorcycleSpeed = motorcycle1.GetSpeed();
            Assert.AreEqual(expectedMotorcycleParkSpeed, actualMotorcycleSpeed, $"Мотоцикл движется со скоростью {actualMotorcycleSpeed} км/ч.");
        }
    }
        
}
