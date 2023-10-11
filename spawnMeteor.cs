using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMeteor : MonoBehaviour
{


    public GameObject circlePrefab;

    public meteorController meteor;

    public int level;
    private Vector3 pos;
    // Update is called once per frame
    void Start()
    {
        meteor.speed = 7.5f;
        pos = transform.position;
        Debug.Log(pos);
        StartCoroutine(waiter());
    }

    void Update()
    {
    }

    IEnumerator waiter()
    {
        float random;
        float time;
        pos = transform.position;
        level = 1;
        int numOfMeteors = 10;
        float divider = 1f;
        while (true)
        {
            random = Random.Range(-4f, 4f);
            time = Random.Range(.2f, .7f) / divider;
            
            pos.y = random;
            yield return new WaitForSeconds(time);
            numOfMeteors--;
            Instantiate(circlePrefab, pos, Quaternion.identity);
            if(numOfMeteors == 0)
            {
                level++;
                numOfMeteors = 10 * level;
                meteor.speed += 2f;
                divider += .25f;
            }
        }
        
    }
}
