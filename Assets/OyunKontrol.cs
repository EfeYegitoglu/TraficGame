using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public float yol1hiz = -100f;           //YOLLARIN HIZI EKRANA AÇIK YAPILDI
    public float yol2hiz = -100f;
    public GameObject yol1;
    public GameObject yol2;           //YOL OBJELERİ TANIMLANDI

    Rigidbody fizik1;
    Rigidbody fizik2;               //FİZİKLER TANIMLANDI
    float uzunluk =0;

    // Start is called before the first frame update
    void Start() //BAŞLANGIÇTA
    {
        fizik1 = yol1.GetComponent<Rigidbody>();           //TANIMLANAN FİZİKLER RİGİDBODY İÇİNE ALINDI İŞLEME AÇILDI
        fizik2 = yol2.GetComponent<Rigidbody>();

        fizik1.velocity = new Vector3(yol1hiz,0,0);          //FİZİKLERİN KONUMUNU X EKSENİNDE DEĞİŞTİREREK HARAKET GÖRÜNÜMÜ SAĞLANDI
        fizik2.velocity = new Vector3(yol2hiz, 0, 0);
        uzunluk = yol1.GetComponent<BoxCollider>().size.x;     ////COLLİDERIN X EKSENİNDEKİ YÖNÜNE BAKIYOR VE UZUNLUĞA ATIYOR
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yol2.transform.position.x <= -174.8f)
        {
            yol2.transform.position += new Vector3(uzunluk *58, 0);      //YOL 1 VE YOL 2 -X YÖNÜNDE 174 E GELİNCE UZUNLUĞUN 58 KATI KADAR İLERİ IŞINLANSIN 
        }
        if (yol1.transform.position.x<=-174.8f)                           //HARAKETLİ YOL GÖRÜNÜMÜ KAZANDIRILDI. BELLEKTEN TASARRUF EDİLDİ
        {
            yol1.transform.position += new Vector3(uzunluk*58,0);
        }
        
    }

    
}
