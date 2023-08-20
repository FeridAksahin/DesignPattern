
# Factory Design Pattern
When we use Factory design pattern we provides an interface for making objects in a superclass, but we allows subclasses to alter the type of objects that will be maked. With the Factory method we returns (new instances of) objects of a different class/type.
## Overview
This pattern includes a function that takes an identifier as a parameter and what type of object to return. It returns these created objects. The idea is to use a factory method that takes the instance type as input and creates instances, thus providing a simple interface to the client and effectively decoupling the client code from the concrete types.
## Benefits
- **Decoupling**: The client code does not need to be communicate of the concrete classes, it only interacts with the interface.
- **Flexibility**: New classes can be added with ease without modifying the existing client code.

## Drawbacks

- **Complexity**: The code can become more complicated since you are introducing a lot of new subclasses which implement the factory method.
- **Maintainability**: More classes and files need to be managed.

## Modular Example 

In the provided code, we demonstrate a factory pattern implementation for creating different types of storage services - ObjectStorage, BlockStorage, and FileStorage. Each service type has a different implementation of the SaveFile method.

### Usage 
1. The ***StorageService*** abstract class we declares the factory method that the client code uses to get the instance of the concrete classes.
2. Concrete classes ***ObjectStorage***, ***BlockStorage***, and ***FileStorage*** we implement the ***StorageService*** abstract class and we override the ***SaveFile*** method.
3. ***StorageFactory*** class contains a ***GetStorageService*** method that we makes and returns instances of the concrete classes based on the ***ServiceType*** enum passed as parameter.
4. In the ***Program*** class, we make an instance of the ***StorageFactory*** class, call the ***GetStorageService*** method to get a storage service, and then call the ***SaveFile*** method of the returned storage service.


### Example Usage
To use this code, you would need to make an instance of the StorageFactory class, then call the GetStorageService method with the appropriate ServiceType as parameter. The returned object would be of the type StorageService, and you could call the SaveFile method on it. 

   ```
var storageFactory = new StorageFactory();
var storageService = storageFactory.GetStorageService(ServiceType.FileStorage);
Console.WriteLine(storageService.SaveFile("example.txt"));
  ```

This way, we separate the decision-making code (which type of storage service to instantiate) from the client code. Thus it easier to add new types of storage services.
## Getting Started

To run the mini project, follow these steps:
1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Explore the code and the usage of the Factory pattern for Storage Cloud Service.