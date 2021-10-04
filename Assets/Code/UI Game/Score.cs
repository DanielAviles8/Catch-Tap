using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static float meshScore;
    public static float MeshScore
    {
        get{return meshScore;}
        set{meshScore = value;}
    }
    [SerializeField] private Text score;
    private void Update()
    {
        score.text = meshScore.ToString();
    }
}
