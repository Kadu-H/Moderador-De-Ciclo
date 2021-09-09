using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    public int valor;
    public Image manual;
    public Sprite inicio;
    public Sprite folha;
    public Sprite final;
    public GameObject avancar;
    public GameObject voltar;
    public GameObject pag1;
    public GameObject pag2;
    public GameObject pag3;
    public GameObject pag4;
    public GameObject pag5;
    public GameObject pag6;
    public GameObject pag7;
    public GameObject pag8;
    public GameObject pag9;
    public GameObject pag10;
    public GameObject pag11;
    // Start is called before the first frame update
    void Start()
    {
        valor = 1;
    }

    // Update is called once per frame
    void Update()
    {   
        if(valor >= 11){
            valor = 11;
        }
        if(valor <= 0){
            valor = 0;
        }
    
        if(valor == 1){
            voltar.gameObject.SetActive(false);
            manual.sprite = inicio;
            pag1.gameObject.SetActive(true);
            pag2.gameObject.SetActive(false);
        }
        if(valor == 2){
            voltar.gameObject.SetActive(true);
            pag1.gameObject.SetActive(false);
            pag2.gameObject.SetActive(true);
            manual.sprite = folha;
            pag3.gameObject.SetActive(false);
        }
        if(valor == 3){
            pag2.gameObject.SetActive(false);
            pag3.gameObject.SetActive(true);
            manual.sprite = folha;
            pag4.gameObject.SetActive(false);
        }
        if(valor == 4){
            pag3.gameObject.SetActive(false);
            pag4.gameObject.SetActive(true);
            manual.sprite = folha;
            pag5.gameObject.SetActive(false);
        }
        if(valor == 5){
            pag4.gameObject.SetActive(false);
            pag5.gameObject.SetActive(true);
            manual.sprite = folha;
            pag6.gameObject.SetActive(false);
        }
        if(valor == 6){
            pag5.gameObject.SetActive(false);
            pag6.gameObject.SetActive(true);
            manual.sprite = folha;
            pag7.gameObject.SetActive(false);
        }
        if(valor == 7){
            pag6.gameObject.SetActive(false);
            pag7.gameObject.SetActive(true);
            manual.sprite = folha;
            pag8.gameObject.SetActive(false);
        }
        if(valor == 8){
            pag7.gameObject.SetActive(false);
            pag8.gameObject.SetActive(true);
            manual.sprite = folha;
            pag9.gameObject.SetActive(false);
        }
        if(valor == 9){
            pag8.gameObject.SetActive(false);
            pag9.gameObject.SetActive(true);
            manual.sprite = folha;
            pag10.gameObject.SetActive(false);
            avancar.gameObject.SetActive(true);
        }
        if(valor == 10){
            pag9.gameObject.SetActive(false);
            pag10.gameObject.SetActive(true);
            manual.sprite = folha;
            avancar.gameObject.SetActive(true);
            pag11.gameObject.SetActive(false);
        }
        if(valor == 11){
            pag10.gameObject.SetActive(false);
            pag11.gameObject.SetActive(true);
            manual.sprite = final;
            avancar.gameObject.SetActive(false);
        }
    }
    public void Avançar(){
        valor += 1;
    }
    public void Voltar(){
        valor -= 1;
    }
}
