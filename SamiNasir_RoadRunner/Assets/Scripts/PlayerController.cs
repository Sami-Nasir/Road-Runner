using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update 
    private float speed=10f;
    private bool gameOver=false;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver==false){
            if(transform.position.x >23){
            transform.position= new Vector3(23,transform.position.y, transform.position.z);
            }else if(transform.position.x<-23){
            transform.position= new Vector3(-23,transform.position.y, transform.position.z);    
            }else{
            float horizontal = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
            transform.Translate(horizontal,0,0);
            float vertical= Input.GetAxis("Vertical")*speed*Time.deltaTime;
            transform.Translate(0,0,vertical);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("Obstacle")){
           gameOver=true;
           Debug.Log("Game Over");
           Player.GetComponent<Renderer>().material.color= Color.black;
       }
    }
}
