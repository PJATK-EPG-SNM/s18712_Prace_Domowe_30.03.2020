using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMonster : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveRight = true;


    void Update()
    {
        if (transform.position.x > 1f)
            moveRight = false;
        if (transform.position.x < -3f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }

}
