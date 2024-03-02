        // Concatenación con el operador +
        string cadena1 = "Hola";
        string cadena2 = " ";
        string cadena3 = "mundo!";
        string resultado = cadena1 + cadena2 + cadena3;
        Console.WriteLine("Concatenación con el operador +: " + resultado);

        // Concatenación con el método Concat
        string resultado2 = string.Concat(cadena1, cadena2, cadena3);
        Console.WriteLine("Concatenación con el método Concat: " + resultado2);


        // Length: Obtiene la longitud de una cadena.
        string ejemploLength = "Hola mundo!";
        int longitud = ejemploLength.Length;
        Console.WriteLine($"Longitud de la cadena: {longitud}");

        // ToUpper(): Convierte la cadena a mayúsculas.
        string ejemploToUpper = "Hola mundo!";
        string mayusculas = ejemploToUpper.ToUpper();
        Console.WriteLine($"Cadena en mayúsculas: {mayusculas}");

        // ToLower(): Convierte la cadena a minúsculas.
        string ejemploToLower = "Hola Mundo!";
        string minusculas = ejemploToLower.ToLower();
        Console.WriteLine($"Cadena en minúsculas: {minusculas}");

        // IndexOf(): Busca la primera ocurrencia de un carácter o cadena.
        string ejemploIndexOf = "Hola mundo!";
        int indice = ejemploIndexOf.IndexOf("mundo");
        Console.WriteLine($"Índice de la primera aparición de 'mundo': {indice}");

        // LastIndexOf(): Busca la última ocurrencia de un carácter o cadena.
        string ejemploLastIndexOf = "Hola mundo!";
        int ultimoIndice = ejemploLastIndexOf.LastIndexOf("o");
        Console.WriteLine($"Último índice de la aparción de 'o': {ultimoIndice}");

        // Substring(): Extrae una subcadena.
        string ejemploSubstring = "Hola mundo";
        string subcadena = ejemploSubstring.Substring(5, 5);
        Console.WriteLine($"Subcadena extraída: {subcadena}");

        // Replace(): Reemplaza una subcadena por otra.
        string ejemploReplace = "Hola mundo";
        string reemplazado = ejemploReplace.Replace("mundo", "amigo");
        Console.WriteLine($"Cadena con reemplazo: {reemplazado}");

        // Trim(): Elimina espacios en blanco al inicio y final.
        string ejemploTrim = "   Hola mundo   ";
        string sinEspacios = ejemploTrim.Trim();
        Console.WriteLine($"Cadena sin espacios en blanco al inicio y final: '{sinEspacios}'");

        // StartsWith(): Indica si una cadena comienza con otra.
        string ejemploStartsWith = "Hola mundo";
        bool comienzaConHola = ejemploStartsWith.StartsWith("Hola");
        Console.WriteLine($"La cadena comienza con 'Hola': {comienzaConHola}");

        // EndsWith(): Indica si una cadena termina con otra.
        string ejemploEndsWith = "Hola mundo!";
        bool terminaConMundo = ejemploEndsWith.EndsWith("mundo!");
        Console.WriteLine($"La cadena termina con 'mundo!': {terminaConMundo}");
