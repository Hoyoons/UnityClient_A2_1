using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME //�̸� �浹 ���� 
{
    public class Enums      //������ 
    {
        public enum StoryType   //���丮 Ÿ��
        {
            MAIN,
            SUB,
            SERIAL
        }
        public enum EvenType                //�̺�Ʈ �߻� üũ 
        {
            NONE,
            GoToBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckCON,
            CheckINT,
            CHECKWIS,
            CheckCHA
        }
        public enum ResultType          //�̺�Ʈ ��� ����
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GotoRandomStory,
            GotoEnding
        }
    }
    [System.Serializable]
    public class Stats
    {
        public int hpPoint;
        public int spPoint;

        public int cuttentHpPoint;
        public int cuttentSpPoint;
        public int cuttentXpPoint;

        public int strength;
        public int dexterity;
        public int consitiution;
        public int intelligence;
        public int wisdom;
        public int charisma;


    }
}
