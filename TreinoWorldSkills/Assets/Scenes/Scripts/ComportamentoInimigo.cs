using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoInimigo : MonoBehaviour
{

    public float velocidadeInimigo = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, velocidadeInimigo * -1);

        if(this.transform.position.z < -10)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // use tags
    }
}
