# Learning C# - Data Types

Now we have the basics we can start to layer in some more ideas.

Let’s continue to update our “HelloWorld” application.

In workshop 2 we learned how to add two variables together with the following code.

``` cs --region Workshop4_Sample1 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

What if my variables only have numbers in it? What happens when we add them together?

Run the following code and see what happens

``` cs --region Workshop4_Sample2 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

Even if variables only contain numbers, the program will still treat them like text and not numbers. So if we add the above two strings we will get the output of `"73"` and not `"10"` like we may want.

This is a really good time to return to types.

## Data Types

A data type or type is a particular kind of data item, as defined by the values it can take, the programming language used, or the operations that can be performed on it. What does that mean exactly?

### Data type: “strings”

Up until now, we have been working with data type known as a _string_. It treats all of its values as text. A string looks like the following examples:

```cs
var someText = "This is a string of text";
string moreText = "More text";
```

You may have noticed that on the second _variable_, `string` was used instead of `var` in front of the variable name. This is known as _explicitly_ typing a variable. When we use `var` the computer program makes a guess at what the type will be based on the value set. More on this later.

We know that we can add two strings together like so:

```cs
var combinedText = someText + moreText;
```

The above will combine our two sentences, but you have to add the space yourself if it’s needed like so:

```cs
var combinedText = someText + " " + moreText;
```

Now, earlier we saw that adding two numbers together, didn’t work as we might expect.

```cs
var someText = "27";
var moreText = "13";
```

Even if your string only contains numbers, the datatype will still be a string. So if we add the above two strings we will get the output of "2713" and not "40". We can try and turn these strings into a different data type, such as an _int_ which is an integer data type, where integer is the formal word to describe a whole number.

### Data type: “ints”

An _int_ data type can only have values that are integers or whole numbers.

```cs
var someInt = 27;
var anotherInt = 13;
```

Note that we no longer surround our numbers with ". This means that the computer will infer the data type is an int. If we wanted to be explicit we could use the following, telling the computer that we want the variable to be an int:

```cs
int someInt = 27;
int anotherInt = 13;
```

If we were to add these two variables together like so:

``` cs --region Workshop4_Sample3 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

Run this code and the expected result of 40 is shown

So how do we make a _string_ into an _int_?

We can try to _parse_ it using the following code.

``` cs --region Workshop4_Sample4 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

This is using the `TryParse` method provided for us in `System`, the library of methods that Microsoft provide us within the SDK. There are a few extra things about this method like out but don’t worry about that now.

If `someText` can be turned into an integer, the method will assign the variable `myInt` with the value, in this case, `27`.

If the method can’t change the string into an integer, it will set the value of `myInt` as `0`. So in the code below, `"twenty-seven"` cannot be made into an integer, so `myInt` will be given a value of `0`. This is because an integer always needs to have a value, it cannot be null, and `0` is the default value.

``` cs --region Workshop4_Sample5 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

There are many different data types available, you can even create your own. But don’t worry if this seems strange or complicated. As we start to use these types, it will start to make more sense.

If you are happy with the above concepts, you can try and combine the above code with an if/else statement, which we learned about in workshop 3.

Start with the code below and see what you can do. Change the value of `"Put something here"` and try different values.

``` cs --region Workshop4_Sample6 --source-file .\Workshop4.cs --project .\TryDotNet.CodingClinic.csproj
```

You may have noticed the line above starting with two slashes. This is a comment. Comments allow you to make notes in your code that is ignored by the computer. There are two types:

Single line comments (denoted with //)

```cs
// example single line comment
```

Multiline comments (prefixed with /* and suffixed with */)

```cs
/* This is a multi line comment
 it can span over a number of lines.
 Anything between the prefix and the suffix.
*/

/************************
* Sometimes people add an asterix on each line
* to make things stand out (e.g. headings etc..).
* These are also just multi line comments.
************************/
```
