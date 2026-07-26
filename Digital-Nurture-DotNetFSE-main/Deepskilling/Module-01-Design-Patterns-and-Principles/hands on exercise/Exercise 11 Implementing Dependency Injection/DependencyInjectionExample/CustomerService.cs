namespace DependencyInjectionExample;
public class CustomerService
{
    private readonly ICustomerRepository repository;
    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void DisplayCustomer(int id)
    {
        var customer = repository.FindCustomerById(id);
        if(customer!=null)
            Console.WriteLine($"Customer Found: {customer.Id} - {customer.Name}");
        else
            Console.WriteLine("Customer not found.");
    }
}