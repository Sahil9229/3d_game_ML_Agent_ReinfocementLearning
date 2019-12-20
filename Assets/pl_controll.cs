using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl_controll : MonoBehaviour
{
    
    Animator anim;
    Rigidbody rb;
    CapsuleCollider col_size;

    Vector3 moveDir=Vector3.zero;
    CharacterController controller;


    private float speed=8;	
    private float rotspeed=80F;
    private float rot=0F;
    private float gravity=80;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody>();
        col_size=GetComponent<CapsuleCollider>();
       // isGrounded=true; 


    }

     public void p_run()
     { }


    // Update is called once per frame
    void Update()
    {
    	var z=Input.GetAxis("Vertical")*speed;
    	var y=Input.GetAxis("Horizontal")*rotspeed;
      if(controller.isGrounded){
    	if (Input.GetKey (KeyCode.W))
    	 {
           anim.SetInteger("condition",1);
           moveDir=new Vector3(0,0,1);
           moveDir*=speed; 
           moveDir= transform.TransformDirection(moveDir);
           //anim.SetTrigger("running");

    	 }
        
    	if(Input.GetKeyUp(KeyCode.W))
    	{
    		anim.SetInteger("condition",0);
        moveDir=new Vector3(0,0,0);
    	}
      }
    	rot+=Input.GetAxis("Horizontal")*rotspeed*Time.deltaTime;
    	transform.eulerAngles=new Vector3(0,rot,0);

    	moveDir.y -= gravity*Time.deltaTime;
    	controller.Move(moveDir*Time.deltaTime);

        
    }
}
