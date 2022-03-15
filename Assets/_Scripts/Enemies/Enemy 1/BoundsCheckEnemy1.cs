using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheckEnemy1 : BoundsCheckEnemy
{
    protected float sideBounds;

    void Awake() {
        SetShipHalfWidth();
        SetShipHalfHeight();

        base.Awake();
    }
    //getters and setters
    public override float SetShipHalfWidth() {
        shipHalfWidth = transform.Find("Wing").GetComponent<SpriteRenderer>().bounds.size.x / 2;
        return shipHalfWidth;
    }
    public override float SetShipHalfHeight() { 
        shipHalfHeight = (transform.GetComponent<SpriteRenderer>().bounds.size.y + transform.Find("Gun").GetComponent<SpriteRenderer>().bounds.size.y) / 2;
        return shipHalfHeight;
    }
    
}
