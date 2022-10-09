using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch : MonoBehaviour
{
    public Text text;
   

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "orumcek")
        {

            other.gameObject.SetActive(false);
            Etkilesim.skorr -= 1;
            text.text = Etkilesim.skorr.ToString();
         
        }
        


    }




}