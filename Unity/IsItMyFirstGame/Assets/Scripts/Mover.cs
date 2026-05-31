using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speedValue = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstruction();
    }

    void Update()
    {
        moveDodgy();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game playa!");
    }

    void moveDodgy()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, z) * speedValue;

        rb.linearVelocity = new Vector3(
            movement.x,
            movement.y,
            movement.z
        );
    }
}