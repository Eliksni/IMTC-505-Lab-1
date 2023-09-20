using System.Collections;
using System.Collections.Generic;
using IMTC505.starter.SampleGame;
using UnityEngine;

// Rotates a game object based on the points, starting with no rotation.
public class ObjectRotate : MonoBehaviour
{
    public GameManager gameManager;
    public float rotationSpeed = 5f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * gameManager.GetPoints());
    }
}
