using UnityEngine;

namespace UnityTemplateProjects
{
    public class SimpleCameraController : MonoBehaviour
    {
        [SerializeField]
        Joystick joystickMovement;
        [SerializeField]
        Joystick joystickRotation;

        void Update()
        {
            this.transform.rotation *= Quaternion.Euler(new Vector3(joystickRotation.Vertical * -1f, joystickRotation.Horizontal * 1f));
            this.transform.Translate(new Vector3(joystickMovement.Horizontal * 0.1f, 0, joystickMovement.Vertical * 0.1f));
        }
    }

}