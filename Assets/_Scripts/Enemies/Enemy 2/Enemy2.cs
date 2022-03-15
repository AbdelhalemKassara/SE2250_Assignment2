using UnityEngine;

public class Enemy2 : Enemy
{
    private float dir = 1f;
    public float changeRate = 2f;
    public float chanceChange = 0.5f;
    private float nextTime;

    protected void Start()
    {
        nextTime = Time.time + changeRate;
    }

    protected void FixedUpdate()
    {
        base.FixedUpdate();
        RandDir();
        MoveSide();
    }

    //this moves the enemy ship to the side
    void MoveSide() {
        Vector3 tempPos = pos;
        tempPos.x += speed * dir * Time.deltaTime;
        pos = tempPos;
    }

    public void DirPos()
    {
        dir = 1f;
    }

    public void DirNeg()
    {
        dir = -1f;
    }

    //this controls the direction the enemy ship is going
    private void RandDir()
    {
        if(Time.time >= nextTime)
        {
            nextTime = Time.time + changeRate;
            //if the random value is between 0 to chanceChange invert the horiziontal direction
            if (Random.Range(0f, 1f) < chanceChange)
            {
                dir *= -1f;
            }
        }
        
    }
}
