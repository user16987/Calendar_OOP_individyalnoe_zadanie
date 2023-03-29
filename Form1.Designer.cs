using System;
using System.Windows.Forms;

namespace Calendar_OOP_individyalnoe_zadanie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_title = new System.Windows.Forms.Label();
            this.label_currentDataTime = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button_create_prazdnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_newDate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label_listBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nameEvent = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1_title
            // 
            this.label1_title.AutoSize = true;
            this.label1_title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_title.Location = new System.Drawing.Point(221, 20);
            this.label1_title.Name = "label1_title";
            this.label1_title.Size = new System.Drawing.Size(276, 23);
            this.label1_title.TabIndex = 0;
            this.label1_title.Text = "ТЕКУЩАЯ ДАТА И ВРЕМЯ :";
            // 
            // label_currentDataTime
            // 
            this.label_currentDataTime.AutoSize = true;
            this.label_currentDataTime.BackColor = System.Drawing.SystemColors.Window;
            this.label_currentDataTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currentDataTime.Location = new System.Drawing.Point(574, 20);
            this.label_currentDataTime.Name = "label_currentDataTime";
            this.label_currentDataTime.Size = new System.Drawing.Size(70, 23);
            this.label_currentDataTime.TabIndex = 1;
            this.label_currentDataTime.Text = "............";
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar.Location = new System.Drawing.Point(34, 133);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // button_create_prazdnik
            // 
            this.button_create_prazdnik.BackColor = System.Drawing.SystemColors.Info;
            this.button_create_prazdnik.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_prazdnik.Location = new System.Drawing.Point(304, 495);
            this.button_create_prazdnik.Name = "button_create_prazdnik";
            this.button_create_prazdnik.Size = new System.Drawing.Size(243, 58);
            this.button_create_prazdnik.TabIndex = 3;
            this.button_create_prazdnik.Text = "назначить новый праздник";
            this.button_create_prazdnik.UseVisualStyleBackColor = false;
            this.button_create_prazdnik.Click += new System.EventHandler(this.button_create_prazdnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(170, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите дату \r\nпраздника или напоминания";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "введите время напоминания";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(304, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "установить новое напоминание\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(566, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "показать все праздники и напоминания\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(566, 577);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "удалить праздник или напоминание\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(546, 133);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(552, 319);
            this.listBox.TabIndex = 12;
            // 
            // button_newDate
            // 
            this.button_newDate.BackColor = System.Drawing.SystemColors.Info;
            this.button_newDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_newDate.Location = new System.Drawing.Point(828, 495);
            this.button_newDate.Name = "button_newDate";
            this.button_newDate.Size = new System.Drawing.Size(255, 58);
            this.button_newDate.TabIndex = 13;
            this.button_newDate.Text = "установить новую дату праздника или напоминания\r\n";
            this.button_newDate.UseVisualStyleBackColor = false;
            this.button_newDate.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(828, 577);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 58);
            this.button6.TabIndex = 14;
            this.button6.Text = "установить новое время напоминания";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_listBox
            // 
            this.label_listBox.AutoSize = true;
            this.label_listBox.BackColor = System.Drawing.SystemColors.Info;
            this.label_listBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_listBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_listBox.Location = new System.Drawing.Point(642, 61);
            this.label_listBox.Name = "label_listBox";
            this.label_listBox.Size = new System.Drawing.Size(307, 63);
            this.label_listBox.TabIndex = 15;
            this.label_listBox.Text = "Выберите дату \r\nпраздника или напоминания\r\nдля редактирования списка событий";
            this.label_listBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 42);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ввведите имя \r\nпраздника или напоминания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_nameEvent
            // 
            this.textBox_nameEvent.Location = new System.Drawing.Point(52, 516);
            this.textBox_nameEvent.Name = "textBox_nameEvent";
            this.textBox_nameEvent.Size = new System.Drawing.Size(233, 20);
            this.textBox_nameEvent.TabIndex = 17;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(52, 588);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(235, 29);
            this.dateTimePicker.TabIndex = 18;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 659);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_nameEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_listBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_newDate);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_create_prazdnik);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label_currentDataTime);
            this.Controls.Add(this.label1_title);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ПРИЛОЖЕНИЕ КАЛЕНДАРЬ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_title;
        public System.Windows.Forms.Label label_currentDataTime;
        private MonthCalendar monthCalendar;
        private Button button_create_prazdnik;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox;
        private Button button_newDate;
        private Button button6;
        private Label label_listBox;
        private Label label4;
        private TextBox textBox_nameEvent;
        private DateTimePicker dateTimePicker;
    }
}

