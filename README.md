# 011 Single Responsibility Principle

## Lecture

[![# Single Responsibility Principle](https://img.youtube.com/vi/krAyfDEWXrE/0.jpg)](https://www.youtube.com/watch?v=krAyfDEWXrE)

## Instructions

In this assignment you refactor HomeEnergyApi to apply the Single Responsibility Principle to your code.

In `HomeEnergyApi/Models/HomeRepository.cs`...

- Create a new class `HomeRepository` containing...
  - A public list of `Home`s titled `HomesList`
  - A constructor, which initializes `HomesList`
  - A Save() method...
    - Should take one `Home` as an argument.
    - Should add the passed `Home` to `HomesList`.
    - Should return the passed `Home`.
  - An Update() method...
    - Should take one `Home`, and one `int` as arguments.
    - Should update the home in `HomesList` at the index that is passed, to be the home that is passed.
    - Should return the passed `Home`.
  - A FindAll() method...
    - Should return `HomesList`
  - A FindById() method...
    - Should take one `int` as an argument.
    - Should return the home in `HomesList` at the index of the passed `int`.
  - A RemoveById() method...
    - Should take one `int` as an argument.
    - Should remove the home in `HomesList` at the index that is passed.
    - Should return the passed `Home`.

In `HomeEnergyApi/Controllers/HomesController.cs`...

- Should remove the definition for the property `homesList`.
- Should create a definition for a new property of type `HomeRepository`.
- Should refactor ALL existing methods to work in the same way as before, utilizing your new `HomeRepository` typed variable in line with the Single Responsibility Principle.

Additional Information:

- Since the last lesson, `Home` has lost it's `Id` property. From now on, when you see a saved home's "id" refrenced, that will refer to it's index within `HomeRepository.HomesList`.
  - You can still refrence `Home`s type definition in `HomeEnergyApi/Models/HomeModel.cs`

## Building toward CSTA Standards:

- Decompose problems into smaller components through systematic analysis, using constructs such as procedures, modules, and/or objects. (3A-AP-17) https://www.csteachers.org/page/standards
- Create artifacts by using procedures within a program, combinations of data and procedures, or independent but interrelated programs. (3A-AP-18) https://www.csteachers.org/page/standards
- Construct solutions to problems using student-created components, such as procedures, modules and/or objects. (3B-AP-14) https://www.csteachers.org/page/standards
- Compare levels of abstraction and interactions between application software, system software, and hardware layers. (3A-CS-02) https://www.csteachers.org/page/standards
- Evaluate the tradeoffs in how data elements are organized and where data is stored. (3A-DA-10) https://www.csteachers.org/page/standards

## Resources

- https://en.wikipedia.org/wiki/Single-responsibility_principle
- https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
- https://en.wikipedia.org/wiki/Encapsulation_(computer_programming)

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
