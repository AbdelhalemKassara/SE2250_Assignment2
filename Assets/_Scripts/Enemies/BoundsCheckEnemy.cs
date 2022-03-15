using UnityEngine;


//make this class a general class then split it into enemy 1 and 2
public class BoundsCheckEnemy : BoundsCheck
{
    protected float bottomBound;
    public GameObject ship;


    protected void Awake()
    {
        base.Awake();
        bottomBound = -screenBounds.y - shipHalfHeight;
    }
    protected void LateUpdate()
    {
        BottomCheck();
    }

    //getters and setters
    public override float SetShipHalfWidth()
    {
        shipHalfWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        return shipHalfWidth;
    }
    public override float SetShipHalfHeight() {
        shipHalfHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        return shipHalfHeight;
    }
    
     
    //methods
    protected void BottomCheck() {
        if(transform.position.y <= bottomBound) {
            Destroy(gameObject);
        } 
    }

    
}
