using UnityEngine;


public class BoundsCheckEnemy2 : BoundsCheckEnemy
{
    private float sideBounds;

    private void Awake()
    {
        SetShipHalfHeight();
        SetShipHalfWidth();
        base.Awake();
        sideBounds = screenBounds.x - shipHalfWidth;
    }


    //LateUpdate so that it checks the enemy's position after they have moved
    void LateUpdate() {
        base.LateUpdate();
        SideCheck();
    }

    public override float SetShipHalfHeight()
    {
        shipHalfHeight = (transform.Find("Gun").GetComponent<SpriteRenderer>().bounds.size.y + transform.GetComponent<SpriteRenderer>().bounds.size.y / 2) / 2;
        return shipHalfHeight;
    }

    public override float SetShipHalfWidth()
    {
        shipHalfWidth = (transform.GetComponent<SpriteRenderer>().bounds.size.x + transform.Find("Left Wing").GetComponent<SpriteRenderer>().bounds.size.x) / 2;
        return shipHalfWidth;
    }
   

    void SideCheck() {
        //checks if the enemy passed the right side then makes the enemy ship move in the opposite direction
        if (transform.position.x > sideBounds) {
            gameObject.GetComponent<Enemy2>().DirNeg();
        }
        //checks if the enemy passsed the left side then makes the enemy ship move in the opposite direction
        else if (transform.position.x < sideBounds * -1f) {
            gameObject.GetComponent<Enemy2>().DirPos();
        }
    }

}
