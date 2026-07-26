using DependencyInjectionExample;

ICustomerRepository repository = new CustomerRepositoryImpl();
CustomerService service = new CustomerService(repository);

service.DisplayCustomer(101);
service.DisplayCustomer(999);
