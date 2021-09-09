using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pauseObj;
    public bool pausado;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
       pausado = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Escape)){
            if( pausado == false){
                canvas.SetActive(false);
                pauseObj.SetActive(true);
                StartCoroutine("Tempo");
                pausado = true;
            }
            else
            {
                canvas.SetActive(true);
                pauseObj.SetActive(false);
                Time.timeScale = 0;
                pausado = false;
            }
        }
    }
    
    IEnumerator Tempo(){
        yield return new WaitForSeconds(0.4f);
        Time.timeScale = 0;
    }
}
