using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
