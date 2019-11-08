using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Cohesion")]
public class CohesionBehaviour : FlockBehaviour
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //If no neighbors are nearby, no need to update
        if (context.Count == 0)
        {
            return Vector3.zero;
        }

        //Add all nearby points together
        Vector3 cohesionMove = Vector3.zero;
        foreach (Transform item in context)
        {
            cohesionMove += item.position;
        }
        cohesionMove /= context.Count;

        //Offset from current agent position
        cohesionMove -= agent.transform.position;
        return cohesionMove;
    }
}