using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sahnedegisim : MonoBehaviour
{
    public void PlayButton(int bolum_yaz)
    {
        Application.LoadLevel(bolum_yaz);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void RetryButton()
    {
        Application.LoadLevel("oyun");
    }
    public void MenuButton()
    {
        Application.LoadLevel("menu");
    }
}
