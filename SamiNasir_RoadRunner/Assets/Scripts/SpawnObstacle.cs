using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject gobject;
    // variable pos is used to point a location on which objects are need to spawn
    private Vector3 pos=new Vector3(-23,1,-10);
    private Vector3 pos2=new Vector3(-23,1,-50);
    private Vector3 pos3=new Vector3(-23,1,20);
    private Vector3 pos4=new Vector3(-23,1,100);
    private float speed=1f;
    private float delay1=5f;
    private float delay2=7f;
    private float delay3=4f;
   // private PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("CreatFunc",speed,delay1);
        InvokeRepeating("CreatFunc2",speed,delay2);
        InvokeRepeating("CreatFunc3",speed,delay3);
        InvokeRepeating("CreatFunc4",speed,delay2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreatFunc(){
        Instantiate(gobject,pos,gobject.transform.rotation);
    }
    void CreatFunc2(){
        Instantiate(gobject,pos2,gobject.transform.rotation);
    }
    void CreatFunc3(){
        Instantiate(gobject,pos3,gobject.transform.rotation);
    }
    void CreatFunc4(){
        Instantiate(gobject,pos4,gobject.transform.rotation);
    }
}
