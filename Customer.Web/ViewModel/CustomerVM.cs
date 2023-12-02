namespace Customer.Web.ViewModel
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNr { get; set; }
        public string Email { get; set; }
    }
}
