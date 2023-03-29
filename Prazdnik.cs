using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_OOP_individyalnoe_zadanie
{
    [Serializable]
    internal class Prazdnik
    {
        // поля класса празддник
        private string event_name;
        private DateTime event_date;

        // конструктур класса
        public Prazdnik(string prazdnik_name, DateTime prazdnik_date)
        {
            event_name = prazdnik_name;
            event_date = prazdnik_date;
        }
        // свойства доступа к полям
        public string Name { get { return event_name; } set { event_name = value; } }
        public DateTime Date { get {  return event_date; } set { event_date = value; } }
        
        // переопределение метода туСтринг
        public override string ToString()
        {
            return $"праздник: {Name}, дата: {Date:D}";
        }        
    }
}
