using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -9);
    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
