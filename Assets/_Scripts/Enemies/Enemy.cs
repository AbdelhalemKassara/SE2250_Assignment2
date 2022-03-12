using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float fireRate = 0.3f;
    public float health = 10;
    public int score = 100;

    public Vector3 pos {
        get { 
            return(this.transform.position);
        }
        set {
            this.transform.position = value;
        }
    }
    
    void FixedUpdate()
    {
        MoveDown(); 
    }

    public void MoveDown() {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

}
