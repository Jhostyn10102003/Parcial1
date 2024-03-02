Console.Write("Ingrese un número para obtener la tabla de multiplicar: ");

if (int.TryParse(Console.ReadLine(), out int numero))//Comprobamos si el numero es un entero
{
    Console.WriteLine($"Tabla de multiplicar del {numero}:");

    for (int i = 1; i <= 10; i++)//Va a sumar 1 al iterador para poder llegar a 10 imprimiendo la multiplicación de cada uno
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("El valor ingresado no es entero");
}