using UnityEngine;

public class CameraOrThographicSize : MonoBehaviour
{
    private void Awake()
    {
        float screenAspectRatio = (float)Screen.width / (float)Screen.height;
        float orthographicSize = (float)(6 - (screenAspectRatio - 0.485f) * 11f);

        if (orthographicSize < 4f)
        {
            orthographicSize = 4f;
        }

        Camera.main.orthographicSize = orthographicSize;

    }
}
