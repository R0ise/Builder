using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Создаем абстрактный класс строителя автомобиля
   abstract class CarBuilder 
    {
        public Car Car { get; private set; }
        public void CreateCar()
        {
            Car = new Car();
        }
        public abstract void SetEngine();
        public abstract void SetPaint();
        public abstract void SetStandartOpt();
        public abstract void SetLuxOpt();
    }
}
