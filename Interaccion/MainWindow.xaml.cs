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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnBoton.Click += BtnBoton_Click;
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblIntro.Text = "¡Me cago en todo lo cagable!";
            lblIntro.FontSize = 60;
            lblIntro.Foreground = Brushes.Red;
        }

        private void BtnBoton2_Click(object sender, RoutedEventArgs e)
        {
            lblIntro.Text = "¡No me lo creo!";
            lblIntro.FontSize = 60;
            lblIntro.Foreground = Brushes.Fuchsia;
        }

        private void BtnBoton3_Click(object sender, RoutedEventArgs e)
        {
            lblIntro.Text = "¡Flipo tio!";
            lblIntro.FontSize = 60;
            lblIntro.Foreground = Brushes.BlueViolet;
        }
    }
}
