using _10.Data_Access;
using Microsoft.AspNetCore.Mvc;

namespace _10.Controllers
{
    public class OrderController : Controller
    {
        private ProductRippo _ProductRippo = new ProductRippo();
        public IActionResult List()
        {
            var result = _ProductRippo.GetList();
            return View(result);
        }
        public IActionResult Delete(int Id)

        {
            foreach (var item in _ProductRippo.GetList())
            {
                if (item.Id == Id)
                {
                    
                    item.Number++;
                    item.PersonId = null;
                    break;
                }
            }

            return RedirectToAction("List");

        }
        public IActionResult Delete2(int Id)

        {
            foreach (var item in _ProductRippo.GetList())
            {
                if (item.Id == Id)
                {

                    item.Number++;
                    item.Number2 --;
                    break;
                }
            }

            return RedirectToAction("List");

        }
        public IActionResult Add(int Id)

        {
            foreach (var item in _ProductRippo.GetList())
            {
                if (item.Id == Id)
                {
                    item.Number2 ++;
                    item.Number--;
                    item.PersonId = 2;
                    break;
                }
            }
            return RedirectToAction("List");
        }
    }
}
