using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExConstructor : MonoBehaviour
{
    private int value;
    public ExConstructor(int _value)
    {
        value = _value; 
        Debug.Log("��ü�� ���� �Ǿ����ϴ� . �ʱⰪ : " + value);
    }
    private void Start()
    {
        ExConstructor ex = new ExConstructor(10);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        Debug.Log("��ü�� �ı��Ǿ����ϴ�.");
    }
}