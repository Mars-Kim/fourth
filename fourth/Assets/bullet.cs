using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
    }
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.right *speed* Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
