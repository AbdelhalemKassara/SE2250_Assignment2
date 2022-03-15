using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    private Vector2 screenBounds;
    private float shipHalfWidth;
    private float shipHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        //takes in the width and height of the screen and camera height then returns the top right point of the screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        shipHalfWidth = (transform.GetComponent<SpriteRenderer>().bounds.size.x + transform.Find("Left Wing").GetComponent<SpriteRenderer>().bounds.size.x) / 2;
        shipHalfHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // This will run afer the ShipMovment script
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        //(0,0) is the center of the screen

        //Mathf.Clamp() takes in a value and returns a value within a upper and lower bound
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + shipHalfWidth, screenBounds.x - shipHalfWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + shipHalfHeight, screenBounds.y - shipHalfHeight);
        
        //set the player position
        transform.position = viewPos;
    }

    //when the player collides with any of the enemies
    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
        Destroy(col.gameObject);
    }
}
