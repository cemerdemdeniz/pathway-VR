using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerBlue : MonoBehaviour, IPointerEnterHandler
{

    public GameObject gun;
    public Gun _gun;
    private void Start()
    {      
        _gun = gun.GetComponent<Gun>();

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
       
       _gun.EnterBlueObstacle();

    }
}
