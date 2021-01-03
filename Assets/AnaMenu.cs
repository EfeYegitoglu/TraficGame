using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OyunaGit()
    {
        SceneManager.LoadScene("Oyun");   //OYUNA GİRER
    }
    
    // Update is called once per frame
    public void Cık()
    {

        Application.Quit();             //UYGULAMADAN ÇIKAR (APK DA ÇALIŞIR)
    }
}
