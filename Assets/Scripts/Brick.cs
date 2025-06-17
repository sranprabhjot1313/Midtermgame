using UnityEngine;

public class BrickMover : MonoBehaviour
{
    public float speed = 2f;
    public float moveRange = 3f;

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = speed * Time.deltaTime;

        if (movingRight)
            transform.Translate(Vector3.right * movement);
        else
            transform.Translate(Vector3.left * movement);

        if (Vector3.Distance(transform.position, startPos) >= moveRange)
            movingRight = !movingRight;
    }
}
