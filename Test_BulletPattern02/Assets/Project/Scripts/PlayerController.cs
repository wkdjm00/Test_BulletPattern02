using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float RotateSpeed = 100f;
    public GameObject BulletPrefab;
    public float BulletSpeed = 10f;

    void Update()
    {
        // 방향키로 좌우 시선 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -RotateSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, RotateSpeed * Time.deltaTime, 0f);
        }

        // 탄환 3개 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 1; i <= 3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);

                Bullet.transform.position =
                    transform.position + transform.forward * (i * 0.5f);

                Bullet.GetComponent<Rigidbody>().AddForce(
                    transform.forward * BulletSpeed
                );
            }
        }
    }
}