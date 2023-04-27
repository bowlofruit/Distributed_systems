using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class MainClass
        {
            static double[] x = { 1, 2, 3, 4, 5 };
            static double[] y = { 7.1, 27.8, 62.1, 110, 161 };

            static int n = 0;
            static double a1, b1, a2, b2;
            static double d1, d2;

            public static void Main(string[] args)
            {
                if (x.Length == y.Length)
                {
                    n = x.Length;
                }
                // Нормалізація даних
                for (int i = 0; i < n; i++)
                {
                    x[i] = Math.Log(x[i]);
                }
                Thread thread1 = new Thread(ThreadFunction1);
                thread1.Start();
                Thread thread2 = new Thread(ThreadFunction2);
                thread2.Start();
                if (d1 < d2)
                {
                    Console.WriteLine("Result Point Vector: ");
                    Console.WriteLine("y = " + a1 + "* lnx +" + b1);
                }
                else
                {
                    Console.WriteLine("Result Point Vector: ");
                    Console.WriteLine("y = " + Math.Pow(Math.E, a2) + " * x^" + b2);
                }
            }

            static void ThreadFunction1()
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
                d1 = Math.Sqrt((Yi - a1 * Xi - b1) * (Yi - a1 * Xi - b1) / (Yi * Yi));
                Console.WriteLine("d1 = " + d1);
            }

            static void ThreadFunction2()
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
                d2 = Math.Sqrt((Yi - a2 * Xi - b2) * (Yi - a2 * Xi - b2) / (Yi * Yi));
                Console.WriteLine("d2 = " + d2);
            }
        }
    }
}