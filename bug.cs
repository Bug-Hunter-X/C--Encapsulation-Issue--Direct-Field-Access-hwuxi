public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing _myField directly from within the class is generally fine.
        _myField = 10;
        // However, it breaks encapsulation and could lead to maintainability issues if the internal representation changes.
    }
}