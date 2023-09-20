using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDistance : MonoBehaviour
{
    public Transform player;
    public Color closeColor = Color.green;
    public Color farColor = Color.white;
    public float maxDistance = 5f;

    private Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        float t = Mathf.Clamp01(distance / maxDistance);
        renderer.material.color = Color.Lerp(closeColor, farColor, t);
    }
}
