using UnityEngine;

public class Dropper : MonoBehaviour
{
    float waitTime = 0.1f;
    // apparently this is caching
    Rigidbody rb;
    MeshRenderer mr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        rb.useGravity = false;
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float airTime = Time.time;
        // Debug.Log("Air Time: " + airTime);
        if (airTime > waitTime)
        {
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
