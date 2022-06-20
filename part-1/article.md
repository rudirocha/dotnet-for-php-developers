Learning new technologies these days is becoming cheap and easy. Every day I see people of all ages, finding some content on the internet and quickly starting to build very interesting applications. Just like those “free-time-hobby-oriented engineers”, full-time engineers get comfortable with a couple of languages and frameworks and get specialized in them (even with the risk of turning to be framework experts rather than software experts). What happens then when we see other people getting specialized in other languages/frameworks and we start to wonder “should I…”? Or even realize the language/framework we know isn’t really the best for that project?
The more senior you are, the less time and patience you have to go through this. This might eventually happen because your daytime job is paying you to do so or just because you want to have some different training. Either way, in the end, we will end up applying the mindset of our favorite framework to the content we are learning (and sometimes this can go right).

In my previous working place, PHP was the dominant language. After supporting the transition from Silex to Symfony, looking forward to payments-oriented applications, PHP wasn’t our language of choice (dynamic casting, the memory usage per request, request performance, etc) compared with other languages such as Java or C#. Also, managing teams, we always need to think “how will the teams react if we ask them to develop in a different language?” and it’s not an easy conversation. Having a few conversations and “how-to’s” later, we were able to ship a few APIs to production using .Net Core, and the “should I…” feeling of engineers from other teams started to grow. So why not show everyone that, despite a few different things (language and framework topics), using .Net Core is quite easy for software engineers using Symfony?

------

