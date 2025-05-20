using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    [SerializeField] private float MaxDistance;
    [SerializeField] private float speed;
    private Vector3 StartPosition;


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 nv = (new Vector3(h, v, 0)).normalized;

        transform.position = transform.position + speed * Time.deltaTime * nv;

        float Distanza = Vector3.Distance(transform.position, StartPosition);
        if(Distanza > MaxDistance)
        {
            transform.position = new Vector3(0, 0, 0);
        } 
    }
}
