using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _10.Models;
using _10.Data_Access;
namespace _10.Controllers
{
    public class ProductController : Controller
    {
            private ProductRippo _ProductRippo = new ProductRippo();
        
            public IActionResult List()
            {
              
                var result = _ProductRippo.GetList();
                return View(result);
            }

        public IActionResult Create()
        {
            //throw new DivideByZeroException();
            return View();
        }
        public IActionResult Delete(int Id)

        {
            _ProductRippo.Delete(Id);
            return RedirectToAction("List");

        }

        [HttpPost]
        public IActionResult Create(Product model)
        {   
            var currentItem = _ProductRippo.GetList().Last();
            var result = _ProductRippo.GetList();

             foreach(var n in  result)
            {
                if(n.Name == model.Name)
                {
                    n.Number = n.Number + model.Number;
                    return RedirectToAction("List");
                }
               
            }
            
                _ProductRippo.Add(new Product
                {
                    Id = currentItem.Id + 1,
                    Name = model.Name,
                    Number = model.Number,
                    Price = model.Price,
                });
            
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)

        {
            var entity = _ProductRippo.Get(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(int id, string name, int number, decimal price)

        {
            _ProductRippo.Edite(id, name,number, price);
            return RedirectToAction("List");
        }

    }
}
