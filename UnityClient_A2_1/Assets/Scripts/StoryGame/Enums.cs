using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME //이름 충돌 ㄴㄴ 
{
    public class Enums      //열거형 
    {
        public enum StoryType   //스토리 타입
        {
            MAIN,
            SUB,
            SERIAL
        }
        public enum EvenType                //이벤트 발생 체크 
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
        public enum ResultType          //이벤트 결과 열거
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
