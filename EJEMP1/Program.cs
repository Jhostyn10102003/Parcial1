using System.ComponentModel;

Console.Write("Ingrese un número entero positivo (o 0 para salir): ");
string num1 = Console.ReadLine();

while (num1 != "0")// el while evalua que no sea igual a 0
{
    if (int.TryParse(num1, out int numero) && numero >= 0)
    //Verificamos si el numero ingresado es entero postivo si es menor o igual que 0 se repite
    //en el caso de que sea 0 se cumple el while
    {
        Console.WriteLine("\nMenú:");//El menú que permite ver al usuario que desea operar
        Console.WriteLine("1. Calcular el factorial del número.");
        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
        Console.WriteLine("3. Salir del programa.");

        Console.Write("Seleccione una opción (1, 2, o 3): ");
        string opcionInput = Console.ReadLine();// se almacena la opcion

        if (int.TryParse(opcionInput, out int opcion) && opcion >= 1 && opcion <= 3)//Evaluamos la opcion que el usuario elija
            // debe de ser entre 1 y 3
        {
            if (opcion == 1)
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)//operamos el factorial haciendo uso del for 
                    //for permite repetir la multiplicación por el mismo mientras no sea mayor que el numero dado
                    //Para poder evaluarse entre si mismo hasta llegar a el valor ingresadp
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
            else if (opcion == 2)
            {
                Double raizCuadrada = Math.Sqrt(numero);//math.sqrt permite sacar la raíz cuadrada de un numero
                Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");
            }
            else
            {
                Console.WriteLine("Saliendo del programa. ¡Hasta luego!");// si no se preciona 1 o 2 pues salir del progra
                                                                          //pero ya sabemos que no puede ser mayor a 3 por lo tanto 3
                                                                          //3 igual a salir del programa
                break;
            }
        }
        else
        {
            Console.WriteLine("Opción no válida. Intente de nuevo.");//si ingresamos otro valor que no sea ni 1 ni 2 ni 3
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número entero positivo o 0 para salir.");//Si no se ingresa un valor valido
    }

    Console.Write("\nIngrese un número entero positivo (o 0 para salir): "); // se repite la acción hasta escribir 3 o 0 depediendo del mensaje en pantalla
    num1 = Console.ReadLine();
}