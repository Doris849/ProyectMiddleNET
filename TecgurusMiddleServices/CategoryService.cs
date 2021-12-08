using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecgurusMiddleEntity;

namespace TecgurusMiddleServices
{
    public class CategoryService
    {
        DBContextUAM dBContextUAM = new DBContextUAM();

        public List<Category> GetCategories()
        {
            //var Categories = dBContextUAM.Categories.ToList();
            // OrderBy: Ascendente  // OrderbyDescending : Descendente
            var Categories = dBContextUAM.Categories.OrderBy(O=>O.CategoryName).ToList();
            return Categories;
        }
    }
}
