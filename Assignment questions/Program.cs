//1. * *Encapsulation Challenge**
//Create a `BankAccount` class where `balance` is a private field.Implement methods for `Deposit()` and `Withdraw()`, ensuring that withdrawal is only allowed if there is a sufficient balance.Prevent direct modification of `balance` from outside the class.
//namespace ConsoleApp1
//{
//    public class BankAccount
//    {
//        private decimal _balance;
//        public BankAccount(int initialBalance)
//        {
//            _balance = initialBalance;
//        }
//        public void Deposit(int amount)
//        {
//            _balance += amount;
//        }
//        public void Withdraw(int amount)
//        {
//            if (amount <= _balance)
//            {
//                _balance -= amount;
//            }
//        }
//        public void Check()
//        {
//            Console.WriteLine($"Current balance is {_balance}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            BankAccount ba = new BankAccount(1800);
//            ba.Deposit(1000);
//            ba.Check();
//            ba.Withdraw(800);
//            ba.Check();
//        }
//    }
//}


//2. * *Data Hiding with Properties**
//Create a `Student` class where `Name` and `RollNo` are private fields.Use properties to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).

//namespace ConsoleApp1
//{
//    class Student
//    {
//        private string _name;
//        private int _rollNo;
//        public void validateName(string name)
//        {
//            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
//            {
//                throw new ArgumentException("Name cannot be empty");
//            }
//            _name = name;
//        }
//        public void validateRollNo(int rollNo)
//        {
//            if (rollNo < 0)
//            {
//                throw new ArgumentException("Roll Number cannot be negative");
//            }
//            _rollNo = rollNo;
//        }
//        public void display()
//        {
//            Console.WriteLine($"Name: {_name}\nRoll Number: {_rollNo}");
//        }
//        public Student(string name, int rollNo)
//        {
//            validateName(name);
//            validateRollNo(rollNo);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter student details (name and roll number): ");
//            string name = Console.ReadLine();
//            int rollNo = Int32.Parse(Console.ReadLine());
//            Student st = new Student(name, rollNo);
//            st.display();
//        }
//    }
//}

//3. * *Constructor Overloading in a Library System**
// Implement a `Book` class with three different constructors: (1) Default constructor, (2) Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and `ISBN`. Ensure each constructor initializes properties correctly.
//namespace ConsoleApp1
//{
//    public class Book
//    {
//        public Book()
//        {
//            Console.WriteLine("Default constructor\n");
//        }
//        public Book(string title, string author)
//        {
//            Console.WriteLine($"Title: {title}\nAuthor: {author}\n");
//        }
//        public Book(string title, string author, int isbn)
//        {
//            Console.WriteLine($"Title: {title}\nAuthor: {author}\nISBN: {isbn}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Book b1 = new Book();
//            Book b2 = new Book("compound effect", "darren hardy");
//            Book b3 = new Book("Gita", "Krishna", 1081008);
//        }
//    }
//}

//4. **Abstraction with Abstract Classes**
//Design an abstract class `Shape` with an abstract method `CalculateArea()`. Create derived classes `Circle` and `Rectangle` that implement this method. Demonstrate abstraction by instantiating these classes.
//namespace ConsoleApp1
//{
//    abstract class Shape
//    {
//        public abstract void CalculateArea();
//    }
//    class Circle : Shape
//    {
//        int radius;
//        public Circle(int radius)
//        {
//            this.radius = radius;
//        }
//        public override void CalculateArea()
//        {
//            Console.WriteLine($"Area of circle is {3.14*radius*radius}");
//        }
//    }
//    class Rectangle : Shape
//    {
//        int length, breadth;
//        public Rectangle(int length, int breadth)
//        {
//            this.length = length;
//            this.breadth = breadth;
//        }

//        public override void CalculateArea()
//        {
//            Console.WriteLine($"Area of rectangle is {length*breadth}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Circle cir = new Circle(1);
//            cir.CalculateArea();
//            Rectangle rect = new Rectangle(10, 20);
//            rect.CalculateArea();
//        }
//    }
//}

//5. * *Method Overriding for a Vehicle System**
//Create a base class `Vehicle` with a method `Start()`. Override it in `Car` and `Bike` classes to provide specific implementations. Use the `override` keyword and demonstrate polymorphism.
//namespace ConsoleApp1
//{
//    class Vehicle
//    {
//        public virtual void Start()
//        {
//            Console.WriteLine("Start method in Vehicle class");
//        }
//    }
//    class Car : Vehicle
//    {
//        public override void Start()
//        {
//            Console.WriteLine("Start method in Car class");
//        }
//    }
//    class Bike : Vehicle
//    {
//        public override void Start()
//        {
//            Console.WriteLine("Start method in Bike class");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Vehicle vehicle = new Vehicle();
//            vehicle.Start();
//            Bike bike = new Bike();
//            bike.Start();
//            Car car = new Car();
//            car.Start();
//        }
//    }
//}

