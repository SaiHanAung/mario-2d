using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monCont1 : MonoBehaviour
{
    float dirX, moveSpeed = 2f;
    bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 6f)
            moveRight = false;
        if (transform.position.x < 2f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }
}