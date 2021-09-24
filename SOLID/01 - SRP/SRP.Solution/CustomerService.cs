namespace SOLID.SRP.Solution
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Invalid data";

            CustomerRepository repo = new CustomerRepository();
            repo.AddCustomer(customer);

            EmailServices.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations, you are registered!");

            return "Successfully registered customer";
        }
    }
}