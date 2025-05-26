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

//Ejercicio 02
bool continuar=true;

while(continuar)
{
  Console.WriteLine("CALCULADORA 1");
  Console.Write("Seleccione una opción");
  Console.WriteLine("1. Sumar");
  Console.WriteLine("2. Restar");
  Console.WriteLine("3. Multiplicar");
  Console.WriteLine("4. Dividir");
  
  string? opcion = Console.ReadLine();

  Console.Write("Ingrese el primer número: ");
  string? numero1 = Console.ReadLine();
  Console.Write("Ingrese el segundo número: ");
  string? numero2 = Console.ReadLine();

  if (double.TryParse(numero1, out double num1) && double.TryParse(numero2, out double num2))
  {
    switch (opcion)
    {
      case "1":
      Console.WriteLine("Resultado: " + (num1 + num2));
      break;
      case "2":
      Console.WriteLine("Resultado: " + (num1 - num2));
      break;
      case "3":
      Console.WriteLine("Resultado: " + (num1 * num2));
      break;
      case "4":
      if (num2 != 0)
        Console.WriteLine("Resultado: " + (num1 / num2));
      else
        Console.WriteLine("Error: No se puede dividir por cero.");
        break;
        default:
        Console.WriteLine("Opción inválida.");
        break;
    }
            
  }else
  {
    Console.WriteLine("Error: Ingrese números válidos.");
  }

  Console.Write("\n¿Desea realizar otra operación? (s/n): ");
  string? respuesta = Console.ReadLine();
  if (respuesta?.ToLower() != "s")
  {
    continuar = false;
  }
}

//Ejercicio 03

Console.WriteLine("--- CALCULADORA 2 ---");
Console.Write("Ingrese un número: ");
string? numero3 = Console.ReadLine();

if (double.TryParse(numero3, out double numero4))
{
  Console.WriteLine("Valor absoluto: " + Math.Abs(numero4));
  Console.WriteLine("Cuadrado: " + Math.Pow(numero4, 2));
  if (numero >= 0)
    Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero4));
  else
    Console.WriteLine("No se puede calcular para nimeros negativos");
    Console.WriteLine("Seno: " + Math.Sin(numero4));
    Console.WriteLine("Coseno: " + Math.Cos(numero4));
    Console.WriteLine("Parte entera: " + Math.Truncate(numero4));
}
else
{
  Console.WriteLine("Error: No ingresó un número válido.");
  
}

Console.Write("\nIngrese el primer número para comparar: ");
string? numero5 = Console.ReadLine();
Console.Write("Ingrese el segundo número para comparar: ");
string? numero6 = Console.ReadLine();

if (double.TryParse(numero5, out double n1) && double.TryParse(numero6, out double n2))
{
  Console.WriteLine("Máximo: " + Math.Max(n1, n2));
  Console.WriteLine("Mínimo: " + Math.Min(n1, n2));
}
else
{
  Console.WriteLine("Uno o ambos valores no son válidos.");
}
 
