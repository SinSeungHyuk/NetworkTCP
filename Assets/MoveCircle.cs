using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour
{
    public float speed = 5f;
    public float degree = 90f;

    private void Start()
    {
        //List<int> randomChoice = new List<int>();

        //while (randomChoice.Count < 3)
        //{
        //    int randomNumber = Random.Range(0, 10); // 레벨업 종류 결정 
        //    if (!randomChoice.Contains(randomNumber))
        //    {
        //        randomChoice.Add(randomNumber);
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{                      // 랜덤으로 뽑은 번호의 레벨업 선택지 매개변수로 UI 초기화
        //    Debug.Log(randomChoice[i]);
        //}

        float damageReductionRate = (30f / (30f + 50f)) * 100f;

        // 두 자릿수 정수로 반올림
        int damageReductionPercentage = Mathf.RoundToInt(damageReductionRate * 100);
        Debug.Log(damageReductionRate);   
    }

    void Update()
    {
        float radian = degree * Mathf.Deg2Rad; // degree -> radian

        float x = Mathf.Cos(radian);
        float y = Mathf.Sin(radian);
        transform.position += new Vector3(speed * x * Time.deltaTime, speed * y * Time.deltaTime, 0f);
    }
}
