using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraketaraba : MonoBehaviour
{

    public float car1hiz = -65f;  // ARABA HIZLARI EKRANA AÇIK YAPILDI
    public float car2hiz = -65f;
    public GameObject car;        //ARABALARIN OBJESİ OLUŞTURULDU
    public GameObject car2;
    Rigidbody fizik1;
    Rigidbody fizik2;            //2 TANE FİZİK TANIMLANDI
    float uzunluk=0;



    // Start is called before the first frame update
    void Start()
    {
        fizik1 = car.GetComponent<Rigidbody>();      //BAŞLANGIŞÇA FİZİK EKLENİ
        fizik2 = car2.GetComponent<Rigidbody>();

        fizik1.velocity = new Vector3(car1hiz, 0, 0);    //ARABALARIN FİZİĞİNE BAŞLANGIÇTA X KORDİNATINDA GÜÇ UYGULANDI
        fizik2.velocity = new Vector3(car2hiz, 0, 0);
        uzunluk = car.GetComponent<BoxCollider>().size.x;   //COLLİDERIN X EKSENİNDEKİ YÖNÜNE BAKIYOR VE UZUNLUĞA ATIYOR
    }

    // Update is called once per frame
    void FixedUpdate()                   //SÜREKLİ GÜNCELLENMESİNİ SAĞLIYOR
    {
        if (car.transform.position.x <= -270)                            
        {
            car.transform.position += new Vector3(uzunluk * 540, 0);        //ARABA1 -X YÖNÜNDE -270 E GELİRSE UZUNLUĞUN 540 KATI İLERİ IŞINLANSIN
        }
        if (car2.transform.position.x <= -270)
        {
            car2.transform.position += new Vector3(uzunluk * 550, 0);      //ARABA1 -X YÖNÜNDE -270 E GELİRSE UZUNLUĞUN 550 KATI İLERİ IŞINLANSIN
        }


    }

   
}
