using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form

    {
		public Form1()
		{
			InitializeComponent();
			KeyPreview = true;
		}

		//Переменная первой цифры предстоящей математической операции
		float a;
		
		//Переменная-буфер
		float b;

		//Case для switch
		int count;

		//Знак (true - положительный, false - отрицательный)
		bool znak = true;

		//Математические операции
		private void calculate()
		{
			switch (count)
			{
				//Сложение
				case 1:
					b = a + float.Parse(textBox1.Text);
					textBox1.Text = b.ToString();
					break;

				//Вычетание
				case 2:
					b = a - float.Parse(textBox1.Text);
					textBox1.Text = b.ToString();
					break;

				//Умножение
				case 3:
					b = a * float.Parse(textBox1.Text);
					textBox1.Text = b.ToString();
					break;

				//Деление
				case 4:
					b = a / float.Parse(textBox1.Text);
					textBox1.Text = b.ToString();
					break;

				default:
					break;
			}

		}

		//Цифры (от 0 до 9)
		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6"; ;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}

		private void button14_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		//Кнопка "="
		private void button3_Click(object sender, EventArgs e)
		{
			calculate();
			label1.Text = "";
		}

		//Кнопка "+"
		private void button7_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			textBox1.Clear();
			count = 1;
			label1.Text = a.ToString() + "+";
			znak = true;
		}

		//Кнопка "-"
		private void button11_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			textBox1.Clear();
			count = 2;
			label1.Text = a.ToString() + "-";
			znak = true;
		}

		//Кнопка "*"
		private void button15_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			textBox1.Clear();
			count = 3;
			label1.Text = a.ToString() + "*";
			znak = true;
		}

		//Кнопка "/"
		private void button19_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			textBox1.Clear();
			count = 4;
			label1.Text = a.ToString() + "/";
			znak = true;
		}

		//Запятая
		private void button2_Click(object sender, EventArgs e)
		{
			string k = textBox1.Text;
			int i = k.IndexOf(",", 0, k.Length);

			if (!(i != (-1) || k.Length == 0 || (k.Length == 0)))
			{
				textBox1.Text += ",";
			}
		}

		//Кнопка "+/-"
		private void button17_Click(object sender, EventArgs e)
		{
			if (znak == true)
			{
				textBox1.Text = "-" + textBox1.Text;
				znak = false;
			}
			else if (znak == false)
			{
				textBox1.Text = textBox1.Text.Replace("-", "");
				znak = true;
			}
		}

		//Кнопка "C"
		private void button16_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			label1.Text = "";
		}



		private void label1_Click(object sender, EventArgs e)
        {

        }

		//Таблица вводных чисел + вывода ответа
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		//Поле
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
