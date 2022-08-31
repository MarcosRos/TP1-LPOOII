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
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMProducto.xaml
    /// </summary>
    public partial class ABMProducto : Window
    {
        public ABMProducto()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtColor.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

            txtCategoria.IsEnabled = true;
            txtCodigo.IsEnabled = true;
            txtColor.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            txtPrecio.IsEnabled = true;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            btnNuevo.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnPrimero.IsEnabled = false;
            btnSiguiente.IsEnabled = false;
            btnAnterior.IsEnabled = false;
            btnUltimo.IsEnabled = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string categoria = txtCategoria.Text;
            string codigo = txtCodigo.Text;
            string color = txtColor.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = Decimal.Parse(txtPrecio.Text);
            
            Producto oProducto = new Producto();
            oProducto.Categoría = categoria;
            oProducto.CodProducto = codigo;
            oProducto.Color = color;
            oProducto.Descripcion = descripcion;
            oProducto.Precio = precio;

            MessageBoxResult msg=MessageBox.Show(oProducto.ToString(),"Confirmacion",MessageBoxButton.OKCancel,MessageBoxImage.Exclamation);
            if (msg == MessageBoxResult.OK)
            {
                txtCategoria.IsEnabled = false;
                txtCodigo.IsEnabled = false;
                txtColor.IsEnabled = false;
                txtDescripcion.IsEnabled = false;
                txtPrecio.IsEnabled = false;

                btnGuardar.IsEnabled = false;
                btnCancelar.IsEnabled = false;

                btnNuevo.IsEnabled = true;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnPrimero.IsEnabled = true;
                btnSiguiente.IsEnabled = true;
                btnAnterior.IsEnabled = true;
                btnUltimo.IsEnabled = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtColor.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            
            txtCategoria.IsEnabled = false;
            txtCodigo.IsEnabled = false;
            txtColor.IsEnabled = false;
            txtDescripcion.IsEnabled = false;
            txtPrecio.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnPrimero.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnUltimo.IsEnabled = true;
            
        }
        //clickSalir (){this.Close();}
    }
}
