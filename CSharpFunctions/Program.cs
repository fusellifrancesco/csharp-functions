// definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.

// FUNZIONE 1

void StampaArrayInteri(int[] arrayInteri) {
    Console.Write("[");

    for (int i = 0; i < arrayInteri.Length; i++) {
        if (i == arrayInteri.Length - 1) {
            Console.Write(arrayInteri[i]);
        } else {
            Console.Write(arrayInteri[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

// FUNZIONE 2

int Quadrato(int numero) {
    int numeroQuadrato = numero * numero;
    return numeroQuadrato;
}

// FUNZIONE 3

int ElevaArrayAlQuadrato(int[] array) {

    int[] arrayQuadratoCopia = (int[])array.Clone();

    for (int i = 0; i < arrayQuadratoCopia.Length; i++) {

        arrayQuadratoCopia = arrayQuadratoCopia[i] * arrayQuadratoCopia[i];

    }

    return arrayQuadratoCopia;
}

// FUNZIONE 4

int sommaElementiArray(int[] array) {

    int somma = 0;
    
    for (int i = 0; i < array.Length; i++) {

        somma = somma + array[i];

    }

    return somma;
}