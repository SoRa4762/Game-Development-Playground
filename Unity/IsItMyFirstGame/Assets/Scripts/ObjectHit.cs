using UnityEngine;

public class Objecthit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Something bumped into me!");
            Debug.Log("Time to change the color now!");
            GetComponent<MeshRenderer>().material.color = Color.teal;
            gameObject.tag = "isHit";
        }
    }
}
