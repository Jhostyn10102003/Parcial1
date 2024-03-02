
Random random = new Random();//Clase para generar un numero al azar de acuerdo al tiempo del sistema
int numSecr = random.Next(1, 100);//Esta clase genera en el rango de 1 y 100

int intentoUsuario;

do// Do while, para poder realizar la busqueda del numero de forma mas eficiente mejor pedimos al usuario el valor
  //para despues poder operar y llegar al resultado
{
    Console.Write("Ingrese un número entre 1 y 100: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out intentoUsuario))//comprobamos que sea entero el numero a operar
    {
        if (intentoUsuario == numSecr)//nos ayudará a encontrar el valor que estamos buscando
        {
            Console.WriteLine($"El numero: ({numSecr}) es correcto");
        }
        else if (intentoUsuario < numSecr)
        {
            Console.WriteLine("El número secreto es mayor. Intenta nuevamente.");
        }
        else
        {
            Console.WriteLine("El número secreto es menor. Intenta nuevamente.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");//en el caso de que no sea un valor entero
    }

} while (intentoUsuario != numSecr);