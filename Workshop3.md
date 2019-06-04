# Learning C# - Comparisons

A lot about what computer programs do is based on decision making. Computers can’t make those decisions so we need a way to program this and we can use something called a *conditional statement*.

There are several different types of *conditional statement* but before we look at those, we just need to understand comparisons first.

## Comparisons

We can compare the value of a variable with another variable or value. To do this we use a double equals sign, as shown below. Run the code below and have a look at the result.

``` cs --region Workshop3_Sample1 --source-file .\Workshop3.cs --project .\TryDotNet.CodingClinic.csproj
```

In this code, we are doing a check to see if the value of myColourVariable has the value of “red”. In this case, the value is “blue” so the program will write false to the console.

We can also compare two variables, as shown below:

``` cs --region Workshop3_Sample2 --source-file .\Workshop3.cs --project .\TryDotNet.CodingClinic.csproj
```

It’s important to note that “Red” would not be equal to “red” as comparisons are case sensitive. Try changing the code to make one variable different case to the other and run the code again.

Comparisons are really key for understanding how conditional statements work. Let’s look at the most common conditional statement, the if/else statement.

## if/else statements

An *if/else statement* is a very powerful concept in programming. It allows the computer to perform different actions depending on certain conditions.

Let’s add an if/else statement by doing something based on the value of a variable. Edit the `"add a color here"` below to be either `"green"` or something else and run the code.

``` cs --region Workshop3_Sample3 --source-file .\Workshop3.cs --project .\TryDotNet.CodingClinic.csproj
```

Try a few different values and see what happens. In the code, if our use wrote anything other than `"green"` the program will write whatever is in the `else` part of the statement.

We can build on our statement, by adding in an `else if` like so:

``` cs --region Workshop3_Sample4 --source-file .\Workshop3.cs --project .\TryDotNet.CodingClinic.csproj
```

There are several other types of conditional statement. If you feel like it, you could research some of the others and have a play with them.

<hr>

When you are ready, move on to the [next workshop](./Workshop3.md).
