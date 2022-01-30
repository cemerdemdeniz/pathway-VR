using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Obstacle : MonoBehaviour 
{  
      

    public List<Material> allMaterials = new List<Material>();

    public Renderer[] allChildRenderers;

   

    void Start()
    {       
       
        allChildRenderers = GetComponentsInChildren<Renderer>();

        for (int i = 0; i < allChildRenderers.Length; i++)
        {
            foreach (Material mat in allChildRenderers[i].materials)
            {
                allMaterials.Add(mat);
            }
        }
       
       
    }
   



}
