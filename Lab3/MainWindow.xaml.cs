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

            FormatNumber format = FormatNumberAsCurrency;
            format += FormatNumberWithCommas;
            format += FormatNumberWithTwoPlaces;

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