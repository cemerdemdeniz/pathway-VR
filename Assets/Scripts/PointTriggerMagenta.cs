using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointTriggerMagenta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    Gun gun;

    public void OnPointerEnter(PointerEventData eventData)
    {
        gun.EnterMagentaObstacle();
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
    void Start()
    {
        gun = GameObject.Find("Gun").GetComponent<Gun>();
    }

    void Update()
    {
        
    }
}
