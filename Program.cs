Console.Write("Ingrese el numero: ");
int valor = Convert.ToInt32(Console.ReadLine());
int validador = 0;
int temporal1 = 0;
int temporal2 = 1;
while(validador != 1){
    int suma = temporal1 + temporal2;
    temporal1 = temporal2;
    temporal2 = suma;
    if(valor == temporal2){
        validador = 1;
        Console.WriteLine(valor + " es numero de fibonacci");
    }
    else if(temporal2 > valor){
        validador = 1;
        Console.WriteLine(valor+ " no es numero de fibonacci");
    }
}
