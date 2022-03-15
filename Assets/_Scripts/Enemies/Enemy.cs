using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    public Vector3 pos {
        get { 
            return(transform.position);
        }
        set {
            transform.position = value;
        }
    }
    
    protected void FixedUpdate()
    {
        MoveDown(); 
    }

    //this method is responsible for moving the enemy down
    protected void MoveDown() {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

}
