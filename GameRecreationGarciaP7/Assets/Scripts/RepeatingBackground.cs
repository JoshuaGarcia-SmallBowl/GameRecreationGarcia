using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundhorizontalLength;
    public float spawndistance = 4f;
    // Start is called before the first frame update

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundhorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundhorizontalLength)
        {
            Repositionbackground();
        }
        
    }
    public void Repositionbackground()
    {
        Vector2 groundOffset = new Vector2 (groundhorizontalLength * spawndistance, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }

}
