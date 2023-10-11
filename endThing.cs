using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endThing : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerController player;

    private Vector3 loc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.alive && transform.position.y < 0f)
        {
            loc.y = 0f;
            transform.position = loc;
        }
    }
}
