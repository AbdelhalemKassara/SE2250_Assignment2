using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheckEnemy : MonoBehaviour
{
    protected Vector2 bottomScreen;

    // Start is called before the first frame update
    void Start()
    {
        bottomScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= bottomScreen.y) {
            Destroy(gameObject);
        }   
    }

    //Destroy(gameObject);
}
