using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    private Animator _anim;
    public bool isGrounded = true;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        isGrounded = transform.position.y <= 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = transform.forward * speed;
            _anim.SetBool("isWalking", true);
        }
        else
        {
            _anim.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-transform.up);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rb.AddForce(transform.up * 1000);
            _anim.SetBool("isFlying", true);
        }
        else
        {
            _anim.SetBool("isFlying", !isGrounded);
        }
    }
}
