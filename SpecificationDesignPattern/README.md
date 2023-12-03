
# Specification Design Pattern

The Specification pattern a flexible way to evaluate objects against a specific set of criteria or rules.

## Overview

With the specification design pattern, the criteria are encapsulated into separate specification objects. These specification objects we define rules or conditions that an object must meet. By combining multiple specifications using logical operators (such as AND, OR, NOT), complex composite specifications can be make.

## Benefits

- **Flexibility**: The Specification pattern we provide dynamic and flexible rule evaluation by encapsulating criteria in separate specification objects. This allows for easy modification and composition of rules to meet different requirements.

- **Separation of Concerns**: We support a clean and modular codebase by separating the logic of evaluating specifications and rules from the objects themselves. Objects can focus on their primary responsibilities, while specifications handle the rule evaluation.

- **Reusability**: Specifications can be reused across different objects and scenarios. Once defined, specifications can be applied to multiple objects to evaluate their compliance with the defined rules.

## Drawbacks

- **Increased Complexity**: The Specification pattern introduces additional complexity, especially when dealing with complex composite specifications. Managing and combining multiple specifications may require careful consideration and additional code.

- **Performance Considerations**: Evaluating composite specifications or complex rules can impact performance, particularly when dealing with a large number of objects or complex criteria. Care should be taken to optimize the evaluation process if performance is a concern.

## Modular Example 

This project includes an example of the Specification design pattern implemented in a hypothetical e-commerce scenario. The goal the focus is on filtering products on an e-commerce website based on certain criteria, and the Specification design model is used to perform this filtering.

### Scenario

The scenario involves filtering products based on their condition (new, used, renewed) and popularity (trend, best seller, new arrival, recommended).  

### Usage 
Below are some sample scenarios for its use in the main method in the `Program.cs` file.
1. Filtering for New Products:
   ```
   WriteLine("New Products:");
   foreach (var product in filter.Filter(GetDummyProductData(), new ConditionSpecification(Condition.New)))
   {
       WriteLine($" - {product.Name}");
   }
2. Filtering for Best Seller And Used Products
   ```
    WriteLine("Best Seller And Used Products:");
    foreach (var product in filter.Filter(GetDummyProductData(), new AndSpecification<Product>(new PopularitySpecification(Popularity.BestSeller),
    new ConditionSpecification(Condition.Used))))
    {
       WriteLine($" - {product.Name}");
    }
## Getting Started

To run the mini project, follow these steps:
1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Explore the code and the usage of the Specification pattern for product filtering. 
