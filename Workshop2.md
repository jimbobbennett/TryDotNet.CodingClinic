# Learning C# - Hello World

## A first C# program

When you create a new C# console application, you get two files - a `.csproj` file containing details about the program, and `Program.cs`, a code file containing the initial console application.

Open the `Program.cs` file; this is the entry point of our application and it will look like this:

```cs
using System;

namespace HelloWorld
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Hello World!");
       }
   }
}
```

It has a `Program` class with a `Main` method inside it. Don’t worry about what a class or a method is as yet, we’ll get to that later. The important line is `Console.WriteLine("Hello World!");`.

Run this line in the box below to see what happens.

``` cs --region Workshop2_Sample1 --source-file .\Workshop2.cs --project .\TryDotNet.CodingClinic.csproj
```

The `Console.WriteLine("Hello World!");` is what printed “Hello World!” to the output. Change the contents of the quote marks in the code below to say `"Hello, C#."` and run the code.

``` cs --region Workshop2_Sample2 --source-file .\Workshop2.cs --project .\TryDotNet.CodingClinic.csproj
```

If you are stuck, the code to do this is:

```cs
Console.WriteLine("Hello C#.");
```

## What’s going on?

.NET comes with a whole load of ready-made code for us to use in the form of libraries. See the using System at the top of the `Program.cs` file? That’s us saying that we want to use the System library, which is provided by Microsoft. Inside these libraries, we have methods or functions that we can use or call. `Console.WriteLine` is one of these methods.

Have a look at the following:

``` cs --region Workshop2_Sample3 --source-file .\Workshop2.cs --project .\TryDotNet.CodingClinic.csproj
```

Now we have created two variables called hello and name and given them the values of `"Hello"` and `"your name"`, respectively. We have then added our two variables together using the `+` sign and put them in the `Console.WriteLine`. The above will combine our two sentences and output them to the console. But if you run this you may see that there is no space between our words where they join. You have to add the space yourself if it’s needed. Try editing the code below to put in a space.

``` cs --region Workshop2_Sample4 --source-file .\Workshop2.cs --project .\TryDotNet.CodingClinic.csproj
```

Here is one way to do it, but see if you can think of others.

```cs
Console.WriteLine(hello + " " + name);
```

## Exploring the console APIs further

Have a play with the `Console` commands in the box below. If you delete then retype the `.` after `Console`, it will load the intellisense window showing you all the things you can do with the console. Perhaps have a play with `Console.Write()` instead of `Console.WriteLine()` and see what happens.

``` cs --region Workshop2_Sample4 --source-file .\Workshop2.cs --project .\TryDotNet.CodingClinic.csproj
```

<hr>

When you are ready, move on to the [next workshop](./Workshop3.md).
