Console.WriteLine("Введите любое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите любое число ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите любое число ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if(numberB > max){
    max = numberB;
}
if(numberC > max){
    max = numberC;
}
Console.WriteLine(max);