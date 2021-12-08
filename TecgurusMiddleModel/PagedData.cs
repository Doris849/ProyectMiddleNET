using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecgurusMiddleModel
{
    //La clase que me herede esta obligada a enviar un valor para T
    //donde T debe ser  una clase
    public class PagedData<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int NumberOfPage { get; set; }
        public int TotalData { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
