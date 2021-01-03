using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagsol : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody fizik;
    public int hiz;

    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0,dikey);
        fizik.AddForce(vec * hiz);
    }
}
