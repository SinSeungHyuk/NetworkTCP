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
        //    int randomNumber = Random.Range(0, 10); // ������ ���� ���� 
        //    if (!randomChoice.Contains(randomNumber))
        //    {
        //        randomChoice.Add(randomNumber);
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{                      // �������� ���� ��ȣ�� ������ ������ �Ű������� UI �ʱ�ȭ
        //    Debug.Log(randomChoice[i]);
        //}

        float damageReductionRate = (30f / (30f + 50f)) * 100f;

        // �� �ڸ��� ������ �ݿø�
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
