using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    internal class ReadFile
    {
        private string _path;
        public ReadFile(string path) 
        {
            _path = path;
        }

        public Menu InizializeMenu()
        {
            Menu menu = new Menu();
            using(StreamReader sr = new StreamReader(_path))
            {
                
                string line;
                Product newProduct;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elementiLinea = line.Split(",");
                    
                    int id = int.Parse(elementiLinea[0]);
                    string name = elementiLinea[1];
                    string description = elementiLinea[2];
                    double price = double.Parse(elementiLinea[3]);

                    menu.AggiungiProdotto(new Product(id, name, description, price));
                    
                }
                return menu;
            }
        }
    }
}
