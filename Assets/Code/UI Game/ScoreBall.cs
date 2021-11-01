using UnityEngine;

public class ScoreBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision ball)
    {
        if (ball.gameObject.CompareTag("Brick"))
        {
            Score.MeshScore = Score.MeshScore + 1;
            Destroy(ball.gameObject, 0);
        }
    }
}
