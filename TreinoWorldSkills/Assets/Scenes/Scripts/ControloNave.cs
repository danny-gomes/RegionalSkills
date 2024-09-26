using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControloNave : MonoBehaviour
{

    public float velocidade = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // this.transform.position += new Vector3(velocidade,0,0);
            this.transform.Translate(new Vector3(velocidade, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            // this.transform.position += new Vector3(velocidade,0,0);
            this.transform.Translate(new Vector3(velocidade * -1, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            // this.transform.position += new Vector3(velocidade,0,0);
            this.transform.Translate(new Vector3(0, 0, velocidade));
        }

        if (Input.GetKey(KeyCode.S))
        {
            // this.transform.position += new Vector3(velocidade,0,0);
            this.transform.Translate(new Vector3(0, 0, velocidade * -1));
        }
    }
}
