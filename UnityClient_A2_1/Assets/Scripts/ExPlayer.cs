using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{
    private int health = 100;
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("�÷��̾� �ǰ�. ���� ü�� : " + health);
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("�÷��̾ ����߽��ϴ�.");

    }
}
