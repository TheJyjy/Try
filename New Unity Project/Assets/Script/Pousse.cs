using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pousse : MonoBehaviour


{

    public Rigidbody Rb;
    public float vitesse;
    public float force;
    public List<Rigidbody> touche;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Rb.velocity = transform.forward * vitesse;

        Destroy(gameObject, 8f);
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        if (other.gameObject.GetComponent<Rigidbody>()&& !touche.Contains(other.gameObject.GetComponent<Rigidbody>()))
        {

            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force);
            Debug.Log(other);

            touche.Add(other.gameObject.GetComponent<Rigidbody>());



        }


    }
}
