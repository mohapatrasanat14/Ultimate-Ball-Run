using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour
{
    public Rigidbody rb;
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = rb.position.z.ToString("0");
        rb.AddForce(0f, 0f, 2f);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-1f, 0f, 0f);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(1f, 0f, 0f);
        }

        if (rb.position.y < -5)
        {
            SceneManager.LoadScene(0);
        }
    }
}
