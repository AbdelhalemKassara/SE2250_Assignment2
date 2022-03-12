using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoundsCheckEnemy2 : BoundsCheckEnemy
{
    void Update() {
        moveSide();
    }

    void moveSide() {
        if(transform.position.x >= bottomScreen.x) {
            //move to the left (call movenment script)
        } else if(transform.position.x <= bottomScreen.x * -1) {
            //move to the right
        }
    }
}
