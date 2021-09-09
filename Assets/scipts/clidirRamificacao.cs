using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clidirRamificacao : MonoBehaviour
{
    public float tempo;
    public GameObject Monstro;
    public Transform spawn;
    public int fases;
    public float tempoLimite1;
    public float tempoDMS;
    public float tempoParaNascer;
    private GameObject cronometro;
    public bool gerar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FimDaRamificação");
        StartCoroutine("Tempo");
    }

    // Update is called once per frame
    void Update()
    {
        cronometro = GameObject.Find("conometro");
        tempoLimite1 = cronometro.GetComponent<cronometro>().tempoLimite;
        Monstro.SetActive(true);
    }
    
    IEnumerator FimDaRamificação(){
        yield return new WaitForSeconds(tempo);
        Instantiate(Monstro,spawn.position,Quaternion.identity);
        if(fases == 2){
            Instantiate(Monstro,spawn.position,Quaternion.identity);
        }
        if(fases == 3){
            Instantiate(Monstro,spawn.position,Quaternion.identity);
            Instantiate(Monstro,spawn.position,Quaternion.identity);
        }
        yield return new WaitForSeconds(tempoParaNascer);
        if(gerar == true){
            Debug.Log("nascer");
            StartCoroutine("FimDaRamificação");
        }
    }
    IEnumerator Tempo(){
        gerar = true;
        yield return new WaitForSeconds(tempoLimite1 - tempoDMS);
        gerar = false;
        StartCoroutine("FimDaRamificação");
    }
}
