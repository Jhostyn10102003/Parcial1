// Propiedad Length: Longitud de la cadena.
string ejemploLength = "Hola mundo!";
int longitud = ejemploLength.Length;
Console.WriteLine($"Longitud de la cadena: {longitud}");

// Propiedad IsReadOnly: Indica si la cadena es de solo lectura. No puede ser aplicable directamente a cadenas en c#

// Propiedad Chars: Obtiene un array de caracteres que componen la cadena.
string ejemploChars = "123";
char[] caracteres = ejemploChars.ToCharArray();//ToCharArray() es un método de la clase string en C#. Este método convierte la cadena en un array de caracteres.

string resultado = string.Join(" ", caracteres);//separamos los caracteres
Console.WriteLine($"Caracteres en la cadena: {resultado}");//imprimimos el resultado




