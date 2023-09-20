using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hovers a game object up and down.
public class Hover : MonoBehaviour
{
    public float amplitude = 0.1f;
    public float frequency = 3f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = startPos + Vector3.up * amplitude * Mathf.Sin(Time.time * frequency);
    }
}
