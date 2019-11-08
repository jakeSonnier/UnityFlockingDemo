using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursuing : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3.0f;
    private float minDistance = 3.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OffsetPursueTarget();
    }

    //Move object towards target object
    void OffsetPursueTarget()
    {
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude > minDistance)
        {
            Vector3 moveVector = direction.normalized * moveSpeed * Time.deltaTime;

            transform.position += moveVector;
        }
    }
}