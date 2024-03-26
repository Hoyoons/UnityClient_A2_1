using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterManager : MonoBehaviour
{
    public List<ExCharacter> characterList = new List<ExCharacter>();
    //���� ���� Ŭ������ ����ϸ� �ٸ� ��ì�̵��� �˾Ƽ� ����Ʈ�� �㰡��.
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Ű ������ �ǻ���
        {
            for(int i = 0; i < characterList.Count; i++)
            {
                characterList[i].DestroyCharacter();
            }
        }
    }
}
