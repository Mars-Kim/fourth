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
        Debug.Log(a + "초 경과");
        Debug.Log("내년이 다가왔습니다.");

        int age = Random.Range(1, 10);
        StudyScript.Instance.dataAge = age;
        string Name = "아무개";
        StudyScript.Instance.dataName = Name;
        Debug.Log("이름 : " + StudyScript.Instance.dataName + "\n나이" + StudyScript.Instance.dataAge);
        CancelInvoke("RepeatingMessage");
    }

    void RepeatingMessage()
    {

        Debug.Log( a + " 초 경과");
        a++;
    }
}
