using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Gun gun;
    public void OnPointerEnter(PointerEventData eventData)
    {
        StartCoroutine(OnPointerEnter(1));

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    void Start()
    {
        gun = GameObject.Find("Gun").GetComponent<Gun>();
    }
    IEnumerator OnPointerEnter(float delay)
    {
        yield return new WaitForSeconds(delay);
        gun.EnterBlueObstacle();


    }
}
