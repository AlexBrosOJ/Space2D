using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerController player; // ������ �� ������ ������
    public GameObject enemyPrefab; // ������ �����
    public Text scoreText; // ��������� ���� ��� ����������� �����
    public int enemiesDestroyed;

    private int score = 0; // ���� ������
    public bool game_stat = true;

    void Update()
    {
        /*  // ���������, ��� ����� ����������
          if (player != null)
          {
              // ��� ��� ��� ������ ������ (enemySpawnTimer, enemySpawnInterval � �. �.)

              // ���������, ��� ����� ��������� �����
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
