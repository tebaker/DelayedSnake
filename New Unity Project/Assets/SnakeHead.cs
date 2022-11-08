using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DIRECTION
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}

public class SnakeHead : MonoBehaviour
{
    // directionFrom and directionTo is used to help determine proper orientation of L piece of snake body
    public DIRECTION directionFrom;
    public DIRECTION directionTo;
    
    public float moveAmount; // Amount snake moves in one valid key press
    public int bodyLength; // Used to help update trailing tail

    // Start is called before the first frame update
    void Start()
    {
        directionFrom = DIRECTION.UP;
        directionTo = DIRECTION.UP;
        moveAmount = 1F;
        bodyLength = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow) && directionFrom != DIRECTION.DOWN)
        {
            // Setting position and rotation to new
            this.transform.position = new Vector3(
                this.transform.position.x,
                this.transform.position.y + moveAmount,
                this.transform.position.z
            );
            directionTo = DIRECTION.UP;
            this.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && directionFrom != DIRECTION.UP)
        {
            this.transform.position = new Vector3(
                this.transform.position.x,
                this.transform.position.y - moveAmount,
                this.transform.position.z
            );
            directionTo = DIRECTION.DOWN;
            this.transform.eulerAngles = new Vector3(0, 0, 180);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && directionFrom != DIRECTION.RIGHT)
        {
            this.transform.position = new Vector3(
                this.transform.position.x - moveAmount,
                this.transform.position.y,
                this.transform.position.z
            );
            directionTo = DIRECTION.LEFT;
            this.transform.eulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) && directionFrom != DIRECTION.LEFT)
        {
            this.transform.position = new Vector3(
                this.transform.position.x + moveAmount,
                this.transform.position.y,
                this.transform.position.z
            );
            directionTo = DIRECTION.RIGHT;
            this.transform.eulerAngles = new Vector3(0, 0, -90);
        }

        // Updating directionFrom for next update
        directionFrom = directionTo;
    }

    public int getBodyLength()
    {
        return this.bodyLength;
    }
}
