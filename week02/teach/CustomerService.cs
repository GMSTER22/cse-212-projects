using System.Security.Cryptography;

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        var cs = new CustomerService(-1);
        Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Test the size of the array.
        // Expected Result: if CustomerService is negative, size is 10
        Console.WriteLine("Test 1");
        Console.WriteLine( cs._maxSize ); // 10

        // Test 2
        // Scenario: Test the size of the array.
        // Expected Result: if CustomerService is negative, size is 15
        Console.WriteLine("Test 2");
        cs = new CustomerService(15);
        Console.WriteLine( cs._maxSize ); // 15

        // Test 3
        // Scenario: Test the size of the array.
        // Expected Result: if CustomerService is negative, size is 15
        Console.WriteLine("Test 3");
        cs = new CustomerService(15);
        Console.WriteLine( cs._maxSize ); // 15

        // Test 4
        // Scenario: Test the size of the array.
        // Expected Result: max size should return 5
        Console.WriteLine("Test 4");
        cs = new CustomerService(5);
        Console.WriteLine( cs._maxSize ); // 5

        // Test 5
        // Scenario: Test the size of the array.
        // Expected Result: max size should return 5
        Console.WriteLine("Test 5");
        cs = new CustomerService(5);
        cs.AddNewCustomer();
        cs.AddNewCustomer();

        cs.ServeCustomer();

        Console.WriteLine(cs.ToString());
        // Customer customer2 = new cs.Customer('Albert','011','Proem minor');
        // cs.AddNewCustomer( customer1 );
        // cs.AddNewCustomer( customer2 );


        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        private char v1;
        private char v2;
        private char v3;

        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        public Customer(char v1, char v2, char v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count <= 0)
        {
            Console.WriteLine("No Customers in the queue");
        }
        else
        {
            var customer = _queue[0];
            _queue.RemoveAt(0);
            Console.WriteLine(customer);
        }
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}