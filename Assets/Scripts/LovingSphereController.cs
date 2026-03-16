using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LovingSphereController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float moveSpeed = 10f;

    [SerializeField]
    private float jumpHeight = 10f;

    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horiMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        rb.AddForce(horiMovement, 0, 0, ForceMode.VelocityChange);
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(0f, jumpHeight, 0f, ForceMode.VelocityChange);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        this.isGrounded = false;

        if (collision.gameObject.name.Contains("Purple"))
        {
            Debug.Log("friday_im_in_love");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        this.isGrounded = true;
    }
}
