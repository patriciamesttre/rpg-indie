using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 0.01f;

    private Animator controleAnimacao;
    
    // Start is called before the first frame update
    void Start()
    {
        this.controleAnimacao = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = new Vector3();
        direcao.y = Input.GetAxis("Vertical");
        direcao.x = Input.GetAxis("Horizontal");

        this.transform.position += direcao * velocidade;

        bool estouAndando = direcao.magnitude != 0;
        this.controleAnimacao.SetBool("estaAndando", estouAndando);
        this.controleAnimacao.SetFloat("velocidadeY", direcao.y);
        this.controleAnimacao.SetFloat("velocidadeX", direcao.x);


    }
}
