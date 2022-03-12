using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int _num = 0;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextNum);   
    }
    public int nextNum {
        get {
            _num++;
            return(_num);
        }
    }
    
}
