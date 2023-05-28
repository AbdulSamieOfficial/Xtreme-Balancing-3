using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smoothSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed * Time.deltaTime);
    }
}
