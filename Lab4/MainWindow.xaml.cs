using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Lab4
{
    public partial class MainWindow : Window
    {
        delegate void FormatNumber(double number);
        delegate T MathOp<T>(T a, T b);

        double formatNumber;
        string text = string.Empty;

        void FormatNumberAsCurrency(double number)
        {
            AddToOutput($"A Currency: {number:C}\n");
        }

        void FormatNumberWithCommas(double number)
        {
            AddToOutput($"With Commas: {number:N}\n");
        }

        void FormatNumberWithTwoPlaces(double number)
        {
            AddToOutput($"With 3 places: {number:.###}\n");
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToOutput(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            this.text += text;
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            mathTextBlock.Text = string.Empty;
            formatTextBlock.Text = string.Empty;

            double a = 1.0;
            double b = 3.0;
            double result = 0.0;

            FormatNumber format = FormatNumberAsCurrency;
            format += FormatNumberWithCommas;
            format += FormatNumberWithTwoPlaces;

            List<Tuple<string, MathOp<double>>> opsList = new List<Tuple<string, MathOp<double>>>()
            {
                Tuple.Create("Add", new MathOp<double>(MathOperation.Add)),
                Tuple.Create("Substruction", new MathOp<double>(MathOperation.Subtraction)),
                Tuple.Create("Divide", new MathOp<double>(MathOperation.Divide)),
                Tuple.Create("Multiply", new MathOp<double>(MathOperation.Multiply))
            };

            text += $"Math operation with numbers\n{a} and {b}\n";
            Parallel.ForEach(opsList, (op) =>
            {
                result = op.Item2(a, b);
                AddToOutput($"{op.Item1} {result:N}\n");
            });

            mathTextBlock.Text = text;
            text = string.Empty;

            formatNumber = 12345.6789;
            text += $"Format number change\n Number: {formatNumber}\n";

            Parallel.Invoke(() =>
            {
                format(formatNumber);
            });

            formatTextBlock.Text = text;
            text = string.Empty;
        }
    }
}