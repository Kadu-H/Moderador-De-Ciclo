using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cronometro : MonoBehaviour
{
   public Text CronometroText;
    public float tempoAtual;
    public float tempoLimite;
    public int fase;
    public bool tempo;
    // Start is called before the first frame update
    void Start()
    {
        tempoAtual = 0;
        tempo = false;
        StartCoroutine("Tempo");
    }

    // Update is called once per frame
    void Update()
    {
        if(tempo == true){
        tempoAtual += Time.deltaTime;
        CronometroText.text = tempoAtual.ToString("F2");
        if(tempoAtual >= tempoLimite){
            if(GameObject.Find("anomalia(Clone)") == true || GameObject.Find("calpsosDoTempo 1(Clone)") == true){
                SceneManager.LoadScene("demitido");
                Debug.Log("achei");
            }
            if(GameObject.Find("anomalia(Clone)") == false && GameObject.Find("calpsosDoTempo 1(Clone)") == false)
            {
                if(fase == 1){
                    Debug.Log("ganhou");
                    SceneManager.LoadScene("promovido");
                }
                if(fase == 2){
                    Debug.Log("ganhou2");
                    SceneManager.LoadScene("promivido 2");
                }
                if(fase == 3){
                    Debug.Log("ganhou3");
                    SceneManager.LoadScene("Chefe");
                }
            }
        }
        }
    }
    IEnumerator Tempo(){
        yield return new WaitForSeconds(2.4f);
        tempo = true;

    }
}
