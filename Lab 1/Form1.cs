using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        static double[] x, y;
        private bool xValuesPresent = false;
        private bool yValuesPresent = false;
        static int n;
        static double a1, b1, a2, b2;
        static double d1, d2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculate_button.Enabled = false;
            n = 0;
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            x = x_textBox.Text.Split(',')
                .Select(item => item.Trim())
                .Select(item => double.Parse(item, CultureInfo.InvariantCulture))
                .ToArray();
            y = y_textBox.Text.Split(',')
                .Select(item => item.Trim())
                .Select(item => double.Parse(item, CultureInfo.InvariantCulture))
                .ToArray();

            if (x.Length == y.Length)
            {
                n = x.Length;
            }

            for (int i = 0; i < n; i++)
            {
                x[i] = Math.Log(x[i]);
            }

            Thread thread1 = new Thread(ThreadFunction1);
            thread1.Start();
            Thread thread2 = new Thread(ThreadFunction2);
            thread2.Start();

            thread1.Join();
            thread2.Join();
            if (d1 < d2)
            {
                result_lable.Text = String.Format("y = " + a1 + "* lnx +" + b1);
            }
            else
            {
                result_lable.Text = String.Format("y = " + a1 + "* lnx +" + b1);
            }
        }

        private void X_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidNumberString(x_textBox.Text, out string errorMsg))
            {
                e.Cancel = true;
                x_textBox.Select(0, x_textBox.Text.Length);
            }
            result_lable.Text = errorMsg;
        }

        private void X_textBox_Validated(object sender, EventArgs e)
        {
            xValuesPresent = true;
            if (xValuesPresent && yValuesPresent)
            {
                calculate_button.Enabled = true;
            }
        }

        private void Y_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidNumberString(y_textBox.Text, out string errorMsg))
            {
                e.Cancel = true;
                y_textBox.Select(0, y_textBox.Text.Length);
            }
            result_lable.Text = errorMsg;
        }

        private void Y_textBox_Validated(object sender, EventArgs e)
        {
            yValuesPresent = true;
            if (xValuesPresent && yValuesPresent)
            {
                calculate_button.Enabled = true;
            }
        }

        public bool IsValidNumberString(string numbersString, out string errorMessage)
        {
            if (numbersString.Length == 0)
            {
                errorMessage = "Numbers is required. ";
                return false;
            }

            Regex reg = new Regex(@"^[0-9,. ]+$");
            if (reg.Match(numbersString).Success)
            {
                errorMessage = "";
                return true;
            }
            else 
            {
                errorMessage = "Numbers string may contain only numbers, commas and dots. ";
            }

            errorMessage += "Numbers string must be valid numbers string format.\n" +
               "For example '1.5, 4.5, 3.2, 2.84' ";
            return false;
        }

        private void ThreadFunction1()
        {
            // Компоненти для вирішення системи
            double Xi = 0;
            double Xi2 = 0;
            double XiYi = 0;
            double Yi = 0;

            // Знайдемо необхідні компоненти для вирішення системи
            for (int i = 0; i < n; i++)
            {
                Xi += x[i];
                Xi2 += x[i] * x[i];
                XiYi += x[i] * y[i];
                Yi += y[i];
            }

            // Знайдемо підсумкові коефіцієнти і похибку
            a1 = (Yi * Xi2 * n - XiYi * n * Xi) / (Xi2 * n * n - n * Xi * Xi);
            b1 = (XiYi * n - Yi * Xi) / (Xi2 * n - Xi * Xi);
            d1 = Math.Sqrt(((Yi - a1 * Xi - b1) * (Yi - a1 * Xi - b1)) / (Yi * Yi));

            Console.WriteLine("d1 = " + d1);
        }

        private void ThreadFunction2()
        {
            double Xi = 0;
            double Xi2 = 0;
            double XiYi = 0;

            double Yi = 0;

            // Нормалізація даних для y = a*x^b
            for (int i = 0; i < n; i++)
            {
                y[i] = Math.Log(y[i]);
            }

            // Знайдемо необхідні компоненти для вирішення системи
            for (int i = 0; i < n; i++)
            {
                Xi += x[i];
                Xi2 += x[i] * x[i];
                XiYi += x[i] * y[i];
                Yi += y[i];
            }

            // Знайдемо підсумкові коефіцієнти і похибку
            a2 = (Yi * Xi2 * n - XiYi * n * Xi) / (Xi2 * n * n - n * Xi * Xi);
            b2 = (XiYi * n - Yi * Xi) / (Xi2 * n - Xi * Xi);
            d2 = Math.Sqrt(((Yi - a2 * Xi - b2) * (Yi - a2 * Xi - b2)) / (Yi * Yi));

            Console.WriteLine("d2 = " + d2);
        }
    }
}
