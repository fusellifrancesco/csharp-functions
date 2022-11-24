// definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
// Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice
// si vogliono utilizzare le funzioni per:
// - Stampare l’array di numeri fornito a video (FATTO)
// - Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//   (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
// - Stampare la somma di tutti i numeri (FATTO)
// - Stampare la somma di tutti i numeri elevati al quadrati

//---------------------------- MAIN ------------------------------------------------------

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

StampaArrayInteri(arrayNumeri);

Quadrato(3);

SommaElementiArray(arrayNumeri);
























//--------------------------------DICHIARAZIONE FUNZIONI----------------------------------

// FUNZIONE 1

void StampaArrayInteri(int[] array) {
    Console.Write("[");

    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
            Console.Write(array[i]);
        } else {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

// FUNZIONE 2

int Quadrato(int numero) {
    int numeroQuadrato = numero * numero;
    Console.WriteLine(numeroQuadrato);
    return numeroQuadrato;
}

// FUNZIONE 3
/*
int ElevaArrayAlQuadrato(int[] array) {

    int[] arrayQuadratoCopia = (int[])array.Clone();

    for (int i = 0; i < arrayQuadratoCopia.Length; i++) {

        arrayQuadratoCopia = arrayQuadratoCopia[i] * arrayQuadratoCopia[i];

    }

    Console.WriteLine(SommaElementiArray(arrayQuadratoCopia);
    return arrayQuadratoCopia;
}
*/
// FUNZIONE 4

int SommaElementiArray(int[] array) {

    int somma = 0;
    
    for (int i = 0; i < array.Length; i++) {

        somma = somma + array[i];

    }

    Console.WriteLine("La somma è: " + somma);
    return somma;
}