using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = -10;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(speed, 0, 0);
    }
}
