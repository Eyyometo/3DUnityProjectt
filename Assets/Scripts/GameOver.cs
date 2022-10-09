using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Etkilesim.skorr < 0)
        {
            

            Etkilesim.skorr = 0;
            SceneManager.LoadScene(3);
            Cursor.visible = true;
        }
        if (Etkilesim.skorr == 30)
        {


            Etkilesim.skorr = 0;
            SceneManager.LoadScene(4);
            
        }


    }
}
