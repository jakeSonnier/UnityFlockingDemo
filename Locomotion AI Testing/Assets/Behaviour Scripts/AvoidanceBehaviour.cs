using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Avoidance")]
public class AvoidanceBehaviour : FlockBehaviour
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //If no neighbors are nearby, no need to update
        if (context.Count == 0)
        {
            return Vector3.zero;
        }

        //Add all nearby points together
        Vector3 avoidanceMove = Vector3.zero;
        int inAvoid = 0;
        foreach (Transform item in context)
        {
            if (Vector3.SqrMagnitude(item.position - agent.transform.position) < flock.SquareAvoidanceRadius)
            {
                inAvoid++;
                avoidanceMove += (agent.transform.position - item.position);
            } 
        }

        if (inAvoid > 0)
        {
            avoidanceMove /= inAvoid;
        }

        return avoidanceMove;
    }
}
