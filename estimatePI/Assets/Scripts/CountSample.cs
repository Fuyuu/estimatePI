using UnityEngine;

public class CountSample : MonoBehaviour {
    private static int total = 0; // 총 sample 수
    private static int circleHits = 0; // 원에 충돌한 sample 수
    private bool hasTriggered = false; // 충돌 여부

    void OnTriggerEnter(Collider other) {
        if (hasTriggered) return;

        hasTriggered = true;
        total++;

        if (other.CompareTag("Circle")) {
            circleHits++;
        }

        float estimatedPi = 4f * (float)circleHits / total;
        Debug.Log($"측정된 Pi 값: {estimatedPi:F4} | 원에 충돌한 Sample: {circleHits} / 총 Sample: {total}");

        Destroy(gameObject, 1f); // 1초 뒤 제거
    }
}
