using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawn : MonoBehaviour
{

    public GameObject inimigo;
    private float temporizador = 0;
    public int spawnRate = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        temporizador += Time.deltaTime;

        if (temporizador > spawnRate)
        {
            float posicaoAleatoriaX = Random.Range(-10f, 10f);

            Instantiate(inimigo, new Vector3(posicaoAleatoriaX, 2, 5), Quaternion.identity);
            temporizador = 0;
        }
        
    }
}
