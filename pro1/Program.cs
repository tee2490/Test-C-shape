//การรับข้อมูล
string name;
int num1, num2,ans;

Console.Write("Enter your name: ");
name = Console.ReadLine(); //รับจากคีย์บอร์ด string

Console.Write("Enter first number: ");
num1 = int.Parse(Console.ReadLine()); //รับจากคีย์บอร์ด int

Console.Write("Enter second number: ");
num2 = int.Parse(Console.ReadLine());

ans = num1 + num2;

Console.WriteLine($"\nNumbers entered: {num1} and {num2}");
Console.WriteLine($"Sum: {ans}");
