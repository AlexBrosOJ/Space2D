using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 50.0f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Start()
    {
        // Запуск стрельбы каждую секунду
        InvokeRepeating("Fire", 1.0f, 1.0f);
    }

    void Fire()
    {
        // Создание снаряда
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Добавление скорости снаряду
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * -6;

        // Уничтожение снаряда через 2 секунды
        Destroy(bullet, 2.0f);
    }

    public void TakeDamage(float damage)
    {
        // Уменьшение здоровья
        health -= damage;

        // Если здоровье врага меньше или равно 0
        if (health <= 0)
        {
            // Уничтожение врага
            Destroy(gameObject);

            // Увеличение опыта игрока
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                player.GetComponent<PlayerController>().EnemyDestroyed();
            }
        }
    }
}
