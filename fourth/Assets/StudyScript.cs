using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;


[CreateAssetMenu(fileName = "studyData1", menuName = "study/data1", order = 1)]
public class StudyScript : ScriptableObject
{
    private static StudyScript _instance;

    public static StudyScript Instance
    {
        get
        {
            if (_instance != null) { return _instance; }

            _instance = Resources.Load<StudyScript>("studyData1");
            return _instance;
        }
    }
    public string dataName;
    public int dataAge;
}
