using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_OOP_individyalnoe_zadanie
{
    [Serializable]
    // является наследником родительского класса Праздник
    internal class Napominanie:Prazdnik
    {
        // новое поле для класса наследника для хранения занчения времени для объекта 
        private DateTime time;

        // конструктор
        public Napominanie(string event_name,DateTime event_date, DateTime itime): base(prazdnik_name: event_name, prazdnik_date: event_date)
        {
            time = itime;
        }
        // поле доступа для значения времени
        public DateTime Time { get { return time; } set { time = value; } }

        // переопределение метода Тустринг
         public override string ToString()
        {
            return $"напоминание: {base.Name}, дата: {base.Date:D}, время: {Time.Hour}:{Time.Minute}";
        }
    }
}
