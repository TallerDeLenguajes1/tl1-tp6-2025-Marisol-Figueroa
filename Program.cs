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

//Ejercicio 04

// 1. Ingreso y longitud de la cadena
Console.Write("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine($"La longitud de la cadena es: {cadena1.Length}");

// 2. Concatenación con segunda cadena
Console.Write("Ingrese otra cadena: ");
string cadena2 = Console.ReadLine();
string concatenada = string.Concat(cadena1, " ", cadena2);
Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// 3. Extraer una subcadena
Console.Write("Ingrese la posición que desea extraer una subcadena: ", cadena1.Length - 1);
int inicio = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de caracteres a extraer: ");
int cantidad = int.Parse(Console.ReadLine());
string subcadena = cadena1.Substring(inicio, cantidad);
Console.WriteLine($"Subcadena extraída: {subcadena}");

// 4. Calculadora con mensaje interpolado
Console.Write("Ingrese el primer número: ");
double numUno = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
double numDos = double.Parse(Console.ReadLine());
double suma = numUno + numDos;
Console.WriteLine($"La suma de {numUno} y de {numDos} es igual a: {suma.ToString()}");

// 5. Recorrer la cadena con foreach
Console.WriteLine("Caracteres en la primera cadena:");
foreach (char c in cadena1)
{
  Console.WriteLine(c);
}

// 6. Buscar ocurrencia de una palabra
Console.Write("Ingrese una palabra para buscar en la primera cadena: ");
string palabra = Console.ReadLine();
bool contiene = cadena1.Contains(palabra);
Console.WriteLine(contiene ? $"La palabra '{palabra}' fue encontrada." : $"La palabra '{palabra}' no está en la cadena.");

// 7. Convertir a mayúsculas y luego a minúsculas
Console.WriteLine($"En mayúsculas: {cadena1.ToUpper()}");
Console.WriteLine($"En minúsculas: {cadena1.ToLower()}");

// 8. Split con separador personalizado
Console.Write("Ingrese una cadena separada por ';': ");
string separada = Console.ReadLine();
string[] partes = separada.Split(';');
Console.WriteLine("Partes de la cadena:");
foreach (string parte in partes)
{
  Console.WriteLine(parte);
}

// 9. Resolver una ecuación simple tipo "582+2"
Console.Write("Ingrese una ecuación simple: ");
string ecuacion = Console.ReadLine();

// Buscar el operador y separar los operandos
char[] operadores = { '+', '-', '*', '/' };
char operador = ' ';
foreach (char op in operadores)
{
  if (ecuacion.Contains(op))
  {
   operador = op;
   break;
  }
}

if (operador != ' ')
{
string[] operandos = ecuacion.Split(operador);
if (operandos.Length == 2 && double.TryParse(operandos[0], out double op1) && double.TryParse(operandos[1], out double op2))
{
  double resultado = 0;
  switch (operador)
  {
    case '+': resultado = op1 + op2; break;
    case '-': resultado = op1 - op2; break;
    case '*': resultado = op1 * op2; break;
    case '/': resultado = op2 != 0 ? op1 / op2 : double.NaN; break;
  }
  Console.WriteLine($"El resultado de {ecuacion} es: {resultado}");
}
else
{
  Console.WriteLine("Formato de ecuación no válido.");
}
}   
