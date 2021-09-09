using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class contrato : MonoBehaviour
{
    public Image contarto;
    public Sprite assinado;
    public Animator logo;
    public bool assinar;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Assinar(){
        StartCoroutine("Aceito");
    }
    IEnumerator Aceito(){
        assinar = true;
        if(assinar == true){
            GetComponent<Animator>().enabled = true;
        contarto.sprite = assinado;
        logo.Play("ZommLogo");
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("Antes do manual");
        logo.Play("idle");
        }
    }
}
