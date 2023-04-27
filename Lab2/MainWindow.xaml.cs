using System;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System.Globalization;

namespace Lab2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThreadCalculator threadCalculator = new ThreadCalculator(firstThreadInsert.Text, secondThreadInsert.Text);

            threadCalculator.StartCalc();

            firstThreadResult.Content = threadCalculator.ResultThread1;
            secondThreadResult.Content = threadCalculator.ResultThread2;
        }
    }

    public class ThreadCalculator
    {
        public static double e;
        static bool done;
        static object locker = new object();

        private static double x1;
        private static double x2;

        public string ResultThread1 { get; set; }
        public string ResultThread2 { get; set; }

        public ThreadCalculator(string contentTextBlockThread1, string contentTextBlockThread2)
        {
            x1 = double.Parse(contentTextBlockThread1, CultureInfo.InvariantCulture);
            x2 = double.Parse(contentTextBlockThread2, CultureInfo.InvariantCulture);
        }

        public static double G1(double x)
        {
            double y = 2 * x - Math.Cos(x);
            return y;
        }

        public static double G2(double x)
        {
            double y = (2 * x - Math.Log(x)) / 3;
            return y;
        }

        public static double Calc(double x, Func<double, double> g)
        {
            double temp, d;
            do
            {
                temp = g(x);
                d = Math.Abs(temp - x);
                x = temp;
            } while (d >= e);
            return x;
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    done = true;
                }
            }
        }

        public void StartCalc()
        {
            e = 0.01;

            Thread thread1 = new Thread(() =>
            {
                Func<double, double> g = G1;
                x1 = Calc(x1, g);
                ResultThread1 = $"X= {x1}";
            });
            thread1.Start();

            Thread thread2 = new Thread(() =>
            {
                Func<double, double> g = G2;
                x2 = Calc(x2, g);
                ResultThread2 = $"X= {x2}";
            });

            thread2.Start();

            Thread t = new Thread(Go);
            t.Start();

            t.Join();
        }
    }
}
