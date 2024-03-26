using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    public class Menu
    {
        private List<Product> _menu;

        public List<Product> GetMenu
        {
            get { return _menu; }
        }

        public Menu()
        {
            _menu = new List<Product>();
        }

        public void AggiungiProdotto(Product nuovoProdotto)
        {
            foreach (Product prodotto in _menu)
            {
                if (nuovoProdotto.Equals(prodotto)) throw new Exception("il nuovo prodotto esiste gia");
            }
            _menu.Add(nuovoProdotto);
        }
    }
}
