using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StopRepeating", 10.0f);
        InvokeRepeating("RepeatingMessage", 0.0f, 1.0f);
    }

    void StopRepeating()
    {
        Debug.Log(a + "�� ���");
        Debug.Log("������ �ٰ��Խ��ϴ�.");

        int age = Random.Range(1, 10);
        StudyScript.Instance.dataAge = age;
        string Name = "�ƹ���";
        StudyScript.Instance.dataName = Name;
        Debug.Log("�̸� : " + StudyScript.Instance.dataName + "\n����" + StudyScript.Instance.dataAge);
        CancelInvoke("RepeatingMessage");
    }

    void RepeatingMessage()
    {

        Debug.Log( a + " �� ���");
        a++;
    }
}
