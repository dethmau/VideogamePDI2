using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxspeed = 5f;
    public float speed = 2f;
    public bool grounded;
    public float jumpPower = 6.5f;

    private Rigidbody2D rg2d;
    private Animator anim;
    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", Mathf.Abs(rg2d.velocity.x));
        anim.SetBool("grounded", grounded);

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rg2d.AddForce(Vector2.right * speed * h);

        if (rg2d.velocity.x > maxspeed)
        {
            rg2d.velocity = new Vector2(maxspeed, rg2d.velocity.y);
        }
        if (rg2d.velocity.x < -maxspeed)
        {
            rg2d.velocity = new Vector2(-maxspeed, rg2d.velocity.y);
        }

        if (h < 0.1f)
        {
            transform.localScale = new Vector3(0.3393007f, 0.3393007f, 0.3393007f);
        }

        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-0.3393007f, 0.3393007f, 0.3393007f);
        }

        if (jump)
        {
            rg2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }

        Debug.Log(rg2d.velocity.x);
    }
}
