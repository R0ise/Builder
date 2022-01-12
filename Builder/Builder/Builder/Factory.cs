using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Создаем класс завод
    class Factory 
    {
        public Car Fact(CarBuilder carBuilder)
        {
            carBuilder.CreateCar();
            carBuilder.SetEngine();
            carBuilder.SetPaint();
            carBuilder.SetStandartOpt();
            carBuilder.SetLuxOpt();
            return carBuilder.Car;
        }
    }
}
