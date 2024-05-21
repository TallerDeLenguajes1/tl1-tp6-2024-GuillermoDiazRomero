// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);


int i = 0;
string s;
bool result;
do
{
    s = Console.ReadLine();
    result = int.TryParse(s, out i); //i now = 108

} while (!result || i <= 10);

Console.WriteLine($"Numero ingresado {i}");


int acumulador = 0;
int aux;
int ingresado = i;
while (i > 0)
{
    aux = i % 10;
    i = i / 10;
    acumulador = acumulador * 10 + aux;
}


Console.WriteLine($"El numero ingresado es {ingresado} y el numero invertido es {acumulador}");



//Ejercicio 3
Console.WriteLine("Calculadora con 1 numero");
Console.WriteLine("1.Valor Absoluto");
Console.WriteLine("2.Elevar al Cuadrado");
Console.WriteLine("3.Raiz Cuadrada");
Console.WriteLine("4.Sen(x)");
Console.WriteLine("5.Cos(x)");
Console.WriteLine("6.Parte entera");

Console.WriteLine("$$$Ingrese su opcion$$$");
int eleccion = 0;
string texto;
bool resultado;
do
{
    texto = Console.ReadLine();
    resultado = int.TryParse(texto, out eleccion);

} while (!resultado || eleccion < 1 || eleccion > 6);

Console.WriteLine("Ingrese su numero");
float numero = 0f;
do
{
    texto = Console.ReadLine();
    resultado = float.TryParse(texto, out numero);

} while (!resultado);

switch (eleccion)
{
    case 1:
        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        break;
    case 2:
        Console.WriteLine($"Elevado al cuadrado: {numero * numero}");
        break;
    case 3:
        if (numero >= 0){
            Console.WriteLine($"Raiz Cuadrada: {Math.Sqrt(numero)}");
        }
        else{
            Console.WriteLine("No es posible sacar la raiz cuadrada de un numero negativo");
        }
        break;
    case 4:
        Console.WriteLine($"Sen({numero}) {Math.Sin(numero)}");
        break;
    case 5:
        Console.WriteLine($"Cos({numero}) {Math.Cos(numero)}");
        break;
    case 6:
        Console.WriteLine($"Parte entera {(int)numero}");
        break;
}

Console.WriteLine("Ingrese dos numero para saber el maximo y el minimo");
int numero1;
int numero2;
do
{
    texto = Console.ReadLine();
    resultado = int.TryParse(texto, out numero1);

} while (!resultado || numero1 < 1);

do
{
    texto = Console.ReadLine();
    resultado = int.TryParse(texto, out numero2);

} while (!resultado || numero2 < 1);


if (numero1 > numero2){
    Console.WriteLine($"El numero 1 ({numero1}) es mayor que el numero 2 ({numero2})");
}
else if (numero1 < numero2){
    Console.WriteLine($"El numero 1 ({numero1}) es menor que el numero 2 ({numero2})");
}
else{
    Console.WriteLine($"El numero 1 ({numero1}) es igual que el numero 2 ({numero2})");
}
