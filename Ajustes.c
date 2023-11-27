#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/wait.h>

struct Proceso{
    char nombre[10];
    int tiempoLlegada;
    int tiempoEjecucion;
    int pesoProceso;
};

int* CrearMemoria(){
    int* memoria = (int*)malloc(9 * sizeof(int));

    for(int i = 0; i < 9; i ++){
        memoria[i] = 10;
    }

    return memoria;
}

void MostrarVector(int* vector, char* mensaje){
    printf("%s\n", mensaje);
    for(int i = 0; i < 9; i++){
        printf("Pos [%d]: Valor:%d\n", (i + 1), vector[i]);
    }
    printf("\n");
}

void MostrarVector1(char** vector, char* mensaje){
    printf("%s\n", mensaje);
    for(int i = 0; i < 9; i++){
        printf("Pos [%d]: Valor:%s\n", (i + 1), vector[i]);
    }
    printf("\n");
}

int LeerArchivo(const char *nombreArchivo, struct Proceso procesos[], int maxProcesos){
    FILE *archivo;
    archivo = fopen(nombreArchivo, "r");

    if(archivo == NULL){
        fprintf(stderr, "No se puede abrir el archivo.\n");
        return -1;
    }

    int numeroProcesos = 0;

    while(numeroProcesos < maxProcesos && fscanf(archivo, "%9[^,],%d,%d,%d\n", procesos[numeroProcesos].nombre, &procesos[numeroProcesos].tiempoLlegada,
                &procesos[numeroProcesos].tiempoEjecucion, &procesos[numeroProcesos].pesoProceso) == 4){
        numeroProcesos ++;
    }

    fclose(archivo);

    return numeroProcesos;
}

void PrimerAjuste(char** nombreP, int* memoria, int* inicioP, int* ejecuionP, int* pesosP){
    if(strcmp(nombreP[0], "p1") == 0){

    }
}

int main(){
    int* memoria1 = CrearMemoria();
    int* inicioProcesos = (int*)malloc(9 * sizeof(int));
    int* ejecucionProcesos = (int*)malloc(9 * sizeof(int));
    int* pesosPro = (int*)malloc(9 * sizeof(int));
    char** nombreProcesos = (char**)malloc(9 * sizeof(char));

    const int maxProcesos = 9;

    struct Proceso procesos[maxProcesos];

    int numeroProcesosLeidos = LeerArchivo("Procesos.txt", procesos, maxProcesos);

    if(numeroProcesosLeidos > 0){
        printf("%-5s %-15s %-20s %-10s\n", "PROCESO", "INICIO", "EJECUCION", "PESO");
        for(int i = 0; i < numeroProcesosLeidos; i++){
            printf("%-8s %-17d %-18d %-5d\n", procesos[i].nombre, procesos[i].tiempoLlegada, procesos[i].tiempoEjecucion, procesos[i].pesoProceso);
            nombreProcesos[i] = procesos[i].nombre;
            inicioProcesos[i] = procesos[i].tiempoLlegada;
            ejecucionProcesos[i] = procesos[i].tiempoEjecucion;
            pesosPro[i] = procesos[i].pesoProceso;
        }
    }else{
        printf("No se pudieron leer los procesos.\n");
    }

    MostrarVector(inicioProcesos, "INICIO");
    MostrarVector(ejecucionProcesos, "EJECUCION");
    MostrarVector(pesosPro, "PESOS");
    MostrarVector1(nombreProcesos, "NOMBRE");






    return 0;
}
