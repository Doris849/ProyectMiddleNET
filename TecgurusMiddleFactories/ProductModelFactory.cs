using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecgurusMiddleModel;
using TecgurusMiddleServices;

namespace TecgurusMiddleFactories
{
    public class ProductModelFactory
    {
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        private const int PageSize = 10;

        //Crear un metodo que regrese los datos para paginado y la coleccion
        //de datos a paginar,Este es el metodo de inicio para index
        public ProductViewModel PrepareToProductViewModel()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            var ListProductModel = GetProductsWithCategory();
            productViewModel.CurrentPage = 1;
            productViewModel.NumberOfPage = Convert.ToInt32(Math.Ceiling((double)ListProductModel.Count() / PageSize));
            //el take es una instruccion que permite tomar cierta cantidad de datos de una colección
            productViewModel.Data = ListProductModel.Take(PageSize).ToList();
            productViewModel.TotalData = ListProductModel.Count();
            return productViewModel;
        }

        //Accion para manipular las acciones de paginado y busqueda

        //public ProductViewModel PrepareToProductViewModel(int page)
        public ProductViewModel PrepareToProductViewModel(int page, string valueSearch)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            var ListProductModel = GetProductsWithCategory();
            if (!string.IsNullOrEmpty(valueSearch))
            {
                ListProductModel = ListProductModel.Where(w =>
                                    w.ProductName.ToUpper().Contains(valueSearch.ToUpper()) 
                                    ||
                                    w.CategoryName.ToUpper().Contains(valueSearch.ToUpper())
                                    );
            }


            productViewModel.CurrentPage = page;
            productViewModel.NumberOfPage = Convert.ToInt32(Math.Ceiling((double)ListProductModel.Count() / PageSize));
            //el take es una instruccion que permite tomar cierta cantidad de datos de una colección
            productViewModel.Data = ListProductModel.Skip(PageSize * (page - 1)).Take(PageSize).ToList();
            productViewModel.TotalData = ListProductModel.Count();
            return productViewModel;
        }

        /// <summary>
        /// Estructura de una consulta que puede ser manipulada posteriormente,
        /// para agregar mas filtros de busqueda ya que aun no va a Base de datos
        /// </summary>
        /// <returns></returns>
        public IQueryable<ProductModel> GetProductsWithCategory()
        {
            var query = (from p in productService.GetProducts()
                         join c in categoryService.GetCategories()
                         on p.CategoryID equals c.CategoryID
                         select new ProductModel
                         {
                             ProductID = p.ProductID,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice,
                             QuantityPerUnit = p.QuantityPerUnit,
                             CategoryID = c.CategoryID,
                             CategoryName = c.CategoryName
                         }

                ).AsQueryable();
            return query;
        }

    }
}
