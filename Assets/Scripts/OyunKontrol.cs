using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
     public GameObject cop1;
     public GameObject cop2;
     public GameObject cop3;
     public GameObject cop4;
     public GameObject cop5;
    

    private float zamanSayaci;
     private float olusumSureci = 20f;

     void Start()
     {
         zamanSayaci = olusumSureci;
     }
    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if  (zamanSayaci<0)
        {
                Vector3 pos = new Vector3 (Random.Range(348f,169f),27f,Random.Range(341f,151f));
                Instantiate (cop1, pos, Quaternion.identity);
            Vector3 pos1 = new Vector3(Random.Range(348f, 169f), 27f, Random.Range(341f, 151f));
            Instantiate(cop2, pos1, Quaternion.identity);
            Vector3 pos2 = new Vector3(Random.Range(348f, 169f), 27f, Random.Range(341f, 151f));
            Instantiate(cop3, pos2, Quaternion.identity);
            Vector3 pos3 = new Vector3(Random.Range(348f, 169f), 27f, Random.Range(341f, 151f));
            Instantiate(cop4, pos3, Quaternion.identity);
            Vector3 pos4 = new Vector3(Random.Range(348f, 169f), 27f, Random.Range(341f, 151f));
            Instantiate(cop5, pos4, Quaternion.identity);
            

            zamanSayaci = olusumSureci;
        }
    }
}
