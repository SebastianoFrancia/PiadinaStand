using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private double _price;

        public int Id
        { 
            get { return _id; }
            private set 
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("l'identificativo non puo essere negativo");
                _id = value; 
            }
        }

        public string Name
        { 
            get { return _name; }
            private set
            {
                if (value == string.Empty) throw new ArgumentException("il nome è vuoto");
                //if (!(value.All(char.IsAsciiLetter))) throw new ArgumentException("il nome puo contenere solo lettere");
                _name = value;
            }
        }

        public string Description
        {
            get { return _description; }
            private set
            {
                if (value == string.Empty) throw new ArgumentException("l' elemento della descrizione è vuoto");
                //if (!(value.All(char.IsAsciiLetterOrDigit ))) throw new ArgumentException("l' elemento della descrizione puo contenere solo lettere o numeri");
                _description = value;
            }
        }

        public double Price
        {
            get { return _price; }
            private set
            {
                
                if(value <= 0) throw new ArgumentOutOfRangeException("il prezzo è negativo o pari a zero ");
                _price = value;
            }

        }

        public Product(int id,string naem, string description, double price ) 
        {
            Id = id;
            Name = naem;
            Description = description;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Product)
            {
                Product prodotto = obj as Product;
                if(_id == prodotto.Id && _description == prodotto.Description 
                    && _name == prodotto.Name && _price == prodotto._price) return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{_id},{_name},{_description},{_price}";
        }
    }
}
