namespace SOLID.DIP.Violation
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Invalid Data";

            CustomerRepository repo = new CustomerRepository();
            repo.AddCustomer(customer);

            EmailServices.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations, you are registered");

            return "Customer registered with success";
        }
    }
}