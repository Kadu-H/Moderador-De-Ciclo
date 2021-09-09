using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escreverTexto : MonoBehaviour
{
    public Text textoNaTela;
    public float delay = 0.1f;
    public string texto;
    // Start is called before the first frame update
    void Start()
    {
        textoNaTela.text = " ";
        StartCoroutine("Texto", texto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Texto(string tipoTexto){

        textoNaTela.text = " ";
        if(textoNaTela.text == texto){

        }
        else
        {
            for( int letter = 0; letter < tipoTexto.Length; letter++){
            textoNaTela.text = textoNaTela.text + tipoTexto[letter];
            yield return new WaitForSeconds(delay);
        }
        }

    }
}
