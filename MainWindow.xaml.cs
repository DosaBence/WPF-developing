using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace HF_Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Szamgombclick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Eredmeny.Content += b.Content.ToString();

        }

         double elsoszam;
        public  double masodikszam;
         string muvelet;

        private void Muveletgomb(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            elsoszam = Convert.ToDouble(Eredmeny.Content);
            muvelet = b.Content.ToString();
            Eredmeny.Content = "";
        }

        private void Egyenlosegjel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double masodikszam = Convert.ToDouble(Eredmeny.Content);
                double result = 0;
                switch (muvelet)
                {
                    case "+":
                        result = elsoszam + masodikszam;
                        break;
                    case "-":
                        result = elsoszam - masodikszam;
                        break;
                    case "*":
                        result = elsoszam * masodikszam;
                        break;
                    case "/":
                        result = elsoszam / masodikszam;
                        break;
                    case "%":
                        result = elsoszam * (masodikszam/100);
                        break;


                }
                Eredmeny.Content = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
