using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFPSScript : MonoBehaviour
{
    [SerializeField]
    Text display_Text;

    public void Update()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        display_Text.text = current.ToString() + " FPS";
    }
}
