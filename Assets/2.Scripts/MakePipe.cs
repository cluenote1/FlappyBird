using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;
    float timer;
    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(4.97f, Random.Range(-3.34f, 1.82f),0);
            timer = 0;
        }
    }
}
