using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    //This script is basically used to move the obstacle to the right
    public float speed=5f;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.right * Time.deltaTime * speed);
    }
}
