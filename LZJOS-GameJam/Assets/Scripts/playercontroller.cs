using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class playercontroller : MonoBehaviour {
    public float speed;
    public float groundDist;

    public LayerMask terrainLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;

    public Animator animator;

    

    // Start is called before the first frame update
    void Start() {
        
        rb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        RaycastHit hit;
        Vector3 castPos = transform.position;
        castPos.y += 1;

        if (Physics.Raycast(castPos, -transform.up, out hit, Mathf.Infinity, terrainLayer)) {
            if (hit.collider != null) {
                Vector3 movePos = transform.position;
                movePos.y = hit.point.y + groundDist;
                transform.position = movePos;
            }
        }

        //get input from the player
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y); // Modified to include vertical movement
        // move the player
        rb.velocity = moveDir * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.A) )
        {
            
            transform.rotation = Quaternion.Euler(0, -90, 0);
            animator.SetBool("walking",true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.rotation = Quaternion.Euler(0, 90, 0);

        }


    }
    


}
