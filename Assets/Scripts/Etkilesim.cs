using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Etkilesim : MonoBehaviour
{
    public Text text;
    public Image Nokta;
    public float Mesafe;
    public static int skorr=0;
    private float olusumSureci = 30f;
    private float zamanSayaci;


    void Start()
    {
        zamanSayaci = olusumSureci;
    }
    void Update()
    {

        Vector3 ileri = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Nokta.color = Color.white;
        

        if (Physics.Raycast(transform.position, ileri, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);

            if (hit.distance <= Mesafe && hit.collider.gameObject.tag == "cop")
            {
                Nokta.color = Color.red;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    skorr++;
                    text.text = skorr.ToString();
                    zamanSayaci -= Time.deltaTime;
                    
                }
            }
        }
      
        
    } 
}
