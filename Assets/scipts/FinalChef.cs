using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChef : MonoBehaviour
{
    public int valor;
    public GameObject avancar;
    public GameObject voltar;
    public GameObject chef;
    public GameObject ronald;
    public GameObject pag1;
    public GameObject pag2;
    public GameObject pag3;
    public GameObject pag4;
    // Start is called before the first frame update
    void Start()
    {
        valor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(valor >= 4){
            valor = 4;
        }
        if(valor <= 0){
            valor = 0;
        }
        if(valor == 0){
            chef.SetActive(true);
            ronald.SetActive(true);
            voltar.gameObject.SetActive(false);
            pag1.gameObject.SetActive(false);
        }
        if(valor == 1){
            chef.SetActive(false);
            ronald.SetActive(false);
            voltar.gameObject.SetActive(true);
            pag1.gameObject.SetActive(true);
            pag2.gameObject.SetActive(false);
        }
        if(valor == 2){
            pag1.gameObject.SetActive(false);
            pag2.gameObject.SetActive(true);
            pag3.gameObject.SetActive(false);
        }
        if(valor == 3){
            pag2.gameObject.SetActive(false);
            pag3.gameObject.SetActive(true);
            pag4.gameObject.SetActive(false);
            avancar.SetActive(true);
        }
        if(valor == 4){
            pag3.gameObject.SetActive(false);
            pag4.gameObject.SetActive(true);
            avancar.SetActive(false);
        }
        
    }
    public void Avançar(){
        valor += 1;
    }
    public void Voltar(){
        valor -= 1;
    }
    public void Sair(){
        Application.Quit();
    }
}
