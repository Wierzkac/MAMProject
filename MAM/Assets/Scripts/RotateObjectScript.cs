using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject obiekt;

    // Update is called once per frame
    void Update()
    {
        obiekt.transform.Rotate(1f, 0, 0, Space.World);
    }
}
