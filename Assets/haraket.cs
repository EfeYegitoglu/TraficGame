using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class haraket : MonoBehaviour
{
    
    
    public Text puanText;                  //OYUNA PUANI YAZDIRIR
    Rigidbody fizik;                      //FİZİK TANIMLAR
    int puan = 0;                         //PUAN TANIMI
    public float karakterHiz = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        fizik=GetComponent<Rigidbody>();                           //FİZİĞE ATAMALAR YAPILIR
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hinput = SimpleInput.GetAxis("Horizontal") * karakterHiz;
        fizik.transform.Translate(hinput, 0,0);
        /*if (SimpleInput.GetKey(KeyCode.RightArrow))           
        {                                                    //SAĞ TUŞA BASINCA 0.5F SAĞA GİDER
            this.transform.Translate(0.5f,0,0);
        }
        if (SimpleInput.GetKey(KeyCode.LeftArrow))
        {                                                    //SAĞ YÖNÜN - TARAFINDA 0.5 İLERLER
            this.transform.Translate(-0.5f, 0, 0);
        }*/
    }
    void OnTriggerEnter(Collider col)             //COLLİDERA GİRİNCE
    {
        if (col.gameObject.tag=="puan")           //ÇARPAN COLLİDERIN TAGI PUAN İSE
        {
            puan+=100;
            puanText.text = "SKOR= " + puan;         //PUANI 100 ARTTIR SKORU TEXTE YAZ
            //Time.timeScale = 0.0f;
            //Debug.Log(puan);
        }
        if (col.gameObject.tag == "engel")             //ÇARPAN COLLİDERIN TAGI ENGEL İSE    
        {
            SceneManager.LoadScene("AnaMenu");          //OYUN SONLANSIN ANAMENÜYE DÖSÜN
        }


    }

    
}
