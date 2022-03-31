using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 initialPos;
    private float backgroundWidth;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < initialPos.x - (backgroundWidth / 2))
        {
            transform.position = initialPos;
        }
    }
}
