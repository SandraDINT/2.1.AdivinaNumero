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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random seed = new Random();
        int numAleatorio = 0;
        public MainWindow()
        {
            InitializeComponent();
            GenerarNumeroAleatorio();
        }
        private int GenerarNumeroAleatorio()
        {
            return numAleatorio = seed.Next(0, 100);
        }

        private void ComprobarButtonClick(object sender, RoutedEventArgs e)
        {
            int num = Int32.Parse(numeroTextBox.Text);
            if (num == numAleatorio)
                MessageBox.Show("¡Has acertado!");
            else if(num < numAleatorio)
                MessageBox.Show("El número es más grande");
            else
                MessageBox.Show("El número es más pequeño");
        }

        private void ReiniciarButtonClick(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Clear(); // o string.empty
            numAleatorio = GenerarNumeroAleatorio();
        }
    }
}
