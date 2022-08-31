﻿using System;
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
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Admin
            if (MainWindow.rolUsuario == "Admin")
            {
                btnProveedores.IsEnabled = true;
                btnClientes.IsEnabled = true;
                btnProductos.IsEnabled = true;
                btnVendedores.IsEnabled = true;

                //lblCargo.Content = "Administrador"
            }
            //Vendedor
            else
            {
                btnProveedores.IsEnabled = true;
                btnClientes.IsEnabled = true;
                btnProductos.IsEnabled = true;
                btnVendedores.IsEnabled = false;

                //lblCargo.Text = "Vendedor"
            }
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            ABMProductos oABMProductos = new ABMProductos();
            oABMProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            ABMClientes oABMClientes = new ABMClientes();
            oABMClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            ABMProveedores oABMProveedores = new ABMProveedores();
            oABMProveedores.ShowDialog();
        }

        private void btnVendedores_Click(object sender, RoutedEventArgs e)
        {
            ABMVendedores oABMVendedores = new ABMVendedores();
            oABMVendedores.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }
    }
}
