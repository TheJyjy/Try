using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    public float vitesse;
    private Rigidbody rb;
    public GameObject cameraplayer;
    public float sensi;
    public float limiteHaut;
    public float limiteBas;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float axeX = Input.GetAxisRaw("Horizontal")*vitesse;
        float axeZ = Input.GetAxisRaw("Vertical")*vitesse;
        //Debug.Log("L'axe x =" + axeX);

        Vector3 mouvementenX = transform.right * axeX;
        Vector3 mouvementenZ = transform.forward * axeZ;

        

        rb.velocity = new Vector3(0,rb.velocity.y,0)+ mouvementenX + mouvementenZ;

        float sourisX = Input.GetAxis("Mouse X") * sensi;
        float sourisY = Input.GetAxis("Mouse Y") * sensi;

            transform.Rotate(0, sourisX, 0);
        //transform.rotation = Quaternion.Euler(0, sourisX, 0);

        cameraplayer.transform.Rotate(sourisY,0,0);

        Vector3 currentRotation = cameraplayer.transform.localRotation.eulerAngles;

        if (currentRotation.x > 180f)

        {

             currentRotation.x -= 360f;


        }

        currentRotation.x = Mathf.Clamp(currentRotation.x, limiteBas, limiteHaut);
        cameraplayer.transform.localRotation = Quaternion.Euler(currentRotation);






    }
}
