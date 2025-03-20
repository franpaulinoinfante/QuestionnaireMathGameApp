using QuestionnaireMathGameConsoleApp;

Console.Title = "Questionnaire Math Game App";

new Game().Run();



/*
    Objetivo
        Se trata de construir una aplicacicón de un juego de matematicas que contenga las 4 operaciones basicas, suma, resta, multiplicacion y division.
        Con los siguientes requisitos
            Requisitos
                - Debe tener las operaciones básicas (suma, resta, multiplicación y división).
                    - Solo funciona con número enteros positivos menores o igual a 100.
                    - En la división solo deben ser divisiones que resulten en números enteros.
                - Se debe presentar un menú con las opciones.
                - Se debe almacenar los resultados de cada juego.
                - Se debe implementar un nivel de dificulta basico (facil, medio, dificil, aleatorio)
                    - Debe implemetnarse con un tiempo
                        - Facíl: 45 segundos para dar una respuesta y las operaciones no deben superar los priemros 333 primeros números enteros (ejemplo: 33 + 33).
                        - Medio: 30 segundos para dar una respuesta y las operaciones no deben superar los priemros 666 primeros números enteros (ejemplo: 66 - 66).
                        - Dificil: 15 segundo para dar una respuesta y las operaciones no deben superar el tope permitido en la aplicación "1000" (ejemplo: 100 / 100).
                        - Aleatorio: Las pregutnas son aleatorio, sin tomar el cuenta el nivel de dificiltad.
    Procedimiento QuestionnaireMathGameApp
    start
        Visualizar un mensaje de bienvenida.
        Visualizar las Reglas del juego.
        Hacer
            Visualizar el menú principal.
                Opciones [Jugar - Ver Historial de Partidas - Salir]
                Preguntar por la opción que desea seleccionar [JUGAR]
                Si selección es jugar
                    Jugar
                Sino
                    Si selección es ver historial
                        Ver Historial
                    Sino
                        Salir                
        Mientras (no seleccione salir)            
    end

    Procedimiento Jugar
    start
        Visualizar el nivel de dificultad
        Preguntar por el nivel de dificultad que desea jugar
            Hacer
                Visualizar Partida
            Mientras (rondas las rondas no terminen)
    end
*/