using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Alignment")]
public class AlignmentBehavious : FlockBehaviour
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //If no neighbors are nearby, maintain current alignment
        if (context.Count == 0)
        {
            return agent.transform.position;
        }

        //Add all nearby points together
        Vector3 alignmentMove = Vector3.zero;
        foreach (Transform item in context)
        {
            alignmentMove += item.transform.position;
        }
        alignmentMove /= context.Count;

        return alignmentMove;
    }
}
