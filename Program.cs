// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 01

Console.Write("Ingrese un numero:");
string? texto=Console.ReadLine();

if(int.TryParse(texto,out int numero))
{
    if(numero > 0)
    {
     Console.WriteLine("El numero ingresado es:"+numero);
    }
    else
    {
      Console.WriteLine("El numero ingresado debe ser mayor que cero");
    }

}
else
{
   Console.WriteLine("El numero no es un numero valido");
}

