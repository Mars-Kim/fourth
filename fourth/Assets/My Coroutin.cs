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
        Debug.Log("코루틴 시작");

        yield return new WaitForSeconds(2.0f);

        Debug.Log("2초 대기 후 실행");

        yield return null;

        Debug.Log("다른 프레임 실행");

        Debug.Log("코루틴 종료");
    }

    IEnumerator coroutineFor()
    {
        for (int i=0; i<10; i++)
        {
            Debug.Log(i + "초 경과");

            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("10초 경과");
    }

    //랜덤값이 필요할 때 주로 사용
    IEnumerator coroutineWhile()
    {
        while (true)
        {
            int randomTime = Random.Range(1, 10);

            Debug.Log(randomTime + "초 뒤 다시 실행");
            yield return new WaitForSeconds(randomTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
