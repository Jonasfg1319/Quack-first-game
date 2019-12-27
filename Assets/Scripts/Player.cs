using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    Rigidbody2D rb;
    Animator anim;
    public bool Onground = true;
    float jumpforce = 500f;
    public Transform groundcheck;
    public bool facinright = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Onground = Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer("Ground"));
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        anim.SetFloat("walk", Mathf.Abs(h));

        if (Onground)
        {
            if (Input.GetButtonDown("Jump")) {

                rb.AddForce(jumpforce * Vector2.up);
            }
        }

        if (h < 0 && facinright) {

            flip();
        }

        else if (h > 0 && !facinright) {

            flip();
        }
    }

    void flip() {
        facinright = !facinright;
        transform.Rotate(new Vector3(0,180, 0));
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("migo"))
        {
            SceneManager.LoadScene("End");
        }

        if (col.gameObject.CompareTag("espinho"))
        {
            SceneManager.LoadScene("Game Over");
        }

        if (col.gameObject.CompareTag("bola"))
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
