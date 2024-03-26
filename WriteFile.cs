using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    internal class WriteFile
    {
        private string _path;
        public WriteFile(string path)
        {
            _path = path;
        }

        public void WriteOrder(OrdersDay ordini)
        {
            using (StreamWriter sw = new StreamWriter(_path,true))
            {
                sw.WriteLine(ordini.Data);
                foreach (Order ordine in ordini.Order) 
                {
                    sw.WriteLine(ordine.ToString());
                }
            }
        }
    }
}
