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

namespace ActividadUT3_2_Layout_13
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button uno = new Button
            {
                Content = "1",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "1"                
            };

            Button dos = new Button
            {
                Content = "2",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "2"
            };

            Button tres = new Button
            {
                Content = "3",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "3"
            };

            Button cuatro = new Button
            {
                Content = "4",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "4"
            };

            Button cinco = new Button
            {
                Content = "5",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "5"
            };

            Button seis = new Button
            {
                Content = "6",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "6"
            };

            Button siete = new Button
            {
                Content = "7",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "7"
            };

            Button ocho = new Button
            {
                Content = "8",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "8"
            };

            Button nueve = new Button
            {
                Content = "9",
                Style = (Style)Application.Current.Resources["botones"],
                Tag = "9"
            };

                    
            contenedor.Children.Add(uno);
            contenedor.Children.Add(dos);
            contenedor.Children.Add(tres);
            contenedor.Children.Add(cuatro);
            contenedor.Children.Add(cinco);
            contenedor.Children.Add(seis);
            contenedor.Children.Add(siete);
            contenedor.Children.Add(ocho);
            contenedor.Children.Add(nueve);

            Grid.SetRow(uno, 2); Grid.SetColumn(uno,0);
            Grid.SetRow(dos, 2); Grid.SetColumn(dos,1);
            Grid.SetRow(tres, 2); Grid.SetColumn(tres,2);

            Grid.SetRow(cuatro,3); Grid.SetColumn(cuatro, 0);
            Grid.SetRow(cinco, 3); Grid.SetColumn(cinco,1);
            Grid.SetRow(seis, 3); Grid.SetColumn(seis,2);

            Grid.SetRow(siete, 4); Grid.SetColumn(siete,0);
            Grid.SetRow(ocho, 4); Grid.SetColumn(ocho,1);
            Grid.SetRow(nueve, 4); Grid.SetColumn(nueve,2);
        }
    }
}
