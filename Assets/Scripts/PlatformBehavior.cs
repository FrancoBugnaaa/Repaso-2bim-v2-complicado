using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject Cilindro;
    public GameObject esfera;
    public GameObject Baseizq;
    public GameObject Baseder;

    
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if(transform.position.x > Baseder.transform.position.x-1f)
        {
            toRight = false;
            Instantiate(Cilindro);
            Cilindro.transform.position = new Vector3(Baseder.transform.position.x, 1, 0);
        }

        else if(transform.position.x < Baseizq.transform.position.x+1f)
        {
            toRight = true;
            Instantiate(esfera);
            esfera.transform.position = new Vector3(Baseizq.transform.position.x, 1, 0);
        }
    }
       
}
