# Lab05 Zoo OOP
To understand the 4 pillars of Object Oriented Programming which are,
* Inheritance - The ability to recieve behaviors from base classes 
* Polymorphism - The ability to change behaviors.
* Abstraction - The ability to be not fully defined until the first concrete class
* Encapulation - Access Modifiers - public, private, protected, internal and internal protected

## Examples
* Inheritance is shown in CaveAnimal to Bats. CaveAnimals overrides the virtual method defined in the Animal class. That overridden method is now inherited onto Bats. Therefore, all bats are sleep during the day unless overridden again in derived classes
* Polymorphims is shown in going from JungleAnimal to Toucan. Here multiple methods and properties are being overridden that were inherited from its base class. For example, the abstract method EatsWhat is defined to return "fruits". The virtual method Has Cereal is changed to return from "none" to "Froooty Loops".
* Abstraction is shown in the Animal class. Here we have three abstract methods/properties that are not fully defined. These abstract methods/properties can only live in the abstract class. To handle any abstraction.
* Encapulation is shown through all classes being public so that they can be accessed by each other and by Unit Testing to see if our inheritance, overirding works as intended.


## What you need
* Install the latest Visual Studio 2017
* Have Windows OS on your device

## How to Open App
* Fork the Lab05-Zoo-OOP repo from [my GitHub Page](https://github.com/Calamario)
* Git Clone the repo onto your local device
* Open .sln file with Visual Studio
* Click on the green arrow to start
* Navigate through the menu on your console

## Other Details
* This also includes unit testing
* To access, open the UnitTest1.cs in VS2017
* Run the prewritten tests or create your own.

## What it looks like
![unit-testing](/Zoo_OOP/Lab05_Zoo_OOP/assets/zoo_and_oop_is_ZOOP.PNG)
