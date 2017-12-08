using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const float Y_ANGLE_MIN = -35.0f;
    private const float Y_ANGLE_MAX = -34.0f;

    public Transform lookAt;
    public Transform camTransform;
    

    private Camera cam;

    private float distance = 2.0f;
    private float currentX = 40.0f;
    private float currentY = 30.0f;
    private float sensivityX = 10.0f;
    private float sensivityY = 0.0f;
    

    private void start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {

        if (Time.timeScale == 1)
        {
            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");

            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(2, 5, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;

        camTransform.LookAt(lookAt.position);
    }

    
}
