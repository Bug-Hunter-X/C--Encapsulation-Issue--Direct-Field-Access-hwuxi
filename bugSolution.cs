public class ExampleClass
{
    private int _myField;

    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing the field through the property maintains encapsulation.
        MyProperty = 10; 
    }
}