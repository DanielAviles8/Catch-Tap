using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float speed;
    private float timerInstantiate;
    public GameObject[] Arrows = new GameObject[4];

    private float timerBegin = 0;
    float waitTime;
    private Vector3 inicialPos;
    void Start()
    {
        inicialPos = this.transform.position;
    }
    private void Update()
    {
        if(timerBegin > waitTime)
        {
            CreateArrow();
            timerBegin = 0;
        }
        else
        {
            timerBegin += Time.deltaTime;
        }
    }
    void CreateArrow()
    {
        GameObject Selected = Arrows[Random.Range(0,5)];
        GameObject newArrow = Instantiate(Selected);
        newArrow.transform.position = inicialPos;
        newArrow.transform.rotation = this.transform.rotation;
        newArrow.GetComponent<Rigidbody>().velocity = transform.up * speed;
        waitTime = Random.Range(1, 10);
    }
}
