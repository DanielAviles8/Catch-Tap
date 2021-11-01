using UnityEngine;

public class Bricks : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 0);        
    }
}
