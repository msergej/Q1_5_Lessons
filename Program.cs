         // Выполнение задааний на лекциях
         // Лекции, урок 3 (24.09.22)

for(int i=2; i<10; i++) 
    for(int j=2; j<10; j++)
        Console.WriteLine($"{i} * {j} = {i * j}");


//    string res = Method_04(3, "A");
//    Console.WriteLine(res);
//    Console.WriteLine("Hello, World! #2");



static string Method_04(int count, string c) {
    int i = 0;
    string result = string.Empty;
    while (i < count) {
        result = result + c;
        i++;
    }
    return result;
}      

