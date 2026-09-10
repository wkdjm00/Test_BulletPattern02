using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float yOffset = 3f;


    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        transform.position = new Vector3(transform.position.x, target.position.y + yOffset, transform.position.z);
    }

}
