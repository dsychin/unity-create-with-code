using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if ((transform.position.x < -xRange && horizontalInput < 0) ||
            (transform.position.x > xRange && horizontalInput > 0)) {
            return;
        }
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }
}
