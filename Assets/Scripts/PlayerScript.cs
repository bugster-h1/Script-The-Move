using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Range(0, .3f)]
    [SerializeField]
    private float m_MovementSmoothing = .05f;
    public float movementSpeed;

    private Rigidbody2D m_Rigidbody2D;
    private Vector3 m_Velocity = Vector3.zero;
    private float movement;

    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
	{
        ResetState();
	}

    private void FixedUpdate()
	{
        Move(movement);
	}

    private void Move(float movement)
	{
        Vector3 targetVelocity = new Vector2(movement * movementSpeed, m_Rigidbody2D.velocity.y);
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    }

    private void OnTriggerEnter2D(Collider2D col)
	{
		if (transform.position.y < -5)
		{
            ResetState();
        }

        movement *= -1;
	}

    private void ResetState()
	{
        transform.position = new Vector3(-1.65f, 5.2f, 0f);
        movement = 1;
    }
}
