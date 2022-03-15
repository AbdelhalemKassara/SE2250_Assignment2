using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public float genRate = 2f;
    public float chanceE1toE2 = 0.5f;
    public GameObject enemy1, enemy2;

    private float nextTime;
    private Vector2 screenSize;
    private Vector2 enemy1StPos, enemy2StPos;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = Time.time + genRate;

        //setting the starting positions of each enemy
        screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        enemy1StPos.x = screenSize.x - enemy1.GetComponent<BoundsCheckEnemy1>().SetShipHalfWidth();
        enemy1StPos.y = screenSize.y + enemy1.GetComponent<BoundsCheckEnemy1>().SetShipHalfHeight();

        enemy2StPos.x = screenSize.x - enemy2.GetComponent<BoundsCheckEnemy2>().SetShipHalfWidth();
        enemy2StPos.y = screenSize.y + enemy2.GetComponent<BoundsCheckEnemy2>().SetShipHalfHeight();
    }

    // Update is called once per frame
    void Update()
    {
        GenNewEnemy();
    }

    //generates a new enemy
    void GenNewEnemy()
    {
        //checks if genRate has elapsed
        if (Time.time >= nextTime)
        {
            //randomly decides if enemy 1 or 2 is generated
            if(Random.Range(0f, 1f) < chanceE1toE2)
            {
                Instantiate(enemy1, new Vector3(Random.Range(-enemy1StPos.x, enemy1StPos.x), enemy1StPos.y, 0f), transform.rotation);
                
            } else
            {
                Instantiate(enemy2, new Vector3(Random.Range(-enemy2StPos.x, enemy2StPos.x), enemy2StPos.y, 0f), transform.rotation);
            }

            nextTime = Time.time + genRate;
        }
    }
       
}
