using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float deadZone = -15f; // Ekranýn sol sýnýrý

    void Update()
    {
        // 1. Sola Git
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // 2. Sýnýrý geçtin mi?
        if (transform.position.x < deadZone)
        {
            // Destroy YOK! Sadece gizle ki havuza geri dönsün.
            gameObject.SetActive(false);
        }
    }
}