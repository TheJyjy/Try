using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{

    // scope type nom valeur
    public int zouzou = 45;
    public float bibou = 74.45f;
    public char popo = 'f';
    public string zozo = "bonjour";
    public bool pepe = true;
    public Transform momo;
    public Vector3 lulu;
    





    // Start is called before the first frame update
    void Start()
    {
        zouzou = 12;
        bibou = bibou / bibou;
        // ou bibou*=bibou;
        pepe = !pepe;
        Debug.Log(Addition(5,10));

        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Addition(1, 10));
        click();

        
    }

    void click ()

    {

        if (Input.GetKeyDown(KeyCode.J))
        {

            Debug.Log(Addition(14,5));
        }


    }


    //scope type nom(param) {}
    int Addition(int nombreA, int nombreB)
    {

        //nombreA=8;
        //nombreB=4;

        return nombreA + nombreB;
    }
}
