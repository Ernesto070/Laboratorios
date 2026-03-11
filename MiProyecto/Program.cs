// ejercicio 1
Console.WriteLine("programa hecho por: Ernesto Perez");
Console.WriteLine("número de carnet 1326926");
Console.WriteLine("Ejercicio 1: secuenicia de numeros");
Console.WriteLine("Ingrese el numero final de la secuencia: ");
int numeroFinal = int.Parse(Console.ReadLine());
for (int i = 1; i <= numeroFinal; i++)
{
    Console.WriteLine(i);
}
// ejercicio 2
Console.WriteLine("Ejercicio 2: tablas de multiplicacción");
Console.WriteLine("Hecho por Ernesto Perez");

for (int j = 1; j <= 10; j++) //este ciclo lleva el control de el numero de la tabla
{
       Console.WriteLine($"Tabla del No. {j}");

        for (int i = 1; i <= 10; i++)// este ciclo lleva el control de las multiplicaciones
        {
            Console.WriteLine($"{j} * {i} = {j * i}" );
        }
    Console.WriteLine("");
}
// ejercicio 3
Console.WriteLine("Ejercicio 3: ");
Console.WriteLine("Hecho por Ernesto Perez");
Console.WriteLine("número de carnet 1326926");
Console.WriteLine("Ingrese el número para calcular su factorial: ");
int numero = int.Parse(Console.ReadLine());

long resultado = 1;

for (int i = 1; i <= numero; i++)
{
    resultado *= i;
}
Console.WriteLine($"El factorial de {numero} es: {resultado}");

Console.WriteLine("Gracias por usar el programa");