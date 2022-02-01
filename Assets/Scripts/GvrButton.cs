using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GvrButton : MonoBehaviour
{
    public Image fillCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    public float gvrTimer;
    bool gvrStatus;   

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            fillCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            GVRClick.Invoke();
        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        fillCircle.fillAmount = 0;
    }
}
