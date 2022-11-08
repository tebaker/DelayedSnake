using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyPiece : MonoBehaviour
{
    public SnakeHead instance;
    public int killTimer;

    // Start is called before the first frame update
    void Start()
    {
        killTimer = instance.getBodyLength();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
