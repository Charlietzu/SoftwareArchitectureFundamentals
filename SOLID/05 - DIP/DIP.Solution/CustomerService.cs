using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerService(
            IEmailService emailService,
            ICustomerRepository customerRepository)
        {
            _emailService = emailService;
            _customerRepository = customerRepository;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Invalid data";

            _customerRepository.AddCustomer(customer);

            _emailService.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations, you are registered!");

            return "Customer registered with success";
        }
    }

    public class DipTest
    {
        public DipTest()
        {
            CustomerService cusService = new CustomerService(new EmailService(), new CustomerRepository2());
        }
    }
}