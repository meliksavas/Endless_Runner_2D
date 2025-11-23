using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    private float groundWidth;

    private void Start()
    {
        groundWidth = GetComponent<BoxCollider2D>().bounds.size.x;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -groundWidth)
        {
            Vector2 currentPos = transform.position;
            currentPos.x += 2 * groundWidth; 
            transform.position = currentPos;
        }
    }
}
