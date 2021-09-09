using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movimentacao : MonoBehaviour
{
    public AudioSource track;
    public AudioClip animaliaSound;
    public AudioClip colapsoSound;
    public AudioClip ciscoSound;
    public int fase;
    public GameObject ciscoTemporal;
    public float ciscoTempo;
    GameObject carga1;
    GameObject carga2;
    GameObject carga3;
    public float speed;
    public float distanciaTransporte;
    public bool teletransportFora;
    public bool destruirRamificacao;
    bool dentro;
    Camera cam;
    public bool seguirMouse;
    Vector2 mousePos;
    public Animator animadorCam;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        teletransportFora = true;
        animadorCam.enabled = false;
        vida = 3;
        seguirMouse = true;
        StartCoroutine("cisco");
    }

    // Update is called once per frame
    void Update()
    {
        carga1 = GameObject.Find("carga1");
        carga2 = GameObject.Find("carga2");
        carga3 = GameObject.Find("carga3");
        if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == true && carga3.GetComponent<Image>().enabled == true){
           vida = 3;
        }
        if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == true && carga3.GetComponent<Image>().enabled == false){
           vida = 2;
        }
        if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == false && carga3.GetComponent<Image>().enabled == false){
           vida = 1;
        }
        if(carga1.GetComponent<Image>().enabled == false && carga2.GetComponent<Image>().enabled == false && carga3.GetComponent<Image>().enabled == false){
           vida = 0;
        }
        if(vida == 0){
            if(fase == 1){
            SceneManager.LoadScene("demitido");
            }
            if(fase == 2){
                SceneManager.LoadScene("demitido2");
            }
            if(fase == 3){
                SceneManager.LoadScene("demitido3");
            }
        }

        if(seguirMouse == true){
            Movimentar();
        }
        if(Time.timeScale == 0){
            seguirMouse = false;
        }
        else
        {
            seguirMouse = true;
        }
        cam = Camera.main;
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void Movimentar(){
        
        transform.position = mousePos;
        
    }
    

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "anomalia"){
            track.PlayOneShot(animaliaSound);
            StartCoroutine("Tremer");
        }
        if(other.gameObject.tag == "colapso"){
            track.PlayOneShot(colapsoSound);
            StartCoroutine("Tremer");
        }
        if(other.gameObject.tag == "cisco"){
            track.PlayOneShot(ciscoSound);
        }
      
    
    } 
    IEnumerator Tremer(){
        animadorCam.enabled = true;
        yield return new WaitForSeconds(0.4f);
        animadorCam.enabled = false;
    }  
    IEnumerator cisco(){
        yield return new WaitForSeconds(ciscoTempo);
        float Ry = Random.Range(-4.80f, 4.80f);
        float Rx = Random.Range(-8.58f, 8.58f);
        Instantiate(ciscoTemporal,new Vector3(Rx,Ry,0f),Quaternion.identity);
        StartCoroutine("cisco");
    }
    public void HitSound(){

    }
    
}
    
   
