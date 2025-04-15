using UnityEngine;

public class SampleSpawner : MonoBehaviour {
    public GameObject Sample;
    public float spawnRange = 5f; // sample이 생성되는 범위 -> AreaSetup에서 전달받음
    public float spawnHeight = 5f; // sample을 떨어뜨리는 높이
    public float spawnInterval = 0.005f; // sample을 떨어뜨리는 간격
    void Start() {
        InvokeRepeating(nameof(spawnSample), 0f, spawnInterval);
    }

    void spawnSample() {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(randX, spawnHeight, randZ);

        Instantiate(Sample, spawnPos, Quaternion.identity);
    }
}
