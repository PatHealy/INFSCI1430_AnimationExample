using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    public float speed;
    private Animator _anim;
    private SpriteRenderer _rend;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed);
            _anim.SetBool("isMoving", true);
            _rend.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed);
            _anim.SetBool("isMoving", true);
            _rend.flipX = false;
        }
        else
        {
            _anim.SetBool("isMoving", false);
        }
    }
}
