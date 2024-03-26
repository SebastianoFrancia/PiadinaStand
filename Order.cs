using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    public partial class Order
    {
        private int _id;
        private (Product, int) _productsList;
        private double _amount;
        private DateTime _time;

        public int Id
        { 
            get { return _id; } 
        }
        public DateTime Time
        {
            get { return _time; }
        }

        public Order(int id)
        {
            _id = id;
            _productsList = new toupl;
            _amount = 0;
            _time = DateTime.Now;
        }

        public void AddProduct(Product newProduct, int number)
        {
            bool nuovo = true;
            if (number <= 0) throw new ArgumentException("la non è acetabile");
            for(int i=0; i<_productsList.Count; i++)
            {
                Product prodotto = _productsList[i];
                if (prodotto.Equals(newProduct))
                {
                    _quantita[i] += quantita;
                    nuovo = false;
                    break;
                }
            }
            if (nuovo)
            {
                _productsList.Add(newProduct);
                _quantita.Add(quantita);
            }
            if (_quantita.Count != _productsList.Count) throw new ArgumentException("gli elemnti del ordine non corispondono a quellid delle quantita");
        }

        public bool Equals(object? obj)
        {
            if (obj is Order)
            {
                Order ordine = obj as Order;
                if (ordine.Id == _id) return true;
            }
            return false;
        }

        public override string ToString()
        {
            string prodotti = "";
            foreach(Product prodotto in _productsList )
            {
                prodotti += _quantita.Count + prodotto.ToString() + "\n";
            }
            return $"Id:{_id}\n" + prodotti;
        }
    }
}
