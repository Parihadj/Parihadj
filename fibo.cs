var fibonacciNumbers = new List<int> {1,1};

while (fibonacciNumbers.Count < 20)
{ var a = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var b = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(a+b);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);


/*

1
1
2
3
5
8
13
21
34
55
89
144
233
377
610
987
1597
2584
4181
6765


*/
