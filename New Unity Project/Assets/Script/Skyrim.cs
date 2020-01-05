using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyrim : MonoBehaviour


{

    public AudioSource son;
    public AudioClip cri;
    public float secondes;
    public GameObject force;
    public float cooldownfus;
    public bool fus = true;
   

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }

    void Click()

    {

        if (Input.GetKeyDown(KeyCode.H) && fus)
        {
            StartCoroutine(Retard());
           
            son.PlayOneShot(cri);
            fus = false;

            StartCoroutine(Cooldown());

        }





    }

    IEnumerator Retard()

    {

        

        yield return new WaitForSeconds(secondes);
        Instantiate(force, transform.position, transform.localRotation);
        StopCoroutine(Retard());


    }

    IEnumerator Cooldown()

    {

        yield return new WaitForSeconds(cooldownfus);
        fus = true;


    }
}
