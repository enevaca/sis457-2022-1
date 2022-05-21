// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DemoConsola;

bool esVerificado = false;
int entero = 5;
decimal dec = 5.5M;
float f = 6.4f;
string cadena0 = "Hola Mundo";
DateTime fecha = new DateTime(2022, 05, 01); //DateTime.Now;
var dinamico = 1.0f;

const float PI = 3.1416f;
const string MATERIA_INFORMATICA = "SIS457";

//Console.WriteLine("Introduzca un mensaje de entrada y luego un entero: ");
//string mensajeEntrada = Console.ReadLine();
//int enteroEntrada = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("El mensaje de entrada fue: " + mensajeEntrada + ", " + enteroEntrada);
Console.WriteLine(fecha.ToString());

// Cadenas
string cadena = "  Hola Mundo...!!! ";
string concatenar1 = "SIS457 " + cadena;
string concatenar2 = $"SIS457 {cadena}";
string reemplazo = concatenar2.Replace("SIS457", "Fundamentos de la Programación");
string sinEspaciosExtremos = $"SIS457{cadena.Trim()}";
string subCadena = cadena.Trim().Substring(0, 4);
string mayusculas = cadena.ToUpper();
string minusculas = cadena.ToLower();
Console.WriteLine(minusculas);

// Estructuras de Control
if (cadena.Contains("Hola Mundo")) 
{
    Console.WriteLine("Es igual");
}
else if (cadena.Trim() == "Hola Mundo...!!!") 
{
    Console.WriteLine("Es igual (else if)");
}
else
{
    Console.WriteLine("No es igual");
}

int contador = 1;
while (contador <= 10) 
{
    Console.WriteLine($"Contador: {contador}");
    if (contador % 3 == 0) break;
    contador++; //contador += 1; //contador = contador + 1;
}

do {
    Console.WriteLine($"do while - Contador: {contador}");
    contador++;
} while (contador <= 10);

for (int i = 1; i <= 100; i++) {
    Console.WriteLine($"for - i: {i}");
    if ((i * 2) % 5 == 0) break;
}

// Métodos o funciones
void saludar(string nombre) {
    Console.WriteLine($"Hola {nombre}");
}

string saludar2(string nombre)
{
    return $"Hola2 {nombre}";
}

saludar("Juan");
Console.WriteLine(saludar2("Maria"));

var listaEnteros = new List<int>() { 1, 2, 3 };
var listaCadenas = new List<string> { "A", "B", "C" };
listaCadenas.Add("D");
listaCadenas.Add("E");
listaCadenas.Remove("B");
//Console.WriteLine(listaCadenas[1]);
for (int i = 0; i < listaCadenas.Count; i++) {
    Console.WriteLine("for: " + listaCadenas[i]);
}
foreach (var elemento in listaCadenas) {
    Console.WriteLine("foreach: " + elemento);
}


// POO
Persona persona = new Persona();
persona.cedulaIdentidad = "123456";
persona.nombre = "Noel";
persona.apellido = "Vaca";
persona.fechaNacimiento = DateTime.Parse("2000-12-25");
persona.saludar();

var personas = new List<Persona>();
for (int i = 0; i < 50; i++) { 
    var p = new Persona();
    p.cedulaIdentidad = Console.ReadLine();
    personas.Add(p);
}

foreach (var p in personas) {
    p.saludar();
}

Estudiante estudiante = new Estudiante();
estudiante.cedulaIdentidad = "123456";
estudiante.nombre = "Noel";
estudiante.apellido = "Vaca";
estudiante.fechaNacimiento = DateTime.Parse("2000-12-25");
estudiante.carnetUniversitario = "35-11111";
estudiante.saludar();
