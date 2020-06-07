using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    float position;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
        this.position = 0.01f+ 0.1f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(position, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);
    

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);

        }
    }
}



