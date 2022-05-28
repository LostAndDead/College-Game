using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController2D controller;
    public float speed;
    public PhysicsMaterial2D noFriction;
    public PhysicsMaterial2D highFriction;
    public Transform m_GroundCheck;
    public LayerMask m_WhatIsGround;

    float horizontalMove = 0f;
    bool jump = false;
    bool m_Grounded;
    float k_GroundedRadius = .2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameValues.damageCoolDown > 0){
            GameValues.damageCoolDown--;
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        Rigidbody2D body = GetComponent<Rigidbody2D>();

        if(horizontalMove != 0 || !m_Grounded){
            body.sharedMaterial = noFriction;
        }else{
            body.sharedMaterial = highFriction;
        }

        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
    }

    void FixedUpdate()
    {
        bool wasGrounded = m_Grounded;
		m_Grounded = false;

		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		// This can be done using layers instead but Sample Assets will not overwrite your project settings.
		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				m_Grounded = true;
			}
		}

        controller.Move(horizontalMove * Time.deltaTime, false, jump);
        jump = false;
    }

    void Spawn(){
        transform.position = GameObject.Find("SpawnPoint").transform.position;
        horizontalMove = 0;
        jump = false;
    }
}
