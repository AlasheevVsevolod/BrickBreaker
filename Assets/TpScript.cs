using UnityEngine;

public class TpScript : MonoBehaviour
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
        other.transform.position = new Vector2(other.transform.position.x, -2);
    }
}
