using UnityEngine;


//make this class a general class then split it into enemy 1 and 2
public abstract class BoundsCheckEnemy : MonoBehaviour
{
    protected Vector2 screenSize;
    protected float shipHalfWidth;//half width
    protected float shipHalfHeight;//half height
    protected float bottomBound;
    public GameObject ship;


    protected void Awake()
    {
        screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        bottomBound = -screenSize.y - shipHalfHeight;
    }
    protected void LateUpdate()
    {
        BottomCheck();
    }

    //getters and setters
    public abstract float SetShipHalfWidth();
    public abstract float SetShipHalfHeight(); 
    
     
    //methods
    protected void BottomCheck() {
        if(transform.position.y <= bottomBound) {
            Destroy(gameObject);
        } 
    }

    
}
