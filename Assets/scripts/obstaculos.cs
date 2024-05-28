using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;

    [SerializeField]
    private float variacaoposicaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(variacaoposicaoY,variacaoposicaoY));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);


    }
}
