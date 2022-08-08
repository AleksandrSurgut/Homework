Console.WriteLine("Введите любое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB){
    Console.WriteLine("Эти числа равные друг другу");
}
else{
    if(numberA > numberB){
    Console.WriteLine($"Максимальное число- {numberA}!");
    Console.WriteLine($"Минимальое число- {numberB}!");
    }
else{
    Console.WriteLine($"Максимальное число- {numberB}!");
    Console.WriteLine($"Минимальое число- {numberA}!");   
}    
}