using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float health = 100.0f;
    public int experience = 0;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int enemiesDestroyed = 0;

    void Update()
    {
        // Перемещение игрока
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        GetComponent<Rigidbody2D>().velocity = movement * speed;

        // Стрельба
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Создание снаряда
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;
    }

    public void EnemyDestroyed()
    {
        // Увеличение опыта
        experience += 10;
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
            enemiesDestroyed++;
        }
    }
}
