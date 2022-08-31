using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string rolUsuario = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario == "Hola" && password == "1234")
            {
                //Admin
                rolUsuario = "Admin";
                Menu oMenu = new Menu();
                oMenu.Show();
            }
            else if (usuario == "Adios" && password == "1234")
            {
                //Vendedor
                rolUsuario = "Vendedor";
                Menu oMenu = new Menu();
                oMenu.Show();
            }
            else 
            {
                MessageBox.Show("Usuario y/o contraseña son incorrectas","Alerta",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
