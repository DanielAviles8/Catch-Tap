using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRed : MonoBehaviour
{
    
    private void Update()
    {
        Score.MeshScore = Mathf.Clamp(Score.MeshScore, 0, 100);
    }  
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("RedArrow"))
        {
            Score.MeshScore = Score.MeshScore + 1;
            print(Score.MeshScore + " actual");
        }
        Destroy(other.gameObject, 0);
    }
}
