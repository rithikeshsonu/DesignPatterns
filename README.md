# Design Patterns

This repository includes the **Object-Oriented Principles**, **SOLID Design Principles**, and **Design Patterns**.

---

## Object-Oriented Principles
1. **Inheritance**  
2. **Abstraction**  
3. **Polymorphism**  

---

## LINQ (Language Integrated Query)

LINQ (Language Integrated Query) is a powerful feature in C# that allows querying collections in a SQL-like manner.  
It provides a consistent model for working with data across various kinds of data sources and formats (arrays, lists, XML, databases, etc.).

This project includes LINQ examples that demonstrate:

- Filtering elements using `Where`
- Projecting values using `Select`
- Finding elements using `First`, `Any`, `All`
- Aggregating data using `Sum`, `Count`, `Min`, `Max`
- Sorting with `OrderBy`, `OrderByDescending`
- Working with strings and performing grouping
- Eliminating duplicates using `Distinct`

📁 **Folder Path**:  
`OopAndDesignPatterns/OOPPrinciples/LINQ/LINQ/Program.cs`

🔗 **[Click here to view the LINQ code file](https://github.com/rithikeshsonu/DesignPatterns/blob/main/OopAndDesignPatterns/OOPPrinciples/LINQ/LINQ/Program.cs)**

---

## SOLID Principles
1. **Single Responsibility Principle**  
   A class should have one and only one reason to change.  
2. **Open-Closed Principle**  
   Classes should be open for extension but closed for modification.  
3. **Liskov Substitution Principle**  
   Objects of a superclass should be replaceable with objects of a subclass without altering the correctness of the program.  
4. **Interface Segregation Principle**  
   A client should not be forced to implement interfaces it does not use.  
5. **Dependency Inversion Principle**  
   High-level modules should not depend on low-level modules. Both should depend on abstractions.


---

## Design Patterns

### Overview
Design Patterns, as introduced in the famous **Gang of Four (GoF)** book, are categorized into three types:  
1. **Behavioral Patterns**  
2. **Structural Patterns**  
3. **Creational Patterns**  

---

### **Behavioral Patterns**  
**Mnemonic:** MSS IC TOM CVI  

- **M**ediator Pattern  
- **S**trategy Pattern  
- **S**tate Pattern  
- **I**terator Pattern  
- **C**hain of Responsibility Pattern  
- **T**emplate Method Pattern  
- **O**bserver Pattern  
- **M**emento Pattern  
- **C**ommand Pattern  
- **V**isitor Pattern  
- **I**nterpreter Pattern  

#### Observer Pattern
The **Observer Pattern** involves an object, known as the _subject_, maintaining a list of its dependent objects, known as _observers_, and notifying them automatically of any state changes.

---

### **Structural Patterns**  
**Mnemonic:** CAB PF FD  

- **C**omposite Pattern  
- **A**dapter Pattern  
- **B**ridge Pattern  
- **P**roxy Pattern  
- **F**acade Pattern  
- **F**lyweight Pattern  
- **D**ecorator Pattern  

---

### **Creational Patterns**  
**Mnemonic:** PS FAB  

- **P**rototype Pattern  
- **S**ingleton Pattern  
- **F**actory Method Pattern  
- [**A**bstract Factory Pattern](https://github.com/rithikeshsonu/DesignPatterns/tree/main/OopAndDesignPatterns/DesignPatterns/Creational/AbstractFactory)
- **B**uilder Pattern  
