namespace QuestionnaireMathGameConsoleApp;

public class MessageView
{
    internal void WelcomeMessage()
    {
        Display("🎮 Bienvenido al Juego de Matemáticas Básicas 🎮");
    }

    internal void DisplayRule()
    {
        Display("📌 Reglas del Juego:");
        Display(
            "- Solo se permiten números enteros positivos." +
            "- Las divisiones siempre darán resultados enteros." +
            "- Responde dentro del tiempo límite según el nivel de dificultad." +
            "- Se almacenarán los resultados de cada partida"
        );
    }

    internal void DisplayMainMenu()
    {
        Display("📜 Menú Principal");
        Display(
            "1️⃣ Jugar" +
            "2️⃣ Ver Historial de Partidas" +
            "3️⃣ Salir"
        );

        Display("🔽 Selecciona una opción:");
    }

    internal void DisplayLeves()
    {
        Display("🎲 Selección de Dificultad");
        Display(
            "1️⃣ Fácil 🟢 (45s, valores hasta 333)" +
            "2️⃣ Medio 🟡 (30s, valores hasta 666)" +
            "3️⃣ Difícil 🔴 (15s, valores hasta 1000)" +
            "4️⃣ Aleatorio 🎲 (Valores sin restricción de dificultad)"
        );

        Display("🔽 Selecciona una opción:");
    }

    internal static void Display(string message)
    {
        Console.WriteLine(message);
    }
}
