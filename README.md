# C# Encapsulation Issue: Direct Field Access

This repository demonstrates a common C# code error: directly accessing private fields outside of their defining class.  Direct field access breaks encapsulation, making the code more fragile and harder to maintain.

The `bug.cs` file showcases the problematic code.  The `bugSolution.cs` file provides the corrected version, using properties to properly encapsulate the field.

**Key Points:**

* **Encapsulation:** Protecting internal class data by accessing it through public methods (properties) rather than directly manipulating private fields.
* **Maintainability:**  Using properties allows for changes to the internal implementation without affecting external code that uses the class.
* **Testability:** Properties make testing easier because the internal representation can be changed without affecting the external API.
