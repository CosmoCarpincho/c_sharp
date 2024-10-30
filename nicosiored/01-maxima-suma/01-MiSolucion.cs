/*
https://www.youtube.com/watch?v=rqaqJXbauyA&list=PLM-p96nOrGcbznQ2ky13QIM7Fc8AQ150T
Máxima Subsuma
Tenemos una serie de números y hay que encontrar el subconjunto de números contiguos
que al sumarlos nos den el máximo valor posible

4, -3, 5, -2, -1, 2, 6, -2
*/


// Mi solución
// Primeras ideas:

// Buscar el número mas grande.
// Recorrer los laterales hasta que la suma de los elementos sea menor o igual a 0.
// Volver hasta el pico maximo (suma maxima)

int[] arreglo = [4, -3, 5, -2, -1, 2, 6, -2];

int maxNumero = int.MinValue;
int indiceMaxNumero = -1;


for (int i = 0; i < arreglo.Length; i++)
{
    if (maxNumero < arreglo[i])
    {
        maxNumero = arreglo[i];
        indiceMaxNumero = i;
    }
}

if (indiceMaxNumero == -1)
{
    Console.WriteLine("El arreglo esta vacio");
    Environment.Exit(0);
}


// Izquierda
int sumaIzq = maxNumero;
int maxSumaIzq = maxNumero;
for (int i = 0; i < indiceMaxNumero; i++)
{
    sumaIzq += arreglo[indiceMaxNumero - 1 - i];

    if (maxSumaIzq < sumaIzq)
    {
        maxSumaIzq = sumaIzq;
    }

}
