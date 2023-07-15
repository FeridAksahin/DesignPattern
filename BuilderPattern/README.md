
# Builder Design Pattern
A builder design pattern is a in which we separate the construction of complex objects from their representations. 
## Overview
We provides a step-by-step approach to construct objects by using a builder object. The builder object encapsulates the construction logic and we allows the make of different variations of the same object.
## Benefits
- **Flexibility**: If we use builders provide a flexible way to construct objects by allowing step-by-step customization of the object’s attributes. Different builder configurations can be used to make variations of the same object.
- **Encapsulation**: The construction logic is encapsulated within the builder object, separating it from the client code. This promotes clean code architecture and enhances code maintainability.
- **Readability**: If we use builder pattern, we improve code readability by clearly defining the steps required to construct an object.
- **Reusability**: Builders can be reused to make similar objects with different configurations. This reduces code duplication and promotes code reusability. 

## Drawbacks

- **Increased Complexity**: Implementing the Builder pattern can introduce additional complexity to the codebase, especially when dealing with complex object structures or numerous configuration options.
- **Overhead**: The Builder pattern requires the creation of additional classes (builders) and the definition of multiple steps in the construction process. This can result in increased overhead, especially for simple objects with straightforward creation requirements.
- **Dependency on Concrete Builders**: The client code depends on concrete builder implementations, which can lead to tight coupling. Changing the builder implementation may require modifications to the client code.

## Modular Example 

This project the implementation of a Chat Bot Service using the Builder design pattern. In the context of a Chat Bot Service, the Builder pattern is used to make chat bot objects with different configurations and features. We can think of it as a module that receives and returns chat bot commands on the API project side. 

### Usage 
1. Make a concrete builder class that extends BotBuilder and implements the construction methods.
2. In the builder class, implement the BuildBotCommands and BuildBotDescription methods to set the bot's commands and description, respectively.
3. Make a director class, such as BotRouter, to guide the construction process. The director must takes a builder object and invokes the builder's methods to set the bot's commands and description.
4. In the client code, make an instance of the builder class and pass it to the director class.
5. Use the director to construct the chat bot object.
6. Access the constructed chat bot object and retrieve the bot's commands or perform other operations as needed.


### Example Usage
In the provided example, the program make a financial chat bot using the FinancialBot builder class. It sets the request command as NotaryPriceInfo. We directs with BotRouter the construction process, and the constructed chat bot object's commands are printed to the console.

   ```
   BotBuilder builder = new FinancialBot(RequestCommand.NotaryPriceInfo);
   BotRouter router = new BotRouter();
   router.BotDirector(builder);
   Console.WriteLine(builder.Bot.BuildBotCommands);
  ```
## Getting Started

To run the mini project, follow these steps:
1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Explore the code and the usage of the Builder pattern for chat bot service.