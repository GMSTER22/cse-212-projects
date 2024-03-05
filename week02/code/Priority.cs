public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        string dequeuedValue;

        // Test Cases

        // Test 1
        // Scenario: create a queue then enqueue the following values Read (3), Study (2), Pray (1), Exercise (5)
        // Expected Result: [Study, Pray]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Read", 3);
        priorityQueue.Enqueue("Study", 2);
        priorityQueue.Enqueue("Pray", 1);
        priorityQueue.Enqueue("Exercise", 5);

        for (int i = 0; i < 2; i++)
        {            
           dequeuedValue = priorityQueue.Dequeue();
           Console.WriteLine(dequeuedValue);
        }

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: create a queue then enqueue the following values Read (4), Study (2), Pray (1), Exercise (5), Biking (5)
        // Expected Result: [Pray]
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Read", 4);
        priorityQueue.Enqueue("Study", 2);
        priorityQueue.Enqueue("Pray", 1);
        priorityQueue.Enqueue("Exercise", 5);
        priorityQueue.Enqueue("Biking", 5);

        for (int i = 0; i < 4; i++)
        {
            dequeuedValue = priorityQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
        }
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: create a queue then enqueue the following values Read (3), Study (5), Pray (5), Exercise (1)
        // Expected Result: [Read, Pray, Exercise]
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Read", 3);
        priorityQueue.Enqueue("Study", 5);
        priorityQueue.Enqueue("Pray", 5);
        priorityQueue.Enqueue("Exercise", 1);

        dequeuedValue = priorityQueue.Dequeue();

        Console.WriteLine(dequeuedValue);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 4
        // Scenario: create a queue then enqueue the following values Read (3), Study (5)
        // Expected Result: []
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Read", 3);
        priorityQueue.Enqueue("Study", 5);

        for (int i = 0; i < 2; i++)        {
            dequeuedValue = priorityQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
        }

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 5
        // Scenario: create a queue then enqueue the following values Drive (3)
        // Expected Result: The queue is empty * 3
        Console.WriteLine("Test 5");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Drive", 3);

        for (int i = 0; i < 4; i++)        {
            dequeuedValue = priorityQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
        }

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");
    }
}