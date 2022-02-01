using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourOnPoint : MonoBehaviour
{  
    private void OnTriggerEnter(Collider col)
    {
        IBehaviourOnPoint onPoint = col.gameObject.GetComponent<IBehaviourOnPoint>();
        if (onPoint != null)
        {
            onPoint.BehaveOnPoint();            
        }
    }
}
