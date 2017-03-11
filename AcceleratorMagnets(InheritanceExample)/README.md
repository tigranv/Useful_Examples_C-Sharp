# Inheritance, Encapsulation, Abstraction  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

**Object-oriented programming** (OOP) is a programming paradigm based on the concept of "objects", which may contain data, in the form of **fields**, and code, in the form of procedures, often known as ** methods**. A feature of objects is that an object's procedures can access and often modify the data fields of the object with which they are associated. In OOP, computer programs are designed by making them out of objects that interact with one another. There is significant diversity of OOP languages, but the most popular ones(c#, Java) are class-based, meaning that objects are instances of classes, which typically also determine their type.
> OOP based on 3 main paradigms
> * Encapsulation
> * Inheritance
> * Polymorphism

**Encapsulation** 
Encapsulation is an Object Oriented Programming concept that binds together the data and functions that manipulate the data, and that keeps both safe from outside interference and misuse. Data encapsulation led to the important OOP concept of data hiding.
If a class does not allow calling code to access internal object data and permits access through methods only, this is a strong form of **abstraction** or **information hiding** known as encapsulation. Some languages let classes enforce access restrictions explicitly, for example denoting internal data with the **private keyword** and designating methods intended for use by code outside the class with the **public keyword**. Methods may also be designed **public, private, or protected** levels such as protected (which allows access from the same class and its subclasses, but not objects of a different class). Encapsulation prevents external code from being concerned with the internal workings of an object. This facilitates code refactoring, for example allowing the author of the class to change how objects of that class represent their data internally without changing any external code (as long as "public" method calls work the same way). It also encourages programmers to put all the code that is concerned with a certain set of data in the same class, which organizes it for easy comprehension by other programmers. Encapsulation is a technique that encourages decoupling.

>Encapsulation have 3 forms:

* Data type encapsulation - var, dynamic keywords.
* Encapsulation of code realisation - public, private, protected, protected, protected internal.
* Encapsulation of program parts - Abstraction

**Composition, inheritance, and delegation**
Objects can contain other objects in their instance variables; this is known as object composition. For example, an object in the Employee class might contain (point to) an object in the Address class, in addition to its own instance variables like "first_name" and "position". Object composition is used to represent "has-a" relationships: every employee has an address, so every Employee object has a place to store an Address object.
Languages that support classes almost always support inheritance. This allows classes to be arranged in a hierarchy that represents "is-a-type-of" relationships. For example, class Employee might inherit from class Person. All the data and methods available to the parent class also appear in the child class with the same names. For example, class Person might define variables "first_name" and "last_name" with method "make_full_name()". These will also be available in class Employee, which might add the variables "position" and "salary". This technique allows easy re-use of the same procedures and data definitions, in addition to potentially mirroring real-world relationships in an intuitive way. Rather than utilizing database tables and programming subroutines, the developer utilizes objects the user may be more familiar with: objects from their application domain.[8]
Subclasses can override the methods defined by superclasses. Multiple inheritance is allowed in some languages, though this can make resolving overrides complicated. Some languages have special support for mixins, though in any language with multiple inheritance, a mixin is simply a class that does not represent an is-a-type-of relationship. Mixins are typically used to add the same methods to multiple classes. For example, class UnicodeConversionMixin might provide a method unicode_to_ascii() when included in class FileReader and class WebPageScraper, which don't share a common parent.
Abstract classes cannot be instantiated into objects; they exist only for the purpose of inheritance into other "concrete" classes which can be instantiated. In Java, the final keyword can be used to prevent a class from being subclassed.
The doctrine of composition over inheritance advocates implementing has-a relationships using composition instead of inheritance. For example, instead of inheriting from class Person, class Employee could give each Employee object an internal Person object, which it then has the opportunity to hide from external code even if class Person has many public attributes or methods. Some languages, like Go do not support inheritance at all.
The "open/closed principle" advocates that classes and functions "should be open for extension, but closed for modification".
Delegation is another language feature that can be used as an alternative to inheritance.

**Polymorphism**
Subtyping, a form of polymorphism, is when calling code can be agnostic as to whether an object belongs to a parent class or one of its descendants. For example, a function might call "make_full_name()" on an object, which will work whether the object is of class Person or class Employee. This is another type of abstraction which simplifies code external to the class hierarchy and enables strong separation of concerns.


### Accelerator Magnets (Inheritance, Abstraction)
The base class is **Magnets**.It includes Protectedc fields that are typical for any magnet, user constructor and method for base information. UndulatorMagnet and BendingMagnet are derived classes from Magnet
  
  ![inheritance abstraction](https://cloud.githubusercontent.com/assets/24522089/22643202/ee5ad40a-ec76-11e6-8326-19f6fe57e9e9.PNG)

> The example of using

User can construct magnet with arbitraty parameters and get the main properties and trajectry path of charged particle in such a magnet
![magnets](https://cloud.githubusercontent.com/assets/24522089/22150364/180b30d0-df32-11e6-8671-382a15198c24.PNG)

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

