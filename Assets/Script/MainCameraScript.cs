using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public Transform ballPos;
    public Vector3 distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ballPos.position-distance;
    }
}
