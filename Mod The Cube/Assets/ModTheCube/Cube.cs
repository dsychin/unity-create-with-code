using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rotateSpeed = 10f;
    public Vector3 expandSize = new Vector3(0.001f, 0.001f, 0.001f);
    public float colorChangeInterval = 0.2f;
    private float nextColorChange;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
        transform.localScale += expandSize;

        if (Time.time > nextColorChange)
        {
            nextColorChange = Time.time + colorChangeInterval;
            Renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
