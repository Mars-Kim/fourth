using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("PrintMessage", 2.0f);  문자열 내용이 함수 이름
        //InvokeRepeating("RepeatingMessage", 1.0f, 0.5f);
        Invoke("StopRepeating", 5.0f);
        InvokeRepeating("RepeatingMessage", 1.0f, 0.5f);
    }

    void StopRepeating()
    {
        CancelInvoke("RepeatingMessage");
    }

    void RepeatingMessage()
    {
        //Debug.Log("Hello, Invoke");
        Debug.Log("this is repeating Message");
    }
}
