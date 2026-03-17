using UnityEngine;

public class LovingSphere : MonoBehaviour
{
    protected Rigidbody rb;
    [SerializeField]
    protected float moveSpeed = 10f;

    [SerializeField]
    protected float jumpHeight = 10f;

    protected bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        var horiMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        rb.AddForce(horiMovement, 0, 0, ForceMode.VelocityChange);
    }


    private void OnCollisionEnter(Collision collision)
    {
        this.isGrounded = false;

        if (collision.gameObject.name.Contains("Pink"))
        {
            Debug.Log("gonna_take_alotta_love");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        this.isGrounded = true;
    } 
}