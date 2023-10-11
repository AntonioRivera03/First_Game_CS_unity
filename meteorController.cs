using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorController : MonoBehaviour
{
    public float speed = 7.5f;
    private Vector3 stopper;
    
    
    // Update is called once per frame

    void Start()
    {
        stopper = GameObject.Find("Square").transform.position;
    }

    private void Awake()
    {


        gameObject.AddComponent<BoxCollider2D>();


    }
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= speed * Time.deltaTime;
        //Debug.Log(pos.x + " " + stopper.x);

        transform.position = pos;

        if (pos.x < -13)
        {
            
            Destroy(this.gameObject);
        }
    }

}
