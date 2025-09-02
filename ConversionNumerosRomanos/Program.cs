using System;


class program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero romano");
        string romano = Console.ReadLine().ToUpper();

        int total = 0;

        for(int i = 0; i < romano.Length; i++)
        {
            int valor = ValorRomano(romano[i]);
            if(i + 1 < romano.Length && ValorRomano(romano[i + 1]) > valor)
            {
                total -= valor;
            }
            else
            {
                total += valor;
            }
        }
        Console.WriteLine("El numero decimal es: " + total);
    }

    static int ValorRomano(char c)
    {
        if(c == 'I') 
            return 1;
        if(c == 'V')
            return 5;
        if(c == 'X')
            return 10;
        if(c == 'L')
            return 50;
        if(c == 'C')
            return 100;
        if(c == 'D')
            return 500;
        if(c == 'M')
            return 1000;
        return 0;
    }
}