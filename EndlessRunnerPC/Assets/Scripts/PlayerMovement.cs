using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody rb;
    public float forwardSpeed = 200f;
    public float sidewaySpeed = 80f;
    public float jumpForce = 1f;
    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    private void Update() {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        rb.AddForce(sidewaySpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0, ForceMode.VelocityChange);
        if (transform.position.y < 0.01 && Input.GetKey(KeyCode.Space)) rb.AddForce(0, jumpForce, 0);
        if (transform.position.x > 8.85f || transform.position.x < -8.85f) FindObjectOfType<GameManager>().GameOver();
    }
}