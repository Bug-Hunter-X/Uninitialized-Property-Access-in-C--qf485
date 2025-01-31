public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod() {
        // The property is initialized, so it won't cause an error
        Console.WriteLine(MyProperty); 
    }

    public void MyMethod2() {
        MyProperty = 10; // Initialize it explicitly.
        Console.WriteLine(MyProperty);
    }
}