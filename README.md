# CSharpLessons2017

The Solution is DotNetCore2 so you’ll need to install DotNetCore2 from https://www.microsoft.com/net/core#macos

Work through the lessons in this order:

1. Abstraction
2. Encapsulation
3. Inheritance
4. Polymorphism

Just switch branch when you want to move to the new lesson. There’s notes and tasks as well as the solution code.

Basically everything for the OO stuff is all in Program.cs .I have added classes into this file so that everything is easy to explain over hangouts but if you think thats bad just fork this repo and create seperate files for each class.

1. Abstraction

“Through the process of abstraction, a programmer hides all but the relevant data about an object in order to reduce complexity and increase efficiency.
In the same way that abstraction sometimes works in art, the object that remains is a representation of the original, with unwanted detail omitted.
The resulting object itself can be referred to as an abstraction, meaning a named entity made up of selected attributes and behavior specific to a particular 
usage of the originating entity.”

Source:http://whatis.techtarget.com/definition/abstraction

Task 1. Lets create an Employee class that abstracts an employee

Task 2. Lets adds a few attribues Name, Age, DOB, PayRate

Task 3. Lets add a method to calculatePay by passing it the hours worked

2. Encapsulation

“In general, encapsulation is one of the four fundamentals of OOP(object-oriented programming). Encapsulation refers to the bundling of data with the methods that
operate on that data.[5] Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct
ccess to them. Publicly accessible methods are generally provided in the class (so-called getters and setters) to access the values, and other client classes 
all these methods to retrieve and modify the values within the object.”

Source: https://en.wikipedia.org/wiki/Encapsulation_(computer_programming)

Task 4. Lets change the way we access each of our attributes and convert them to properties

Task 5. Lets change Age so that it returns an age based on the date of birth - we should also make sure that we cannot just change the Age whenever we want


3. Inheritance

“In object-oriented programming, inheritance enables new objects to take on the properties of existing objects. A class that is used as the basis for inheritance is called a superclass or base class. A class that inherits from a superclass is called a subclass or derived class.”

Source:http://www.adobe.com/devnet/actionscript/learning/oop-concepts/inheritance.html

Task 6. Lets add a class for Manger that inherits from Employee

Now we need to chat about Virtual methods - a Virtual method is a method that "can" be overridden

Task 7. Lets ensure that the CalculatePay method returns double the pervious calulated aount


4. Polymorphism

The word ‘polymorphism’ literally means ‘a state of having many shapes’ or ‘the capacity to take on different forms’.  When applied to object oriented programming languages like Java, it describes a language’s ability to process objects
 of various types and classes through a single, uniform interface. 

Source: https://www.sitepoint.com/quick-guide-to-polymorphism-in-java/ 

Task 8 We want to support a new type of employee - a junior who gets paid 0.8 of a salary. Lets add another class that inherits from employee

Task 9 So lets add some code to ask the user to pick the type of employee and their Name and based on that selection calculate the salary
In this task lets assume the company has a base pay of $50 an hour. We wont worry about DOB and Age in this example but we can leave the implementation
for a later date.


