using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 2f;

    private Vector3 posicaoInicial;
    private float tamanhoImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
