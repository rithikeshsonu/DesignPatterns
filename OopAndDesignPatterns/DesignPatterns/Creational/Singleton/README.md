# Singleton Pattern - AppSettings Example

## Introduction

The **Singleton Pattern** is a design pattern that ensures a class has only one instance and provides a global point of access to that instance. In this example, the `AppSettings` class demonstrates how the Singleton pattern can be used to manage application settings throughout an application.

The Singleton pattern is typically used in scenarios where a single shared resource (like configuration settings) is required. This implementation ensures that only one instance of `AppSettings` is used, providing a consistent set of application settings.

## Key Features

- **Single Instance**: Only one instance of the `AppSettings` class is created, regardless of how many times it is accessed.
- **Global Access**: The instance of `AppSettings` can be accessed globally throughout the application.
- **Lazy Initialization**: The instance of the `AppSettings` class is created only when it is needed for the first time.

## Problem Statement

In many applications, certain resources (such as configuration settings, loggers, or caches) should be shared throughout the application. However, creating multiple instances of such resources can lead to inconsistent data and unnecessary resource usage.

The Singleton pattern solves this by ensuring that only one instance of a class is created, no matter how many times it is referenced throughout the application.

## How It Works

1. **Private Constructor**: The `AppSettings` class has a private constructor to prevent external instantiation. This ensures that the class can only be instantiated from within itself.
2. **Static Instance**: A static variable `_instance` holds the single instance of the `AppSettings` class.
3. **GetInstance Method**: A static `GetInstance()` method is provided to access the single instance. If the instance does not exist, it is created.
4. **Settings Management**: The class uses a dictionary to store key-value pairs representing the application's settings, which can be set or retrieved through public methods.

## Code Structure

### 1. **AppSettings Class**

The `AppSettings` class is the core of the Singleton pattern in this example. It stores and manages application settings as key-value pairs using a dictionary. The class ensures that only one instance of the `AppSettings` object is created by using the private constructor and providing a static method (`GetInstance()`) for accessing the instance.

### 2. **Test Class**

The `Test` class demonstrates the usage of the Singleton instance. It calls the `GetInstance()` method to retrieve the `AppSettings` instance and prints the value of a setting to verify the functionality.

### 3. **Program Class**

The `Program.cs` file is the entry point of the application. It shows how to set and retrieve application settings using the `AppSettings` singleton instance. The `Test.Run()` method is called to ensure the settings are correctly retrieved.

## Example Usage

1. **Setting Values**: You can set key-value pairs in the `AppSettings` class using the `Set()` method. For example, you can store the application name or creator.
2. **Getting Values**: The `Get()` method allows retrieving the value associated with a given key. If the key doesn’t exist, it returns `null`.

