
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet;
    public Vector3 velocity = Vector3.zero;

    public bool rotate = true;
    public float rotateSpeed = 5.0f;
    

    private void LateUpdate()
    {

        if (rotate)
        {
            Quaternion camTurn = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotateSpeed, Vector3.up);

            offSet = camTurn * offSet;
        }

        Vector3 desiredPosition = target.position + offSet;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);


    } 

}
