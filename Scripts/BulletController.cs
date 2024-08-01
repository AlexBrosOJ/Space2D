using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f;
    public float damage = 10.0f;

    void Update()
    {
        // �������� ������� �����
      //  transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // ���� ������ ����� �� �����
        if (other.gameObject.tag == "Enemy")
        {
            // ��������� ����� �����
            other.gameObject.GetComponent<EnemyController>().TakeDamage(damage);

            // ����������� �������
            Destroy(gameObject, 1.0f);
        }
        // ���� ������ ����� � ������
        else if (other.gameObject.tag == "Player")
        {
            // ��������� ����� ������
            other.gameObject.GetComponent<PlayerController>().TakeDamage(damage);

            // ����������� �������
            Destroy(gameObject, 1.0f);
        }
    }

}
