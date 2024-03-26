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

namespace PiadinaStand
{
    /// <summary>
    /// Logica di interazione per OrdinePagina.xaml
    /// </summary>
    public partial class OrdinePagina : Page
    {
        private Order _newOrder;
        public OrdinePagina(OrdersDay ordiniGiornata, Menu menu)
        {
            InitializeComponent();
            lbxMenu.ItemsSource = menu.GetMenu;
            int idOrder = ordiniGiornata.Order.Count + 1;
            _newOrder = new Order(idOrder);
        }

        private void btnPiu_Click(object sender, RoutedEventArgs e)
        {
            if(lbxMenu.IsEnabled)
            {

                if (int.TryParse(lblQuantita.Content.ToString(), out int quantita))
                {
                    lblQuantita.Content = $"{quantita += 1}";
                }
                else throw new Exception();
            }
            else
            {
                MessageBox.Show("prodotto non selezionato");
                lblQuantita.Content = "0";
            }
        }

        private void btnPiu_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (lbxMenu.SelectionMode != null)
            {

                if (int.TryParse(lblQuantita.Content.ToString(), out int quantita))
                {
                    lblQuantita.Content = $"{quantita -= 1}";
                }
                else throw new Exception();
            }
            else
            {
                MessageBox.Show("prodotto non selezionato");
                lblQuantita.Content = "0";
            }
        }

        private void btnAgiungiOrdine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lbxMenu.SelectionMode != null)
                {
                    if (lbxMenu.SelectedItem is Product)
                    {
                        Product nuovoProdotto = lbxMenu.SelectedItem as Product;
                        int quantita = int.Parse(lblQuantita.Content.ToString());
                        _newOrder.AddProduct(nuovoProdotto, quantita);
                        lblOrdine.Content = _newOrder.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblQuantita.Content = "0";
        }
    }
}
