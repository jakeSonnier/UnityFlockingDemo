using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeking : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3.0f;
    private float minDistance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SeekTarget();
    }

    //Move object towards target object
    void SeekTarget()
    {
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude > minDistance)
        {
            Vector3 moveVector = direction.normalized * moveSpeed * Time.deltaTime;

            transform.position += moveVector;
        }
    }
}
