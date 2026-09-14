using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    // 구역(Area)의 길이: 구역 프리팹을 제작할 때 이 길이에 맞춰서 제작
    private readonly float areaLength = 18f;

    [SerializeField]
    private GameObject areaPrefab;

    [SerializeField]
    private Transform spawnPoint;

    private int areaCount = 0;

    private void Awake()
    {

    }
}