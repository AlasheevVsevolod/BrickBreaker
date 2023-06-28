using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var bricks = GameObject.FindGameObjectsWithTag("Bricks");
        if (!bricks.Any(go => go.GetComponent<BoxCollider2D>().enabled))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
