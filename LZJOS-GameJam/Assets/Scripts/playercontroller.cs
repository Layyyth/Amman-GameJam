using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class playercontroller : MonoBehaviour {
    public float speed;
   

    
    public Rigidbody rb;
   

    
    

    // Start is called before the first frame update
    void Start() {
        
        rb = gameObject.GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update() {
       

        

        //get input from the player
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y); // Modified to include vertical movement
        // move the player
        rb.velocity = moveDir * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.A) )
        {
            
            transform.rotation = Quaternion.Euler(0, -90, 0);
           
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.rotation = Quaternion.Euler(0, 90, 0);

        }


    }
    


}
