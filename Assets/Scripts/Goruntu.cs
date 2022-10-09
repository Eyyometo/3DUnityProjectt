using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goruntu : MonoBehaviour
{
    public void Dusuk()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void Orta()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void Yuksek()
    {
        QualitySettings.SetQualityLevel(2);
    }
}
