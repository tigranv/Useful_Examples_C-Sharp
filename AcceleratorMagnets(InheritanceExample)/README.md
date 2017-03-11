# Inheritance, Encapsulation, Abstraction  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

[**Object-oriented programming**] (https://en.wikipedia.org/wiki/Object-oriented_programming) (OOP) is a programming paradigm based on the concept of "objects", which may contain data, in the form of **fields**, and code, in the form of procedures, often known as **methods**. A feature of objects is that an object's procedures can access and often modify the data fields of the object with which they are associated. In OOP, computer programs are designed by making them out of objects that interact with one another. There is significant diversity of OOP languages, but the most popular ones(c#, Java) are class-based, meaning that objects are instances of classes, which typically also determine their type.

> OOP based on 3 main paradigms
> * Encapsulation
> * Inheritance
> * Polymorphism

### **Encapsulation** 

Encapsulation is an Object Oriented Programming concept that binds together the data and functions that manipulate the data, and that keeps both safe from outside interference and misuse. Data encapsulation led to the important OOP concept of data hiding.
If a class does not allow calling code to access internal object data and permits access through methods only, this is a strong form of **abstraction** or **information hiding** known as encapsulation. Some languages let classes enforce access restrictions explicitly, for example denoting internal data with the **private keyword** and designating methods intended for use by code outside the class with the **public keyword**. Methods may also be designed **public, private, or protected** levels such as protected (which allows access from the same class and its subclasses, but not objects of a different class). Encapsulation prevents external code from being concerned with the internal workings of an object. This facilitates code refactoring, for example allowing the author of the class to change how objects of that class represent their data internally without changing any external code (as long as "public" method calls work the same way). It also encourages programmers to put all the code that is concerned with a certain set of data in the same class, which organizes it for easy comprehension by other programmers. Encapsulation is a technique that encourages decoupling.


> **Encapsulation has 3 forms:**

* Data type encapsulation - var, dynamic keywords.
* Encapsulation of code realisation - public, private, protected, protected, protected internal.
* Encapsulation of program parts - Abstraction

### **Inheritance**

Languages that support classes almost always support inheritance. This allows classes to be arranged in a hierarchy that represents "is-a-type-of" relationships. For example, class Employee might inherit from class Person. **All the data and methods available to the parent class also appear in the child class with the same names**. For example, class Person might define variables "first_name" and "lastName" with method "makeFullName()". These will also be available in class Employee, which might add the variables "position" and "salary". This technique allows easy re-use of the same procedures and data definitions, in addition to potentially mirroring real-world relationships in an intuitive way.

Abstract classes cannot be instantiated into objects; they exist only for the purpose of inheritance into other "concrete" classes which can be instantiated. In C#, the **seald** keyword can be used to prevent a class from being inherited.

Objects can contain other objects in their instance variables; this is known as object **composition**. For example, an object in the Employee class might contain (point to) an object in the Address class, in addition to its own instance variables like "firstName" and "position". 


**Polymorphism**
Subtyping, a form of polymorphism, is when calling code can be agnostic as to whether an object belongs to a parent class or one of its descendants. For example, a function might call "MakeFullName()" on an object, which will work whether the object is of class Person or class Employee. This is another type of abstraction which simplifies code external to the class hierarchy and enables strong separation of concerns.

> **Polymorphism has several forms:**

* Virtual Methods, override keyword.
* UpCast , DownCast.
* Encapsulation of program parts - Abstraction
* Ad hoc Polymorphism**

## Code Example 

### Accelerator Magnets (Inheritance, Abstraction)
The base class is **Magnets**.It includes Protectedc fields that are typical for any magnet, user constructor and method for base information. UndulatorMagnet and BendingMagnet are derived classes from Magnet
  
  ![inheritance abstraction](https://cloud.githubusercontent.com/assets/24522089/22643202/ee5ad40a-ec76-11e6-8326-19f6fe57e9e9.PNG)

> The example of using

User can construct magnet with arbitraty parameters and get the main properties and trajectry path of charged particle in such a magnet
![magnets](https://cloud.githubusercontent.com/assets/24522089/22150364/180b30d0-df32-11e6-8671-382a15198c24.PNG)

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