//6. **Using Virtual Methods in Inheritance**
//Create a `Person` base class with a `GetDetails()` method. Derive `Student` and `Teacher` classes that override `GetDetails()` to display their respective properties. Call `GetDetails()` using a base class reference.
//namespace ConsoleApp1
//{
//    class Person
//    {
//        public virtual void GetDetails()
//        {
//            Console.WriteLine("Person details method\n");
//        }
//    }
//    class Student : Person
//    {
//        string name, rollNo;
//        public Student(string name, string rollNo)
//        {
//            this.name = name;
//            this.rollNo = rollNo;
//        }
//        public override void GetDetails()
//        {
//            Console.WriteLine($"Student details ->\nName: {name}\nRoll Number: {rollNo}\n");
//        }
//    }
//    class Teacher : Person
//    {
//        int salary;
//        string subject;
//        public Teacher(int salary, string subject)
//        {
//            this.salary = salary;
//            this.subject = subject;
//        }
//        public override void GetDetails()
//        {
//            Console.WriteLine($"Student details ->\nSalary: {salary}\nSubject: {subject}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Person person = new Person();
//            person.GetDetails();
//            Student student = new Student("Sumesh", "5L2");
//            student.GetDetails();
//            Teacher teacher = new Teacher(108000, "ML");
//            teacher.GetDetails();
//        }
//    }
//}

//7. * *Method Overloading in a Calculator Class**
//Implement a `Calculator` class with overloaded methods `Add()`. It should accept two integers, three integers, and two double values separately. Demonstrate how method overloading works.
//namespace ConsoleApp1
//{
//    class Calculator
//    {
//        public void Add(int first, int second)
//        {
//            Console.WriteLine($"Addition of two numbers is {first + second}");
//        }
//        public void Add(int first, int second, int third)
//        {
//            Console.WriteLine($"Addition of three numbers is {first + second + third}");
//        }
//        public void Add(double first, double second)
//        {
//            Console.WriteLine($"Addition of two numbers is {first + second}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Calculator calc = new Calculator();
//            calc.Add(10, 20);
//            calc.Add(10, 20, 30);
//            calc.Add(19.12012901, 7281.192121);
//        }
//    }
//}

//8. * *Interface Implementation Challenge**
//Define an interface `IPlayable` with a method `Play()`. Implement this interface in `MusicPlayer` and `VideoPlayer` classes with different implementations.
//namespace ConsoleApp1
//{
//    interface IPlayable
//    {
//        void Play();
//    }
//    class MusicPlayer : IPlayable
//    {
//        public void Play()
//        {
//            Console.WriteLine("Music player playing");
//        }
//    }
//    class VideoPlayer : IPlayable
//    {
//        public void Play()
//        {
//            Console.WriteLine("Video player playing");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            MusicPlayer mp = new MusicPlayer();
//            mp.Play();
//            VideoPlayer vp = new VideoPlayer();
//            vp.Play();
//        }
//    }
//}

//9. **Multiple Inheritance Using Interfaces**
//Define two interfaces `IPrintable` (for printing details) and `ISerializable` (for saving to a file). Implement both in a `Report` class and demonstrate multiple interface implementation.
//interface IPrintable
//{
//    void displayInfo();
//}
//interface ISerializable
//{
//    void saveFile();
//}
//class Report : IPrintable, ISerializable
//{
//    public void displayInfo()
//    {
//        Console.WriteLine("Printing details displayed");
//    }
//    public void saveFile()
//    {
//        Console.WriteLine("Saved file successfully");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Report rep = new Report();
//        rep.displayInfo();
//        rep.saveFile();
//    }
//}

//10. **Design a Role-Based Access System**
//Create a base class `User` with properties like `Username` and `Role`. Derive `Admin` and `Customer` classes that override a method `AccessControl()`, where `Admin` can access all features, but `Customer` has limited access.
//class User
//{
//    protected string username, role;
//    public User(string username, string role)
//    {
//        this.username = username;
//        this.role = role;
//    }
//    public virtual void AccessControl()
//    {
//        Console.WriteLine("Any user can access this method");
//    }
//}
//class Admin : User
//{
//    public Admin(string username) : base(username, "Admin")
//    {
//    }

