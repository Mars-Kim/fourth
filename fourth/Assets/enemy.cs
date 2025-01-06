using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coroutineWhile());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
    }

    IEnumerator coroutineWhile()
    {
        while (true)
        {
            int randomTime = Random.Range(1, 10);
            Debug.Log(randomTime + "초 뒤 발사!");
            Instantiate(bullet, this.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }

}
