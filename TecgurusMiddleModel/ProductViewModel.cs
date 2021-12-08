using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecgurusMiddleModel
{
    // Es una clase de TecgurusMiddleModel
    public class ProductViewModel : PagedData<ProductModel>
    {
        public string ValueSearch { get; set; }
    }
}
