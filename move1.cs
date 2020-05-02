using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour{
    public Rigidbody2D tar;
    public GameObject bullte;
    void Start()
    {
        
    }
    void Update(){
        
        /*移動*/{if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-0.1f, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(0.1f, 0, 0);
        if (Input.GetKey(KeyCode.Space)){
            tar.AddForce(new Vector2(0,1),ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.J)){
            Instantiate(bullte,transform.position,new Quaternion(0,0,0,0));
        }
        }
        
    }
    void OnCollisionEnter2D(Collision2D Coll){
        if(Coll.gameObject.tag == "DONTOUCHIT")
            tar.AddForce(new Vector2(0,20),ForceMode2D.Impulse);
            Coll.Rigidbody2D.AddForce(new Vector2(0,-5),ForceMode2D.Impulse);
         
    }
}
