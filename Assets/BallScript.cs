using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
