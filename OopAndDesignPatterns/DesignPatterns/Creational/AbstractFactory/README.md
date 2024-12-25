# Abstract Factory Pattern

This project demonstrates the **Abstract Factory Pattern** through an example of international factories for creating language and capital city objects for different countries. Inspired by the [YouTube tutorial](https://www.youtube.com/watch?v=snVb75D_msk).

## Table of Contents

- [Overview](#overview)
- [UML Diagram](#uml-diagram)
- [Features](#features)
- [Structure](#structure)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Overview

The **Abstract Factory Pattern** is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is particularly useful when a system needs to support multiple families of products.

In this project, the abstract factory is used to create objects related to languages and capital cities for different countries (e.g., Spain and England).

## UML Diagram

The following UML diagram illustrates the design structure:

![UML Diagram - AbstractFactory](UML%20Diagram%20-%20AbstractFactory.png)

- `IInternationalFactory` defines the interface for creating families of objects (Language and CapitalCity).
- `SpainFactory` and `EnglishFactory` are concrete factories implementing `IInternationalFactory`.
- `ILanguage` and `ICapitalCity` define interfaces for Language and CapitalCity products.
- Concrete products (`English`, `Spanish`, `London`, and `Madrid`) implement these interfaces.

## Features

- Demonstrates the Abstract Factory Pattern.
- Supports creating objects for different "families" (e.g., Spain and England).
- Encapsulates object creation logic for language and capital city objects.

## Structure

### Interfaces

1. **IInternationalFactory**:
   - `CreateLanguage() : ILanguage`
   - `CreateCapital() : ICapitalCity`

2. **ILanguage**:
   - `Greet() : void`

3. **ICapitalCity**:
   - `GetPopulation() : int`
   - `ListTopAttractions() : List<string>`

### Concrete Factories

1. **SpainFactory**:
   - Creates Spanish language and Madrid as the capital city.

2. **EnglishFactory**:
   - Creates English language and London as the capital city.

### Concrete Products

1. **Languages**:
   - `English`
   - `Spanish`

2. **Capital Cities**:
   - `London`
   - `Madrid`


### Output

```plaintext
Factory: Spain
Language: Hola (Spanish)
Capital: Madrid, Population: 3,300,000
Top Attractions: Royal Palace, Prado Museum

Factory: England
Language: Hello (English)
Capital: London, Population: 9,000,000
Top Attractions: Big Ben, Tower of London
```

