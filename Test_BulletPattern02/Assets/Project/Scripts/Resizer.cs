using System.Collections;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField]
    private Vector3 start;
    [SerializeField]
    private Vector3 end;
    [SerializeField]
    private float resizeTime = 1f;

    private void OnEnable()
    {
        StartCoroutine(nameof(Process));
    }

    private void OnDisable()
    {
        StopCoroutine(nameof(Process));
    }

    IEnumerator Process()
    {
        while (true)
        {
            yield return StartCoroutine(ScalerTo(start, end));

            yield return StartCoroutine(ScalerTo(end, start));
        }
    }

    IEnumerator ScalerTo(Vector3 from, Vector3 to)
    {
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime / resizeTime;
            transform.localScale = Vector3.Lerp(from, to, percent);
            yield return null;
        }
    }
}
