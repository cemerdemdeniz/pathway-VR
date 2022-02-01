using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteractWithFollower : MonoBehaviour 
{
    void OnTriggerEnter(Collider other)
    {
        IInteractableWithObstacle interactable = other.gameObject.GetComponent<IInteractableWithObstacle>();
        if (interactable != null)
        {
            interactable.InteractObstacle();
            
        }
    }
}
