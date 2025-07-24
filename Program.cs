// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

using System.Diagnostics;

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

//Ejercicio 2
int num1,num2,num3;

Console.WriteLine("Que operacion que desea realizar?:" + Environment.NewLine + "1. Suma" + Environment.NewLine + "2. Resta" + Environment.NewLine + "3. Multiplicacion" + Environment.NewLine + "4. Division");
string preNum3 = Console.ReadLine();
if (int.TryParse(preNum3, out num3))
{
    while (num3 != 0)
    {
        Console.WriteLine("Ingrese el primer numero:");
        string preNum1 = Console.ReadLine();
        if (int.TryParse(preNum1, out num1))
        {
            Console.WriteLine("Ingrese el segundo numero:");
            string preNum2 = Console.ReadLine();
            if (int.TryParse(preNum2, out num2))
            {
                switch (num3)
                {
                    case 1:
                        int suma;
                        suma = num1 + num2; 
                        Console.WriteLine("El resultado de la suma es:" + suma);
                        break;
                    case 2:
                        int resta;
                        resta = num1 - num2;
                        Console.WriteLine("El resultado de la resta es:" + resta);
                        break;
                    case 3:
                        int multiplicacion;
                        multiplicacion = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es:" + multiplicacion);
                        break;
                    case 4:
                        int division;
                        if (num1 > num2)
                        {
                            division = num1 / num2;
                        }
                        else{
                            division = num2 / num1;
                        }
                        Console.WriteLine("El resultado de la division es:" + division);
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no corresponde a alguna operacion valida.");
                        break;
                }
            }
        }
        Console.WriteLine("Si desea realizar otra operacion ingrese el numero correspondiente");
        num1 = 0;
        num2 = 0;
        preNum3 = Console.ReadLine();
        int.TryParse(preNum3, out num3);
    }
}

//Ejercicio 3
Console.WriteLine("Ingrese un numero:");
string preNum4 = Console.ReadLine();
double num4,vAbs,Cuad,ParteEnt;
double radianes,Seno,Coseno,Raiz;
bool resultado2 = double.TryParse(preNum4, out num4);

if (resultado2)
{
    vAbs = Math.Abs(num4);
    Cuad = num4 * num4;
    if (num4 >= 0)
    {
        Raiz = Math.Sqrt(num4);
        Console.WriteLine("Raiz del numero ingresado: " + Raiz + Environment.NewLine);
    }
    else
    {
        Console.WriteLine("No se puede calcular la raiz de un numero negativo");
    }

    radianes = (num4 * 3.14) / 180;
    Seno = Math.Sin(radianes);
    Coseno = Math.Cos(radianes);
    ParteEnt = Math.Truncate(num4);
    Console.WriteLine("Valor absoluto del numero ingresado: " + vAbs + Environment.NewLine + "Cuadrado del numero: " + Cuad + Environment.NewLine +
 "Seno del numero: " + Seno + Environment.NewLine + "Coseno del numero: " + Coseno + Environment.NewLine + "Parte entera del numero: " + ParteEnt);
}


