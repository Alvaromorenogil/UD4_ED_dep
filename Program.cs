using System;
class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' }; // array de caracteres llamado "letters"
        string name = ""; // variable declarada de tipo string
        int[] a = new int[10]; // variable declarada de tipo int
        
        for (int i = 0; i < letters.Length; i++) // bucle que en cada vuelta se le suma 1 a la variable "a"
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {        
        Console.WriteLine("Hello, " + name + "! Count to " + msg); // Muestra el contenido en la consola
    }
}
