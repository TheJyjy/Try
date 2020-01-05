using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour

   

{



    public Transform oulaTransform;


    // Start is called before the first frame update
    void Start()
    {

        transform.localScale = new Vector3(1, 1, 1);
        oulaTransform.localScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