//    public override void AccessControl()
//    {
//        Console.WriteLine("Admin can access this method");
//    }
//}
//class Customer : User
//{
//    public Customer(string username) : base(username, "Customer")
//    {
//    }

//    public override void AccessControl()
//    {
//        Console.WriteLine("Customer can access this method");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        User u = new User("user1", "user2");
//        u.AccessControl();
//        Admin ad = new Admin("ram");
//        ad.AccessControl();
//        Customer c = new Customer("krishna");
//        c.AccessControl();
//    }
//}

//11. **Operator Overloading for Complex Numbers**
//Create a `ComplexNumber` class with properties `Real` and `Imaginary`. Overload the `+` operator to add two complex numbers.
//class ComplexNumber
//{
//    int real, imaginary;
//    public ComplexNumber(int r, int i)
//    {
//        this.real = r;
//        this.imaginary = i;
//    }
//    public void showInfo()
//    {
//        Console.WriteLine($"{real} + {imaginary}i");
//    }
//    public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
//    {
//        ComplexNumber cn3 = new ComplexNumber(0, 0);
//        cn3.real = cn1.real + cn2.real;
//        cn3.imaginary = cn1.imaginary + cn2.imaginary;
//        return cn3;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        ComplexNumber cn1 = new ComplexNumber(2, 7);
//        ComplexNumber cn2 = new ComplexNumber(5, 4);
//        ComplexNumber cn3 = cn1 + cn2;
//        cn3.showInfo();
//    }
//}

//12. **Shallow Copy vs. Deep Copy**
//Create a `Department` class with a reference-type property `Manager`. Implement both **Shallow Copy** and **Deep Copy** to show how references are handled.

// Shallow copy vs Deep copy
// Shallow copy
//class Department
//{
//    public string dept;
//    public Manager Manager;

//    public Department ShallowCopy()
//    {
//        return (Department)this.MemberwiseClone();
//    }
//}
//public class Manager
//{
//    public string name;
//}
//class Program
//{
//    static void Main()
//    {
//        Department dep1 = new Department
//        {
//            dept = "IT",
//            Manager = new Manager { name = "Sumesh" }
//        };
//        Department dep2 = dep1.ShallowCopy();
//        dep2.Manager.name = "Ram";
//        Console.WriteLine(dep1.Manager.name);
//    }
//}
// Deep copy
//public class Department
//{
//    public string dept;
//    public Manager Manager;
//    public Department DeepCopy()
//    {
//        Department clone = (Department)this.MemberwiseClone();
//        clone.Manager = new Manager { name = this.Manager.name };
//        return clone;
//    }
//}
//public class Manager
//{
//    public string name;
//}
//class Program
//{
//    static void Main()
//    {
//        Department dep1 = new Department
//        {
//            dept = "IT",
//            Manager = new Manager { name = "Sumesh" }
//        };
//        Department dep2 = dep1.DeepCopy();
//        dep2.Manager.name = "Rama";
//        Console.WriteLine(dep1.Manager.name);
//    }
//}

//13. **Static Members in a Banking System**
//Implement a `Bank` class with a static field `InterestRate` and a static method `SetInterestRate()`. Show how static members work across multiple objects.
//class Bank
//{
//    public static decimal interestRate = 108;
//    public static void setInterestRate()
//    {
//        Console.WriteLine($"Interest rate set to {interestRate}");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Bank.setInterestRate();
//    }
//}

//14. **Sealed Class in a Security System**
//Create a sealed class `SecuritySystem` that prevents inheritance. Show how sealing a class stops further extension.
//sealed class SecuritySystem
//{
//    public int Add(int num1, int num2)
//    {
//        return num1 + num2;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        // cannot inherit the sealed classes in derived class
//        SecuritySystem ss = new SecuritySystem();
//        Console.WriteLine(ss.Add(10, 8));
//    }
//}

//15. **Use of Delegates for Event Handling**
//Create a `Button` class that has a delegate `OnClick`. Implement an event that triggers when the button is clicked.
//public delegate void ButtonClickHandler();
//class Button
//{
//    public event ButtonClickHandler? OnClick;
//    public void Click()
//    {
//        Console.WriteLine("Button clicked!");
//        OnClick?.Invoke();
//    }
//}
//class Program
//{
//  static void Main()
//    {
//        Button button = new Button();
//        button.OnClick += ButtonClicked;
//        button.Click();
//    }
//    public static void ButtonClicked()
//    {
//        Console.WriteLine("Button click event triggered");
//    }
//}