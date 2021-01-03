using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabaharaket : MonoBehaviour
{
    public GameObject car;

    public GameObject car2;
    Rigidbody fizik1;
    Rigidbody fizik2;
    

    // Start is called before the first frame update
    void Start()
    {
        fizik1 = car.GetComponent<Rigidbody>();
        fizik2 = car2.GetComponent<Rigidbody>();

        fizik1.velocity = new Vector3(-30f, 0, 0);
        fizik2.velocity = new Vector3(-40f, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (yol2.transform.position.x <= -174.8f)
        {
            yol2.transform.position += new Vector3(uzunluk * 58, 0);
        }*/
       

    }

}
