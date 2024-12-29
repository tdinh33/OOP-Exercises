namespace OOP; // a namespace, a way of logically organising and grouping related classes in C#

// Below we define a class named Employee. A class is a blueprint or template 
// that define a stucture and behaviour of objects that can be created from it.

// It encapsulates data (attributes like name, location, salary, age) and behaviours (methods like RaseSalary)
public class Employee
{
    // PROPERTIES
    // These are public properties of the class Employee. Properties are used to store data (state) about an object.
    // Each employee object created from this class will have its ownn Name, Location, Salary, and Age values. 
    public string Name { get; set; }      // This property holds the name of the employee 
    public string Location { get; set; }  // This property holds the employee's work location
    public double Salary { get; set; }    // This property holds the employee's salary 
    public int Age { get; set; }          // This property holds the employee's age 


    // CONSTRUCTOR
    // Constructor is a special method that is called when a new object  of  this class is created 
    // It initialises the object's properties 
    public Employee(string name, string location, double salary, int age)
    {
        // Here we are seeing the object's properties based on teh arguments passed in when creating a new employee 
        Name = name;
        Location = location;
        Salary = salary;
        Age = age;
    }

    // METHOD 
    // This is a method named RaiseSalary. Methods define behaviours (actions) that an object can perform
    // In this case, the action is to increase the employee's salary
    // Methods can also help with ENCAPSULATION since they control how data (salary) is manipualted.

    public void RaiseSalary()
    {
        // This increases the current salary by 20%
        // The logic to raise the salary is hidden inside this method, demonstrating encasulation 
        Salary *= 1.2;
    }
}


// OOP CONCEPTS
// CLASS: The Employee class is the "blueprint" for craeting objects. It defines what properties and methods an Employee should have 
// For example: public class Employee { ... }

// OBJECT: When you create a new instance of the Employee class, such as:
// Employee emp = new Employee("Alice", "New York", 50000, 30);
//'emp' is an object. An object is a specific instance created from a class. It has real values for its properties

// PROPERTIES: Name, Location, Salary, Age are properties of the Employee class. The hold the employee's data (state)
// Properties provide standardised wway to read and write data with potential logics (getters and setters) 

// METHODS: RaiseSalary() is a method. Methods define actions or operations that objects can perform 

// ABSTRACTION: By using a class and methods, we provide a simplified, high-level iinterface to work with emloyees
// without exposing emplementation details. For instance, calling RaiseSalary hides the complexity of how the salary 
// is calculated, just that it gets raised.

// ENCASULATION: The data (properties) and methods are bundled together inside the class. External code interacts 
// with the object through public properties and methods, rather than accessinng internal fields directly
// If we wanted more encapsulation,  we could use private fields and public getters/setters to tightly control data access.

// POLYMORPHISM: Although not explicitly shown here, polymorphism in OOP would allow objects of different classes related by inheritance to respond 
// differently to teh same method call. For example, if we had different types, of Employees (e.g., Manager, Intern) and they each had their own 
// version of RaiseSalary(), that would be polyorphism. 

// STATIC vs NON-STATIC MEMBERS: Here, all members are non-static , meaning they belong to an instance of the class 
// If a member were statistic, it would belong to the class itself, not a particular object instance. 
