using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coroutineWhile());
    }

    IEnumerator coroutineInit()
    {
        Debug.Log("�ڷ�ƾ ����");

        yield return new WaitForSeconds(2.0f);

        Debug.Log("2�� ��� �� ����");

        yield return null;

        Debug.Log("�ٸ� ������ ����");

        Debug.Log("�ڷ�ƾ ����");
    }

    IEnumerator coroutineFor()
    {
        for (int i=0; i<10; i++)
        {
            Debug.Log(i + "�� ���");

            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("10�� ���");
    }

    //�������� �ʿ��� �� �ַ� ���
    IEnumerator coroutineWhile()
    {
        while (true)
        {
            int randomTime = Random.Range(1, 10);

            Debug.Log(randomTime + "�� �� �ٽ� ����");
            yield return new WaitForSeconds(randomTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
