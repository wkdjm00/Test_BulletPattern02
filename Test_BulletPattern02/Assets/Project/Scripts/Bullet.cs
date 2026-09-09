using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void Start()
    {
        //DestroySelf(gameObject, 0.5f);
        Invoke("DestroySelf", 1f);
        //DestroySelf();
    }
}
