using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBlue : MonoBehaviour
{
    void OnCollisionEnter(Collision blue)
    {
        if(blue.gameObject.CompareTag("BlueArrow"))
        {
            Score.MeshScore = Score.MeshScore + 1;
            print(Score.MeshScore + " actual");        
        }
    }
}
