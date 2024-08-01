using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f;
    public float damage = 10.0f;

    void Update()
    {
        // Движение снаряда вверх
      //  transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Если снаряд попал во врага
        if (other.gameObject.tag == "Enemy")
        {
            // Нанесение урона врагу
            other.gameObject.GetComponent<EnemyController>().TakeDamage(damage);

            // Уничтожение снаряда
            Destroy(gameObject, 1.0f);
        }
        // Если снаряд попал в игрока
        else if (other.gameObject.tag == "Player")
        {
            // Нанесение урона игроку
            other.gameObject.GetComponent<PlayerController>().TakeDamage(damage);

            // Уничтожение снаряда
            Destroy(gameObject, 1.0f);
        }
    }

}
