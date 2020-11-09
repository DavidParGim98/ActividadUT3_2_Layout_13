using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ActividadUT3_2_Layout_13
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void AnyadirNumero(object sender, RoutedEventArgs e)
        {
            (MainWindow as MainWindow).CajaSumadora.Text += (sender as Button).Tag.ToString();
        }
    }
}
