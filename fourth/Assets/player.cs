using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StudyScript studyScript;

    #region 1��° ���
    //���� �Ҵ��Ͽ� ���
    private void First()
    {
        Debug.Log("�̸� : " +  studyScript.dataName + "\n����" + studyScript.dataAge);
    }
    #endregion

    #region 2��° ���
    private void Second()
    {
        studyScript = Resources.Load<StudyScript>("studyData1");
        // ���� �ȿ��ִ� ��ũ��Ʈ �ȿ��ִ� �����͸� ã�Ƽ� �Ҵ��Ѵ�.
        Debug.Log("�̸� : " + studyScript.dataName + "\n���� : " + studyScript.dataAge);
    }
    #endregion

    #region 3��° ���
    private void Third()
    {
        Debug.Log("�̸� : " + StudyScript.Instance.dataName + "\n����" +  StudyScript.Instance.dataAge);
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

            Debug.Log("�̸� : " + StudyScript.Instance.dataName + "\n����" + StudyScript.Instance.dataAge);
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("10�� ���");
    }

}
