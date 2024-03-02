

Console.Write("Ingrese el primer número entero: ");
if (!int.TryParse(Console.ReadLine(), out int num1))//Verificamos si el numero ingresado es valido
                                                    //Usamos ! porque vamos a almacenar el dato para usarlo despues
{
    Console.WriteLine("El valor ingresado no es un numero entero");//en el caso no sea pues mostramos el mensaje al usuario
    return;
}

Console.Write("Ingrese el segundo número entero: ");
if (!int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("El valor ingresado no es un numero entero");
    return;
}

// Solicitar al usuario un operador matemático
Console.Write("Ingrese un operador matemático (+, -, *, /): ");
char operador = Console.ReadKey().KeyChar;

// Realizar la operación según el operador ingresado
double resultado = 0;
switch (operador)//switch para que sea mas facil los casos
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 != 0)//Evitamos que el usuario intente dividir entre 0
        {
            resultado = (double)num1 / num2;
        }
        else
        {
            Console.WriteLine("\nNo se puede dividir entre cero.");
            return;
        }
        break;
    default:
        Console.WriteLine("\nOperador invalido.");
        return;
}

Console.WriteLine($"\nEl resultado de {num1} {operador} {num2} es: {resultado}");