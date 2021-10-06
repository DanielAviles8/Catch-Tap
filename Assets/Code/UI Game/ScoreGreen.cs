using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGreen : MonoBehaviour
{
    void OnCollisionEnter(Collision green)
    {
        if(green.gameObject.CompareTag("GreenArrow"))
        {
            Score.MeshScore = Score.MeshScore + 1;
            print(Score.MeshScore + " actual");        
        }
        Destroy(green.gameObject, 0);
    }
}
