// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

//Ejercicio 1

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

//Ejercicio 2

//Declaración de variables
int seguir;
int eleccion;
int numero1;
int numero2;

Console.WriteLine("Calculadora con 2 numeros");
do{
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Resta");
    Console.WriteLine("3.Division");
    Console.WriteLine("4.Multiplicacion");
    eleccion = NumerosPositivos(1);
    numero1 = NumerosPositivos(0);
    numero2 = NumerosPositivos(0);
    switch (eleccion)
    {
        case 1:
            Console.WriteLine($"La suma es: {numero1 + numero2}");
            break;
        case 2:
            Console.WriteLine($"La resta es: {numero1 - numero2}");
            break;
        case 3:
            Console.WriteLine($"La division es: {numero1 / numero2}");
            break;
        case 4:
            Console.WriteLine($"La multiplicacion es: {numero1 * numero2}");
            break;

    }
    Console.WriteLine("Desea seguir haciendo operaciones ingrese un 1");
    seguir = Convert.ToInt32(Console.ReadLine());
} while (seguir == 1);



static int NumerosPositivos(int op)
{
    if (op == 1)
    {
        int nume = 0;
        string cade;
        bool resultado;
        do
        {
            cade = Console.ReadLine();
            resultado = int.TryParse(cade, out nume);

        } while (!resultado || nume < 1 || nume > 4);
        return nume;
    }
    else
    {
        int nume = 0;
        string cade;
        bool resultado;
        do
        {
            cade = Console.ReadLine();
            resultado = int.TryParse(cade, out nume);

        } while (!resultado || nume < 1);
        return nume;
    }
}