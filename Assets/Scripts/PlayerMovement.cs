using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jump_force = 1f;
    public float speed = 1.0f;

    bool is_jumping = false;

    private Rigidbody rb;
    private BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = GetInput();
        rb.velocity = input;

        if(Input.GetKeyDown(KeyCode.Space) && is_jumping == false)
        {
            rb.AddForce(transform.up * jump_force, ForceMode.Impulse);
            is_jumping = true;
        }
    }

    Vector3 GetInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        return new Vector3(x, rb.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            is_jumping = false;
        }
    }
}
