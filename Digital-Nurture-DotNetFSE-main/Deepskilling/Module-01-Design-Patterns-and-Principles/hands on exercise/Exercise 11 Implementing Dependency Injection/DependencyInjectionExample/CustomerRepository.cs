namespace DependencyInjectionExample;
public interface ICustomerRepository
{
    Customer? FindCustomerById(int id);
}

public class CustomerRepositoryImpl : ICustomerRepository
{
    public Customer? FindCustomerById(int id)
    {
        return id==101 ? new Customer(101,"Alice") : null;
    }
}