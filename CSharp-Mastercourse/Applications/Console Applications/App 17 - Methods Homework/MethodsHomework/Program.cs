using MethodsHomework;

Greetings.Welcome();
(string firstName, string lastName) = User.GetNames();
Greetings.GreetUser(firstName, lastName);