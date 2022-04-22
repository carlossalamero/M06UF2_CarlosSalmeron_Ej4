using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 10f;
    public bool tocaSuelo;
    float dirx; 
    public SpriteRenderer renderer;
    public Animator animatronix;
    Rigidbody2D rBody;
    //private GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {

        animatronix = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
     void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        
        Debug.Log(dirx);

         if(dirx == -1)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
            animatronix.SetBool("Andar", true);
        }
        else if(dirx == 1)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            animatronix.SetBool("Andar", true);
        }
        else
        {
            animatronix.SetBool("Andar", false);
        }
        
        if(Input.GetButtonDown("Jump") && tocaSuelo) 
        {

            rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); 
            animatronix.SetBool("Salto", true);

        }
    
    }
    
    void FixedUpdate()
    {

        rBody.velocity = new Vector2(dirx * speed, rBody.velocity.y);

    }

}
