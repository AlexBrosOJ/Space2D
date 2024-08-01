using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerController player; // Ссылка на скрипт игрока
    public GameObject enemyPrefab; // Префаб врага
    public Text scoreText; // Текстовое поле для отображения счета
    public int enemiesDestroyed;

    private int score = 0; // Счет игрока
    public bool game_stat = true;

    void Update()
    {
        /*  // Проверяем, что игрок существует
          if (player != null)
          {
              // Ваш код для спавна врагов (enemySpawnTimer, enemySpawnInterval и т. д.)

              // Проверяем, что игрок уничтожил врага
              foreach (Enemy enemy in GetComponentsInChildren<Enemy>())
              {
                  if (enemiesDestroyed != 0)
                  {
                      score = enemiesDestroyed;
                  }
              }
          } */
    }
}
