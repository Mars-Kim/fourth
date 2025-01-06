using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StudyScript studyScript;

    #region 1번째 방법
    //직접 할당하여 사용
    private void First()
    {
        Debug.Log("이름 : " +  studyScript.dataName + "\n나이" + studyScript.dataAge);
    }
    #endregion

    #region 2번째 방법
    private void Second()
    {
        studyScript = Resources.Load<StudyScript>("studyData1");
        // 폴더 안에있는 스크립트 안에있는 데이터를 찾아서 할당한다.
        Debug.Log("이름 : " + studyScript.dataName + "\n나이 : " + studyScript.dataAge);
    }
    #endregion

    #region 3번째 방법
    private void Third()
    {
        Debug.Log("이름 : " + StudyScript.Instance.dataName + "\n나이" +  StudyScript.Instance.dataAge);
    }
    #endregion

    void Start()
    {
        //First();
        //Second();
        //Third();
        StartCoroutine(coroutineFor());
    }

    IEnumerator coroutineFor()
    {
        for (int i = 0; i < 10; i++)
        {
            int age = Random.Range(1, 10);
            StudyScript.Instance.dataAge = age;

            Debug.Log("이름 : " + StudyScript.Instance.dataName + "\n나이" + StudyScript.Instance.dataAge);
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("10초 경과");
    }

}
