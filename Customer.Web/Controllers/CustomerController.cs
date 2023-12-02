using Customer.Web.data;
using Customer.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Web.Controllers
{
    public class CustomerController : Controller
    {
        IConfiguration _config;
        public CustomerController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult CustomerList()
        {
            DataStore ds = new DataStore(_config);            
            return View(ds.GetCustomers());
        }
        public IActionResult CreateCustomer()
        {
            CustomerVM customer = new CustomerVM();
            customer.FirstName = "Sample First";
            return View(customer);
        }
    }
}
