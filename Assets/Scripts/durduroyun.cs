using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class durduroyun : MonoBehaviour
{
    public GameObject Pause_Menu;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController Karakter;
    bool isPAused;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPAused = !isPAused;
        }
        if(isPAused)
        {
            Time.timeScale = 0;
            Karakter.enabled = false;
            
            
            Pause_Menu.SetActive(true);
            Cursor.visible = true;
        
        }
        else
        {
            Time.timeScale = 1;
            Karakter.enabled = true;
            Pause_Menu.SetActive(false);
            Cursor.visible = false;
        }
        
    }
    public void DevamButton()
    {
        isPAused = false;
    }
    public void MenuButtton()
    {
        SceneManager.LoadScene("menu");
    }
    public void CikisButton()
    {
        Application.Quit();
    }
}
