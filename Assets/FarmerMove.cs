using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMove : MonoBehaviour
{
    public float Speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0;
        float moveY = 0;

        if (Input.GetKeyDown(KeyCode.W))
        {
            moveY = 1;    
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveY = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveX = 1;
        }

        this.transform.Translate(moveX * Speed, 0, moveY * Speed);
    }
}
