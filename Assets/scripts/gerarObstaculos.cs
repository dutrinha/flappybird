using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarObstaculos : MonoBehaviour
{
    // como criar os obstaculos?
    // onde criar?
    // quando criar?

    [SerializeField]
    private float tempoParaGerar = 3;

    private float cronometro;

    [SerializeField]
    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
