using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public float shootForce;

    public Camera cam;

    public Transform attackPoint;

    Material m_Material;    

    private void Start()
    {
        m_Material = GetComponent<Renderer>().material;      
    }

    public void EnterBlueObstacle()
    {
        if (m_Material.color == Color.blue)
        {
            Fire(true);
        }

    }
   
    public void EnterGreenObstacle()
    {
        
        if (m_Material.color == Color.green)
        {
            Fire(true);
        }
       
    }
   
    public void EnterMagentaObstacle()
    {
        
        if (m_Material.color == Color.magenta)
        {
           
            Fire(true);
        }

    }
    public bool Fire(bool check)
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75);

        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);

        currentBullet.transform.forward = directionWithoutSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithoutSpread.normalized * shootForce, ForceMode.Impulse);

        return check;
    }

   





}



