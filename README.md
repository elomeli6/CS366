# CS 366 Homework 3

"As a computer science student, I want to show that I can work in the professional Visual Studio environment using C#."

## Primary Objectives:

- Complete the C# Codecademy tutorial and read Chapter 5 before starting this lab.
- Learn and practice C#.
- Write a moderately complex C# program.
- Continue to hone Git skills with branching.

[Git Branching Guide](https://git-scm.com/book/en/v2/Git-Branching-Branches-in-a-Nutshell)

## Overall Requirements:

- Code must run to be graded.
- Write a web application using the information and framework from Chapter 3 and Chapter 5.
- Minimum requirements:
  - 2 `cshtml` pages.
  - 2 controllers.
  - 2 models.
- Process input for each model (Hint: Chapter 3 covers forms for user input).
- Use the MVC framework with a correct separation of concerns.
- Include the following C# features:
  - Namespaces.
  - Variable naming conventions.
  - String Interpolation.
  - Expression Bodied Method.
  - Lambda Expressions.
  - Auto-Implemented Property.
  - Interface.
  - Generic Collection.
  - LINQ Query with your collection.
  - Extension Methods.

[Resource for C#:](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Application Behavior:

- Takes input from the user and handles incorrect data gracefully.
- Responsive and produces useful output.
- Use Git feature branches for all work, merging into `main` only when finished.

## Setup Instructions:

1. Ensure Visual Studio Code is installed with .NET 7.0 SDK.
2. Create the project:
   ```bash
   dotnet new globaljson --sdk-version 7.0.100 --output HW3Solution/HW3Project
   dotnet new mvc --no-https --output HW3Solution/HW3Project --framework net7.0
   dotnet new sln -o HW3Solution
   dotnet sln HW3Solution add HW3Solution/HW3Project
