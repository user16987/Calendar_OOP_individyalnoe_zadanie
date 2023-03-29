using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_OOP_individyalnoe_zadanie
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // вывод на лейбл текущей даты и время
            DateTime dateLabel = DateTime.Now;
            label_currentDataTime.Text = dateLabel.ToString("dddd dd MMMM yyyy года HH:mm");
            //чтение из файла для вывода событий на лист бокс при запуске
            //string patch = "texta.txt";
            //using (StreamReader streamReader = new StreamReader(patch))
            //{
            //    listBox.Items.Add(streamReader.ReadToEnd());
            //}
        }
        // логическая переменная для проверки наступления события выбора даты в календаре и датпикере
        bool cal = false;
        bool b = false;



        private void button_create_prazdnik_Click(object sender, EventArgs e)
        {
            // проверки заполнения требуемых полкй формы
            if (textBox_nameEvent.Text == "")
            {
                MessageBox.Show("введите название праздника");
            }
            else if (!cal)
            {
                MessageBox.Show("не выбрана дата");
            }
            else
            // создание объекта и добавление в список листбокса
            {
                Prazdnik prazdnik = new Prazdnik(textBox_nameEvent.Text, monthCalendar.SelectionStart);
                listBox.Items.Add(prazdnik);
            }

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            cal = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // вывод всех событий в сообщение
            string a = "";
            foreach (object item in listBox.Items)
            {

                a += item.ToString() + Environment.NewLine;

            }
            MessageBox.Show(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // проверки
            if (textBox_nameEvent.Text == "")
            {
                MessageBox.Show("введите название напоминания");
            }
            else if (!cal)
            {
                MessageBox.Show("не выбрана дата");
            }
            // создание объекта и добавление в список листбокса
            else
            {
                Napominanie napominanie = new Napominanie(textBox_nameEvent.Text, monthCalendar.SelectionStart, dateTimePicker.Value);
                listBox.Items.Add(napominanie);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // удаление объекта из списка
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // проверки
            if (!cal)
            {
                MessageBox.Show("не выбрана новая дата");
            }
            else
            {
                // извлечение объекта из листбокс и редактирование его
                Prazdnik prazdnik = (Prazdnik)listBox.SelectedItem;
                prazdnik.Date = monthCalendar.SelectionStart;
                listBox.Items.Add(prazdnik);
                listBox.Items.Remove(listBox.SelectedItem);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b)
            // извлечение объекта из листбокс и редактирование его
            {
                Napominanie napominanie = (Napominanie)listBox.SelectedItem;
                napominanie.Time = dateTimePicker.Value;
                listBox.Items.Add(napominanie);
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("задайте новое время");
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            b = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // запись из лист бокса в файл для сохранения событий

            FileStream fileStream = new FileStream("texta.txt", FileMode.Append);
            String text = "";
            foreach (object item in listBox.Items)
            {
                text += item.ToString() + Environment.NewLine;
            }
            byte[] array = System.Text.Encoding.UTF8.GetBytes(text);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
        }
        
    }
    
}

