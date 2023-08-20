
# Prototype Design Pattern
The Prototype design pattern is based on the concept of creating a new object by copying an existing instance. This pattern proves beneficial, especially when the instantiation of an object is complex or resource-intensive, as obtaining a copy can be more efficient than constructing a new instance from scratch. In essence, with the Prototype design pattern we facilitates the replication of objects, we allowing new instances to be produced from a prototype in a passive manner.
## Overview
The Prototype design pattern is predicated on producing new objects by cloning an existing object. In the presented example, clones of the "Admin" and its associated "AdminFeature" objects are created using both shallow and deep copying methods.
## Benefits
- **Performance**: If the initial creation of an object is time-consuming or costly, the cloning approach may be a more efficient solution.
- **Flexibility**: A clone of an existing object can be customized and modified according to specific needs.
- **Independence**: With the cloning process, we do not change the state or values of the original object (if we are deep copying) and ensure that the prototype remains untouched.

## Drawbacks

- **Complexity in Deep Copying**: If the object contains references to other objects (like lists or arrays), these references need to be correctly copied, complicating the deep copying process.
- **Maintainability Issues**: If the object being cloned evolves continuously, the cloning methods might need updates to accommodate these changes.
- **Privacy Concerns**: Care should be taken in cases where copying certain attributes might introduce security risks.

## Modular Example 

In this project, the Prototype design pattern is applied to exemplify the cloning of existing objects for generating new instances. The context is set within a forum system's membership segment, focusing specifically on administrative roles. Given that multiple administrators are anticipated, with object cloning we offers an efficient solution. With the ***GetAllAdmin RESTful service***, we show examples of both ***shallow and deep cloning techniques*** to show different cloning methodologies.

### Usage 
The Prototype design pattern as showcased here is particularly useful for creating new objects based on existing ones without the overhead of instantiating them from scratch. We use this model especially when initializing an object is resource intensive or when system performance is a priority. Here's how to use the provided design:
1. **Cloning with Prototype:**
--- For each object that needs to be cloned, we inherit from the abstract class Prototype.
--- In the abstract ***Clone*** method, we ensure that each concrete object has its own cloning mechanism.
2. **Shallow Copy:**
--- Use the Clone method on any object that implements the Prototype. This is we call the ***MemberwiseClone*** method where we provide a shallow copy of the object. 
--- It is important to note that the reference types of shallow copies will be the same as the original. Meaning, changes to nested objects (like ***AdminFeature*** in our case) in the cloned object will reflect on the original and vice versa.
3. **Deep Copy:**
--- For a completely independent copy where shared references aren't an issue, a deep copy is necessary.
--- This is achieved through ***copy constructors*** we wrote method (like the one in ***AdminPrototype*** and ***AdmicFeaturePrototype*** classes). By calling these constructors we wrote, we ensure the independence of the cloned object, and we make new instances of nested objects.
4. **Utilizing in a Service:**
--- In ***AdminController*** we provide an endpoint GetAllAdmin that demonstrates the use of both shallow and deep cloning methods. By invoking this ***endpoint***, one can observe the different cloning methods in action and their respective outcomes.


### Example Usage
Utilizing the Prototype pattern in the context of the forum system's admin roles is straightforward. Here's a step-by-step demonstration:
1. **Initialization:**
Start by maked an AdminPrototype instance with specific features.
```
var originalAdmin = new AdminPrototype("Test", Enum.AdminLevel.Senior.ToString(), new AdmicFeaturePrototype(true, false));
```
2. **Shallow Cloning:**
Make a shallow clone of the ***originalAdmin***. In this, we copy the underlying data but share the references for the nested objects.
```
AdminPrototype clonedAdminShallow = (AdminPrototype)originalAdmin.Clone();
clonedAdminShallow.AdminName = "Test2";
clonedAdminShallow.AdminFeature.IsHaveDeleteTopic = true;
```
Note: Any changes to the ***AdminFeature*** of ***clonedAdminShallow*** would also reflect on the originalAdmin due to shared references in shallow cloning.
3. **Deep Cloning:**
For a completely standalone clone, use the deep copy approach.
```
AdminPrototype clonedAdminDeep = new AdminPrototype(clonedAdminShallow);
clonedAdminDeep.AdminFeature.IsHaveUpdateMember = false; 
clonedAdminDeep.AdminFeature.IsHaveDeleteTopic = false;
```
With our changes to the ***AdminFeature*** of ***clonedAdminDeep***, we do not affect other instances and provide full independence from the original.

Info : Because in ***deep copy***, a different place is referenced in the ***heap region in memory***. Whereas, in ***shallow copy***, the same place as the copied object is ***pointed***.
4. **Service Endpoint:**
You can observe the effect of these cloning techniques using the GetAllAdmin endpoint in the AdminController. When this endpoint is called, we return a list of managers where we can see the differences between shallow and deep cloned objects:
```
GET /api/Admin/GetAllAdmin
```

***Example Result***
<img src="result.jpg">

## Getting Started

To run the mini project, follow these steps:
1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Explore the code and the usage of the Prototype pattern for Forum Member System.