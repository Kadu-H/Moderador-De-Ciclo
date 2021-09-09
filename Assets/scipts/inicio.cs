using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    public int valor;
    public GameObject avancar;
    public GameObject voltar;
    public GameObject pag1;
    public GameObject pag2;
    public GameObject pag3;
    public GameObject pag4;

    // Start is called before the first frame update
    void Start()
    {
        valor = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(valor == 1){
            avancar.SetActive(true);
            voltar.SetActive(false);
            pag1.SetActive(true);
            pag2.SetActive(false);
        }
        if(valor == 2){
            avancar.SetActive(true);
            voltar.SetActive(true);
            pag1.SetActive(false);
            pag2.SetActive(true);
            pag3.SetActive(false);
        }
         if(valor == 3){
            avancar.SetActive(true);
            voltar.SetActive(true);
            pag2.SetActive(false);
            pag3.SetActive(true);
            pag4.SetActive(false);
        }
        if(valor == 4){
            avancar.SetActive(true);
            voltar.SetActive(true);
            pag3.SetActive(false);
            pag4.SetActive(true);
        }
        if(valor == 5){
            SceneManager.LoadScene("Chegada Time Cormporation");
        }
    }
    public void Avancar(){
        valor += 1;
    }
    public void Voltar(){
        valor -= 1;
    }
}
