using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{   
    void OnTriggerEnter(Collider other)
    {
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();       
        if (interactable != null)
        {
            interactable.TakeDamage();           
        }
    }
}
