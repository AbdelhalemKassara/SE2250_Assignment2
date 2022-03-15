using UnityEngine;

public abstract class BoundsCheck : MonoBehaviour
{
    protected Vector2 screenBounds;
    protected float shipHalfWidth;
    protected float shipHalfHeight;

    protected void Awake()
    {
        //takes in the width and height of the screen and camera height then returns the top right point of the screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    //getters and setters
    public abstract float SetShipHalfWidth();
    public abstract float SetShipHalfHeight();

}
