using DemoConsolaAvanzado;
using DemoLibrary;

// Biblioteca de Clases
//var cal = new Calculadora();
Console.WriteLine("Suma: " + Calculadora.sumar(5, 9));
Console.WriteLine("Resta: " + Calculadora.restar(5, 9));
//Console.WriteLine("Multipliación: " + Calculadora.multipliacion(5, 9));
Console.WriteLine("División: " + Calculadora.dividir(5, 9));


// Delegado
Func<int, int, int> multipliacion = (v1, v2) => v1 * v2;
var resultado = multipliacion(5, 8);
Console.WriteLine(resultado);

Predicate<int> mayorDeEdad = e => e >= 18;
bool esMayorDeEdad = mayorDeEdad(10);
Console.WriteLine(esMayorDeEdad);


// Ejemplo Delegado
EjemploDelegado.Reverse rev = EjemploDelegado.ReverseString;
Console.WriteLine(rev("hola mundo"));


// Interfaces
var carro = new Carro();
carro.Acelerar(120);
carro.Frenar();


// Clases Abstractas
//var pieza = new Pieza(); // Error
var cuadrado = new Cuadrado(5);
Console.WriteLine($"Area: {cuadrado.Area()}, Perimetro: {cuadrado.Perimetro()}");

// Manejo de Excepciones
int a, b;
try
{
    Console.WriteLine("Intruzca el valor de a:");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Intruzca el valor de b:");
    b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"La división de {a} y {b} es {a / b}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al dividir: {ex.Message}");
}
finally {
    a = 0;
    b = 0;
}

// Programación asíncrona
//TestAsyncAwaitMethods();
//Console.WriteLine("Press any key to exit...");
//Console.ReadLine();


async static void TestAsyncAwaitMethods()
{
    await LongRunningMethod();
}

static async Task<int> LongRunningMethod()
{
    Console.WriteLine("Starting Long Running method...");
    await Task.Delay(5000);
    Console.WriteLine("End Long Running method...");
    return 1;
}

// Inmutabilidad
class Age 
{
    readonly int year;
    Age(int year) { 
        this.year = year;
    }

    void changeYear() 
    {
        // this.year = 1999;
    }
}
