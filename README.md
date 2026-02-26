# Laboratorios
Hola
No c q decir
// ejercicio 1
Console.WriteLine("programa hecho por: Ernesto Perez");
Console.WriteLine("número de carnet 1326926");
Console.WriteLine("Ejercicio 1 Nota del estudiante");
Console.WriteLine("Ingrese la nota del estudiante: ");
int nota = int.Parse(Console.ReadLine());

if (nota >= 0 && nota <= 100)
{
    if (nota >= 65)
    {
        Console.WriteLine("Resultado: Aprobado");
    }
    else
    {
        Console.WriteLine("Resultado: Reprobado");
    }
}

// ejercicio 2
Console.WriteLine("Ejercicio 2: Promociones de alamacén");
Console.WriteLine("Programa hecho por: Ernesto Perez");
Console.WriteLine("número de carnet 1326926");
Console.WriteLine("Ingrese el monto total de la factura");
double monto = double.Parse(Console.ReadLine());
if (monto >= 200.00 && monto < 499.00)
{
    Console.WriteLine("Premio: un cupón de 5% de descuento en su próxima compra");
}
else if (monto >= 500.00 && monto < 1999.99)
{
    Console.WriteLine("Premio: se le regala un número de rifa");
}
else if (monto >= 2000.00)
{
    Console.WriteLine("Premio: Se gana una membresía gratis de la tienda");
}
else
{
    Console.WriteLine("No se gana ningún premio");
}

// ejercicio 3
Console.WriteLine("Ejercicio 3: Numeración Maya");
Console.WriteLine("Programa hecho por: Ernesto Perez");
Console.WriteLine("número de carnet 1326926");
Console.WriteLine("Ingrese un número entero del 1 al 19");
int numero = int.Parse(Console.ReadLine());
if (numero >= 1 && numero <= 19)
{
    int lineas = numero / 5;
    int puntos = numero % 5;
    Console.WriteLine("n/Número maya:");
    Console.WriteLine("Líneas: " + lineas);
    Console.WriteLine("Puntos: " + puntos);
}
else
{
    Console.WriteLine("Número no válido, por favor ingrese un número válido");
}
// los otros ejercicos los he hecho en la computadora del lab