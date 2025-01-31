public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized can lead to unexpected behavior or exceptions.
        Console.WriteLine(MyProperty); // This might print 0 (default value), or throw an exception depending on the context.
    }
}