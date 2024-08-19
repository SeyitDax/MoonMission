using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRoverMovement : MonoBehaviour
{
    public bool leverRight;
    public bool leverLeft;

    Transform moonRover;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        moonRover = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = speed * Time.deltaTime;

        Vector3 newPosition = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= moveAmount;  // Move left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += moveAmount;  // Move right
        }

        transform.position = newPosition;
    }
}

