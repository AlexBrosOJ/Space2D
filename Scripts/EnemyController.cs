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
        // ������ �������� ������ �������
        InvokeRepeating("Fire", 1.0f, 1.0f);
    }

    void Fire()
    {
        // �������� �������
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // ���������� �������� �������
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * -6;

        // ����������� ������� ����� 2 �������
        Destroy(bullet, 2.0f);
    }

    public void TakeDamage(float damage)
    {
        // ���������� ��������
        health -= damage;

        // ���� �������� ����� ������ ��� ����� 0
        if (health <= 0)
        {
            // ����������� �����
            Destroy(gameObject);

            // ���������� ����� ������
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                player.GetComponent<PlayerController>().EnemyDestroyed();
            }
        }
    }
}
