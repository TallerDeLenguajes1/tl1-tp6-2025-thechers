// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:" +a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 1
Console.WriteLine("Ingrese un numero:");
string entrada = Console.ReadLine();
int num; 
bool resultado = int.TryParse(entrada, out num);

if (resultado && num > 0)
{
    Console.WriteLine("Es un numero");
    int invertido = 0;
    while (num > 0)
    {
        int digito = num % 10;
        invertido = (invertido * 10) + digito;
        num /= 10;
    }
    Console.WriteLine(invertido);

}
else
{
    Console.WriteLine("No es un numero");
}