## What is .Net Core
Literally copying and pasting it’s “Free. Cross-platform. Open-source.
A developer platform for building all your apps.” (https://dotnet.microsoft.com/). With this framework, you can build desktop, web, mobile, cloud, and machine learning applications. This means that with .Net Core you can do the same thing as with Symfony using C# instead of PHP.
**Also, C# is not PHP…**
As a (PHP) software engineer, reading C# code can feel a bit odd. If you look to a PHP class, remove the dollar signs ($), and replace the arrows (->) with dots, it will start to become really similar to the C# code.

## First things first — Differences between PHP and C#

### Code execution
This is probably the biggest difference between both languages.
PHP is interpreted: it means that when you write a *.**php** file, the PHP service can grab that file, “read” it, and execute the code.
C# is compiled: it means that you can’t just execute the code written on a *.**cs** file. C# is a high-level language (like PHP) that is then compiled into a CLR (common language runtime) and finally turned into native code during runtime.

### Variables
Another difference: Loosely types language vs strongly typed language. PHP doesn’t require defining the variable’s type (even with recent upgrades allowing types to be defined) while using C#, there’s always a variable type.

#### PHP Variables example
```php
<?php
    // this is an integer
    $numberOfHours = 12;

    // these are strings
    $firstName = 'John';
    $lastName = "Doe";
    $singleLetter = 'P';

    // these are booleans
    $truthyValue = true;
    $falseyValue = false;

    //this is a float / double
    $tirePressure = 45.4;

    //this is an Array of things
    $listOfThings = ['John', 'Jane', 'Bob', ];

    // this is the usage of a class
    $person = new Person('John', 'Doe', 'Eyq#4dsSd2234');

```

#### C# Variables equivalent

```c#
    // This is an integer
    int numberOfHours = 12;

    // This is a string - Notice usage of Quotes 
    string firstName = "John";

    // This is a Char - Notice usage of single Quotes
    Char firstLetter = 'C';

    // These are booleans
    bool truthy = true;
    bool falsey = false;

    // This is a Float
    float tirePressure = 45.4f;

    // This is a double
    double decimalVal = 23.7;

    // These are arrays of things
    // Notice that the array type and size needs to be defined
    int[] agesList = new int[5]; // array of 5 integers
    bool[] flagsList = new bool[3] { true, false, true };

    // this is the usage of a class
    User theUser = new Person("John", "Doe", "eR4jADEWer2");

```

The first difference we can notice is the missing “$” characters. Instead of using it to declare the variable, C# requires the variable type and then the name. Some nice to see differences:

- There is a difference using integers, floats, and decimal (double) values.
- Single or double quotation marks are used for different variable types. In C#, a Char is different from a String.
- Arrays of data are not dynamic: there’s a fixed size and type.

C# version 3 introduced an approach of dynamic type assignment but differs from PHP when it comes to changing its own value for a different type. Consider the following example

```php
<?php
    // PHP allows reassigning the variable with a different type
    $value = 2;
    $value = "This is now a string";
```

```c#
  // C# equivalent
   var value = 2;
    // the row below will trigger an exception
    value = "This is now a string";
```

Using var key word C# will, at compile-time, create the new variable in memory as the type of the first assignment. If the program tries to assign a new value, from a different type, an exception will be thrown like:

> : error CS0029: Cannot implicitly convert type ‘string’ to ‘int’

### IF statements and conditions

Both PHP and C# are very similar in many aspects. On the following examples, the only difference is in fact the way we use variables:

#### PHP example

```php
<?php
    if (1 <= 3)
    {
        // execute if condition was met
    }
    else
    {
        // otherwise...
    }

    $result = 1 <= 3 ? 'Option1' : 'Option2';
```

#### C# equivalent

```c#
    if (1 <= 3)
    {
        // execute if condition was met
    }
    else
    {
        // otherwise...
    }
    var result = 1 <= 3 ? "Option1" : "Option2";
```

### Loops

This is another topic where PHP and C# are very similar.

#### PHP examples

```php
    // While
    while($flag == true) {
        // do something
    }

    // do..while
    do {

    } while($flag == true);


    // For
    for ($i = 0; $i <= 10; $i++) {
        // do Something
    }

    // Foreach 
    $names = array("John", "Jane", "Bob");

    foreach ($names as $name) {
    // do something with $name
    }

```

#### C# equivalent

```c#
    // While
    var flag = true;
    while(flag == true)
    {
        // do something
        flag = false;
    }

    // do..while
    do
    {
        // do something
    } while (flag == true);

    // for
    for(int i = 0; i<= 10; i++)
    {
        // do something
    }

    // foreach
    string[] names = {"John", "Jane", "Bob"};
    
    foreach(string name in names)
    {
        // do something with name
    }
```

### Object-Oriented Programming

Both languages can be used in an OOP way. So, how can we create the same class in both languages?

#### PHP example

```php
<?php
    namespace App;
    abstract class User {

        protected function disableUser()
        {
            // do something
        }
    }

    interface IPerson {
        public function doSomething();
    }

    class Person extends User implements IPerson {

        public $firstName;
        public $lastName;

        protected $createdAt;

        private $token;

        public function __construct($theFirstName, $theLastName, $token)
        {
            $this->firstName = $theFirstName;
            $this->lastName = $theLastName;
            $this->createdAt = date('Y-m-d H:i:s');
            $this->token = $token;
        }

        public function getToken() {
            return $this->token;
        }

        public function doSomething()
        {
            // something
        }
    }

```

#### c# equivalent

```c#
using System;

namespace dotNetForPHPDevelopers
{
    abstract class User
    {
        protected void disableUser()
        {
            // do something
        }
    }

    interface IPerson
    {
        public void doSomething();
    }

    class Person : User, IPerson
    {
        public string FirstName;
        public string LastName;

        protected DateTime createdAt;

        private string token;

        public Person()
        {
             createdAt = DateTime.Now;
        }

        public Person(string theFirstName, string theLastName)
        {
            FirstName = theFirstName;
            LastName = theLastName;
        }

        public Person(string theFirstName, string theLastName, string theToken)
        {
            FirstName = theFirstName;
            LastName = theLastName;
            createdAt = DateTime.Now;
            token = theToken;
        }

        public string GetToken()
        {
            return token;
        }

        public void doSomething()
        {
            // do something
        }
    }
}

```

Producing PHP or C# code is really similar. At this level, just a few things change, such as extending classes or implementing interfaces where the notation is a bit different.

However, C# can even give more flexibility. Notice the code regarding constructors: **C# supports multiple constructors.**

Still, around OOP, we can’t forget about namespaces. If PHP allows defining the class namespace by using the `namespace … ;` at the top of the PHP file, C# makes it possibly using:

```c#
namespace dotNetForPHPDeveloper
{
    class Person {
    ...    
    }
}
```
------

## Conclusion

This is it for the first part! With this article, we can see the main similarities between both languages. The next step is to show how can we build a similar project between .Net Core and Symfony Framework! In the meantime, check this article’s code on github