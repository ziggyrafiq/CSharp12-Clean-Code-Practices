using CleanCodePractices.After;

Console.WriteLine("Hello, from Ziggy Rafiq!");


//Before
var numbers = new List<int> { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}


//After
List<int>  numbersList = [1, 2, 3, 4, 5];



foreach (var numberList in numbersList)
{
    Console.WriteLine(numberList);
}

 
 

//After
int numberZ= 5;
int result = Shape.Square(numberZ);

// Display the result
Console.WriteLine($"The square of {numberZ} is {result}");
