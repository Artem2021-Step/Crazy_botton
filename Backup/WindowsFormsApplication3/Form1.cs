using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //Создаём новый экземпляр генератора псевдослучайных чисел
            Random rnd = new Random();
            //Перемещаем кнопку на случайную позицию
            button1.Location = new Point(
                rnd.Next(0, this.Width-50),
                rnd.Next(0, this.Height-50));
        }
    }
}
