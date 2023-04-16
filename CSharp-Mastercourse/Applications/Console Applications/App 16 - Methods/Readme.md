# Methods in C#

A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method. The Main method is the entry point for every C# application and it's called by the common language runtime (CLR) when the program is started.

Method C# Docs - [Microsoft Docs Methods](https://learn.microsoft.com/en-us/dotnet/csharp/methods)

## Method signatures
Methods are declared in a class, record, or struct by specifying:

- An optional access level, such as **public** or **private**. The default is **private**.
- Optional modifiers such as **abstract** or **sealed**.
- The return **value**, or **void** if the method has none.
- The method **name**.
- Any method parameters. Method parameters are enclosed in *parentheses* and are separated by *commas*. *Empty parentheses indicate that the method requires no parameters*.

These parts together form the method signature.

To see code source click here. 