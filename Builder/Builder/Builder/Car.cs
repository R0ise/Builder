using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Класс Автомобиль
    class Car 
    {
        // Двигатель
        public Engine Engine { get; set; }
        // ЛКП
        public Paint Paint { get; set; }
        // опции
        public Additives Additives { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Engine != null)
                sb.Append(Engine.Eng + "\n");
            if (Paint != null)
                sb.Append("Лакокрасочное покрытие \n");
            if (Additives != null)
                sb.Append("Стандартные опции: " + Additives.StandartOpt + " \n");
            if (Additives != null)
                sb.Append("Lux опции: " + Additives.LuxOpt + " \n");
            return sb.ToString();
        }
    }
}
