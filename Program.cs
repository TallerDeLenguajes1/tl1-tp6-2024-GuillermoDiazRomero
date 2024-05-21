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


//Ejercicio 4
Console.WriteLine("Ingresar el cadena");
string cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine($"El cadena es {cadena} con una longitud de {longitud}");
Console.WriteLine("Ingresar la segunda cadena");
string cadena2 = Console.ReadLine();
string conca = string.Concat(cadena, " ", cadena2);
Console.WriteLine("Concatenado es: "+ conca);
Console.WriteLine("Ingresar su primer numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresar su segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sumando {num1.ToString()} + {num1.ToString()}  " + (num1 + num2).ToString());
Console.WriteLine("Ingresar una cadena para usar el foreach");
string cadena3 = Console.ReadLine();
string[] palabras = cadena3.Split(' ');
foreach (string buscar in palabras){
    Console.WriteLine("Palabra encontrada: " + buscar);
}
Console.WriteLine("Ingresar el cadena para buscar la ocurrencia");
string cadena4 = Console.ReadLine();
string buscada = "hola";
int ocurrencia = 0;
string[] palabras2 = cadena4.Split(' ');
foreach (string buscar in palabras2){
    if (buscar == buscada){
        ocurrencia++;
    }
}
Console.WriteLine($"La palabra buscada fue {buscada} y su ocurrencua fue de {ocurrencia}"); 
Console.WriteLine("Ingresar cadena a convertir");
string cadena = Console.ReadLine();
Console.WriteLine($"La cadena original -{cadena} La cadena en minusculas -{cadena.ToLower()}- La cadena en mayusculas -{cadena.ToUpper()}");