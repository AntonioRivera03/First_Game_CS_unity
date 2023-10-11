using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iterator : MonoBehaviour
{


    public PlayerController player;
    public spawnMeteor spawner;
    private string display;
    private string level;
    private int iterator = 0;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (player.alive)
        {
            iterator++;
            
            display = "LEVEL " + spawner.level + "\nPOINTS " + iterator.ToString();


            this.gameObject.GetComponent<Text>().text = display;
        }
        


    }
}
