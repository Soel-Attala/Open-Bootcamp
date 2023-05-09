// Class 24 - Design Patterns
/*
We have two types of design patterns:

    * 1. Creation patterns: they help us to create objects, classes, etc.
    *
            * Factory: Allows us to produce families of related objects 
                       without specifying their concrete classes. 
            * Builder: Allows us to build complex objects step by step, 
                       we can produce different types and representations of objects 
                       using the same building code.
            * FactoryMethod: allows to have an interface to create objects in a superclass 
                             and subclasses below that superclass can alter the type of object that is created.
            * Prototype: Allows copying existing objects without depending on their class.
            * Singleton: Allows us to ensure that a class has a single instance, 
                         while providing a global access point to that instance.


    * 2. Structural: they allow us to create code architecture:
    *
            * Adapter: allows cooperation between objects with different interfaces.
            * Bridge: allows a large class or group of similar classes to be split into two separate hierarchies, 
                      an abstraction and an implementation, which can then be developed independently of each other.
            * Composite: Allows you to compose objects into tree-like structures and work on these structures as 
                         if they were individual objects.
            * Decorator: allows adding functionalities to objects by placing these objects inside other special 
                         encapsulating objects that contain these functionalities.
            * Facade: Provides a simplified interface to a library, framework or any other complex set of classes.
                      In short, it's a simple-looking interface that is doing everything behind the scenes.
            * Flyweight: It is a kind of balance that allows to keep more objects within an available amount of ram memory, 
                         sharing the common parts, the state between them and keeping the information of each object.
                         In short, it allows several objects to coexist in RAM and share common data.
            
            * Proxy: allows to substitute or mark a position for another object:
                         A proxy controls access to the original object, allowing something to be done before or after 
                         the request reaches the original object.
                         In short, it allows you to substitute or mark positions between objects so that they interact with each other.
            

*/


//             -------------------- SINGLETON --------------------------  


public sealed class Singleton //sealed sealed does not allow us to make another instance of this class.
{

}

