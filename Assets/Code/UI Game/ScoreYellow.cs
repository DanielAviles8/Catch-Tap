using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreYellow : MonoBehaviour
{
    void OnCollisionEnter(Collision yellow)
    {
        if(yellow.gameObject.CompareTag("YellowArrow"))
        {
            Score.MeshScore = Score.MeshScore + 1;
            print(Score.MeshScore + " actual");        
        }
        Destroy(yellow.gameObject, 0);
    }
}
