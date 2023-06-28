using Unity.Mathematics;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    private int moveSpeed = 15;

    private const float leftBorder = -9.5f;
    private const float rightBorder = 9.5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");

        if (leftBorder < transform.position.x && movement < 0)
        {
            transform.position = new Vector3(transform.position.x - math.abs(movement) * Time.deltaTime * moveSpeed, transform.position.y);
        }
        if (rightBorder > transform.position.x && movement > 0)
        {
            transform.position = new Vector3(transform.position.x + math.abs(movement) * Time.deltaTime * moveSpeed, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var ballVelocity = other.GetComponent<Rigidbody2D>().velocity;
        if (other.transform.position.x < transform.position.x)
        {
            ballVelocity = new Vector2(-math.abs(transform.position.x - other.transform.position.x) * 3, math.abs(ballVelocity.y));
        }
        if (other.transform.position.x > transform.position.x)
        {
            ballVelocity = new Vector2(math.abs(transform.position.x - other.transform.position.x) * 3, math.abs(ballVelocity.y));
        }

        other.GetComponent<Rigidbody2D>().velocity = ballVelocity;
    }
}
