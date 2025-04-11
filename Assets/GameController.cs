using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static bool defeatedByZombie = false;

    public static bool gameOver => collectableCount <= 0 || defeatedByZombie;
    public static bool Venceu => collectableCount <= 0 && !defeatedByZombie;
    public static int ColetaveisRestantes => collectableCount;

    public static void Init()
    {
        collectableCount = 15; // ou o número real de suprimentos na cena
        defeatedByZombie = false;
    }

    public static void Collect()
    {
        collectableCount--;
        Debug.Log($"Coletáveis restantes: {collectableCount}");
    }

    public static void GameOverByZombie()
    {
        defeatedByZombie = true;
        Debug.Log("Derrota: o zumbi pegou você!");
    }
}