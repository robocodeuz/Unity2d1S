using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed  = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake(){
        rb = GetComponent<RigidBody2D>();

    }
     private void FixedUpdate(){
        moveH = Input.GetAxis("Horizontal")* moveSpeed;
        moveV = Input.GetComponent("Vertical")* moveSpeed;
        rb.velocity =new Vector2(moveH, moveV);

     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
