string valor;
int convertidor;

Console.WriteLine("Bienvenido al calculador de numeros pares o impares");
Console.WriteLine("Ingrese el numero que desea calcular");
valor= Console.ReadLine();

convertidor= Convert.ToInt32(valor);

if(convertidor% 2 == 0)
{
    Console.WriteLine("El numero que eligio es par");
}
else
{
    Console.WriteLine("El numero que eligio es impar");
}