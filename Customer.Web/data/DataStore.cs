using Customer.Web.ViewModel;

namespace Customer.Web.data
{
    public class DataStore
    {
        IConfiguration _config;
        CustomerDbContext db;
        public DataStore(IConfiguration config)
        {
            _config = config;
            db = new CustomerDbContext(_config);
        }

        public IEnumerable<CustomerVM> GetCustomers()
        {
            IEnumerable <CustomerVM>   custList= new List<CustomerVM>();
            string sql = "SELECT Customer_id id, FNAME FirstName, LNAME LastName, PHONENR PhoneNr, EMAIL Email FROM CUSTOMERS order by 1";
            custList = db.Query<CustomerVM>(sql);
            return custList;
        }

    }
}
