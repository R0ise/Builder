using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class GerCarBuilder : CarBuilder
    {
        public override void SetEngine()
        {
            this.Car.Engine = new Engine { Eng = "Двигатель 3.2" };
        }

        public override void SetPaint()
        {
            this.Car.Paint = new Paint();
        }

        public override void SetStandartOpt()
        {
            this.Car.Additives = new Additives { StandartOpt = "Обогрев заднего стекла" };
        }

        public override void SetLuxOpt()
        {
            this.Car.Additives = new Additives { LuxOpt = "Пневмоподвеска" };
        }
    }
}
