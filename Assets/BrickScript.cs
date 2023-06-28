using Unity.Mathematics;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var ballVelocity = other.GetComponent<Rigidbody2D>().velocity;
        if (other.transform.position.x < transform.position.x)
        {
            ballVelocity = new Vector2(-math.abs(transform.position.x - other.transform.position.x) * 3, -math.abs(ballVelocity.y));
        }
        if (other.transform.position.x > transform.position.x)
        {
            ballVelocity = new Vector2(math.abs(transform.position.x - other.transform.position.x) * 3, -math.abs(ballVelocity.y));
        }

        other.GetComponent<Rigidbody2D>().velocity = ballVelocity;

        transform.GetComponent<SpriteRenderer>().enabled = false;
        transform.GetComponent<BoxCollider2D>().enabled = false;
    }
}
