using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecgurusMiddleEntity;

namespace TecgurusMiddleServices
{
    public class ProductService
    {
        DBContextUAM dBContextUAM = new DBContextUAM();

        public List<Product> GetProducts()
        {
            // Se afecta la consulta para que no traiga toda la información
            var productos = dBContextUAM.Products.ToList();
            return productos;
        }

    }
}
