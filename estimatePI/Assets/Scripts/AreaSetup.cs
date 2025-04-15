using UnityEngine;

public class AreaSetup : MonoBehaviour {
    public float length = 10f; // 정사각형 한 변의 길이
    public float radius = 5f; // 원의 반지름
    public Transform squareCube; // Cube 오브젝트
    public Transform circleSphere;  // Sphere 오브젝트
    public SampleSpawner sampleSpawner; // sampleSpawner에 정사각형의 크기 전달

    void Start() {
        // 정사각형 크기 조절
        squareCube.localScale = new Vector3(length, 0.05f, length);

        // 원 크기 조절
        circleSphere.localScale = new Vector3(radius * 2f, 0.1f, radius * 2f);

        // sampleSpawner가 뿌릴 sample의 범위 전달
        sampleSpawner.spawnRange = length / 2f;
    }
}
