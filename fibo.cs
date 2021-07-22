var fibonacciNumbers = new List<int> {1,1};

while (fibonacciNumbers.Count < 20)
{ var a = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var b = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(a+b);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);
