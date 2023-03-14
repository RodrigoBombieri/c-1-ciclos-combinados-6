// 1 ------------------------------------------------------
// 1. Hacer un programa para ingresar 10 números. El mismo debe analizar 
// y mostrar por pantalla cuántos de esos números son primos.


// creo el con acá afuera pero lo inicializo dentro.
// int n, con, conprimo = 0;

// for (int x = 0; x < 10; x++)
// {
//     // inicializo el con.
//     con = 0;
    
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     for (int y = 1; y <= n; y++)
//     {
//         if (n % y == 0)
//             con++;
//     }

//     if (con == 2)
//         conprimo++;
// }

// Console.WriteLine("Hay: " + conprimo + " primos.");



// 2 -------------------------------------------------
// 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
    // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

// declaro las variables afuera pero inicializo algunas dentro del for.
// int n, totaln, impares, grupoImparesMaximo = 0, min, cantidadOrdenados = 0; 
// double porcImpares, porcentajeMaximo = -1;
// bool banderaOrdenados;

// for (int x = 0; x < 5; x++)
// {
//     // inicializo las variables en cada vuelta del for
//     totaln = 0;
//     impares = 0;
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
    
//     //tomo el primero número ingresado como el mínimo, para el punto 2
//     min = n;
//     // asumo que la bandera inicializa ordenada.
//     banderaOrdenados = true;

//     while (n != 0)
//     {
//         // punto 1
//         // cuento todos los números y luego pregunto si son impares y los cuento dentro de la variable.
//         totaln++;
//         if(n % 2 != 0)
//             impares++; 
        
//         // punto 2
//         // comparo si los números que voy ingresando son menores al último ingresado, si no lo es la bandera bool cambia a FALSO.
//         if(n <= min)
//             min = n;
//         else
//             banderaOrdenados = false;

//         Console.WriteLine("Ingrese otro número: ");
//         n = int.Parse(Console.ReadLine());
//     }
//     // punto 1
//     // el porcentaje se calcula afuera del ciclo while luego de contar todos los número de ese lote.
//     porcImpares = (impares * 100) / totaln;
//     // busco el porcentaje máximo en cada vuelta.
//     if(porcImpares > porcentajeMaximo){
//         porcentajeMaximo = porcImpares;
//         // guardo la posición actual del porcentaje máximo provisorio teniendo en cuenta la posición de x en la vuelta actual del for, para seguir comparando.
//         grupoImparesMaximo = x + 1;
//     }

//     // punto 2
//     // si la bandera de ordenados estuvo en true durante toda la vuelta del ciclo while, lo cuenta como grupo ordenado.
//     if(banderaOrdenados)
//         cantidadOrdenados++;

// }

// Console.WriteLine("El grupo con porcentaje máximo de impares es: " + grupoImparesMaximo);
// Console.WriteLine("La cantidad de grupos ordenados es: " + cantidadOrdenados);




// 3 -----------------------------------------
// 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
// El fin de la carga se notifica con un número negativo. 
// Luego mostrar cuántos números tiene cada lista.


// int n, numeroGrupo = 0, con;

// // usamos el do while para no  "forzar" la primera vuelta del while (hacer n = 1, o pedir un número afuera).
// do
// {
//     numeroGrupo++;
//     con = 0;
//     n = int.Parse(Console.ReadLine());

//     while (n != 0 && n > 0)
//     {
//         con++;
//         n = int.Parse(Console.ReadLine());
//     }

//     Console.WriteLine("En el grupo: " + numeroGrupo + " hay " + con + " números.");
    
// }while (n >= 0);

