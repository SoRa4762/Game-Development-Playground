using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "isHit")
        {
            Debug.Log("Oops! You just bumped into something...");
            ++score;
            Debug.Log("Score so far: " + score);
        }
    }
}
