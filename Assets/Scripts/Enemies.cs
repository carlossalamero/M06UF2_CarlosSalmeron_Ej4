using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 4.5f;    
    private int directionX = -1;
    private Rigidbody2D rigiBody;
    public bool isAlive = true;
    private GameManager gameManager;


     void Awake()
    {
        rigiBody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

     void FixedUpdate()
    {
        if(isAlive)
        {

            rigiBody.velocity = new Vector2(directionX * speed, rigiBody.velocity.y);

        }else
        {

            rigiBody.velocity = Vector2.zero;

        }
        
        
    }

     void OnTriggerEnter2D(Collider2D collider)
     {
         
        if(collider.gameObject.CompareTag("Ninja") && directionX == -1){

            directionX = 1;
            transform.rotation = Quaternion.Euler(0,180,0);
                  
        }else if(collider.gameObject.CompareTag("Ninja") && directionX == 1){


            directionX = -1;
            transform.rotation = Quaternion.Euler(0,0,0);

        }
     }
    void OnCollisionEnter2D(Collision2D hit)
    {

        if(hit.gameObject.tag == "Muertepersonaje")
                {
                    
                  
                   gameManager.Muerte();
                   Destroy(hit.gameObject);
                }




    }
        
}
