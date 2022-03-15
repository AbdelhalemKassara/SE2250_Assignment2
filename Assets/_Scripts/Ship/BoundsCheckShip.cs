using UnityEngine;

public class BoundsCheckShip : BoundsCheck
{

    protected void Awake()
    {
        base.Awake();
        SetShipHalfHeight();
        SetShipHalfWidth();
    }

    // This will run afer the ShipMovment script
    void LateUpdate()
    {
        AdjustPos();
    }

    public override float SetShipHalfWidth()
    {
        shipHalfWidth = (transform.GetComponent<SpriteRenderer>().bounds.size.x + transform.Find("Left Wing").GetComponent<SpriteRenderer>().bounds.size.x) / 2;
        return shipHalfWidth;
    }

    public override float SetShipHalfHeight()
    {
        shipHalfHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        return shipHalfHeight;
    }

    void AdjustPos()
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
        Destroy(gameObject);
        Destroy(col.gameObject);
    }
}
