using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovingScript : MonoBehaviour
{
    [SerializeField]
    GameObject objectToRotateAround;
    [SerializeField]
    float theta = 0.1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(objectToRotateAround.transform.position, Vector3.right, theta);
    }
}
