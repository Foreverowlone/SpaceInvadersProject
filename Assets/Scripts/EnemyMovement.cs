using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    bool goRight = true;
    Vector3 downMove = new Vector3(0, -1, 0);
    public Transform transform;
    float leftBoundary = -9;
    float rightBoundary = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x >= rightBoundary) || (transform.position.x <= leftBoundary))
        {
            // A boundary has been reached; swap the travel direction and move down a level.
            goRight = !goRight;
            goDown();
            print("Switching directions; now moving " + (goRight ? "Right" : "Left"));
        }
        Move(goRight);
    }

    void Move(bool moveRight)
    {
        float movementX = moveRight ? speed : -speed;
        transform.Translate(new Vector3(movementX * Time.deltaTime, 0, 0));
    }

    void goDown()
    {
        transform.Translate(downMove);
    }
}
