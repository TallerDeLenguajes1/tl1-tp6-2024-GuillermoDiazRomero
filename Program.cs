// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);


int i = 0;
string s;
bool result;
do {
    s = Console.ReadLine();  
    result = int.TryParse(s, out i); //i now = 108

} while(!result || i<=10);

Console.WriteLine($"Numero ingresado {i}");


int acumulador = 0;
int aux;
int ingresado = i;
while(i>0){
    aux = i%10;
    i = i/10;
    acumulador = acumulador * 10 + aux;
}


Console.WriteLine($"El numero ingresado es {ingresado} y el numero invertido es {acumulador}");