using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointTriggerGreen : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Gun gun;

    void Start()
    {
        gun = GameObject.Find("Gun").GetComponent<Gun>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        gun.EnterGreenObstacle();
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
   
   

   
}
