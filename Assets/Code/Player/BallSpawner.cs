using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float speed;
    public bool ExistBall;
    public GameObject[] Balls = new GameObject[4];

    private Vector3 initialPos;
    private void Start()
    {
        initialPos = this.transform.position;
        ExistBall = true;
    }
    private void Update()
    {
        if(ExistBall == true)
        {
            CreateBall();
        }
    }
    void CreateBall()
    {
        GameObject Selected = Balls[Random.Range(0, 4)];
        GameObject newBall = Instantiate(Selected);
        newBall.transform.position = initialPos;
        newBall.transform.rotation = this.transform.rotation;
        newBall.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        ExistBall = false;
    }
}
