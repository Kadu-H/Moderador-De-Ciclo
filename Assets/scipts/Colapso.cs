using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colapso : MonoBehaviour
{
    public int andar;
    public float speed;
    public int vida;
    public GameObject anomalia;
    public float tempoParaExpandir;
    public SpriteRenderer render;
    private GameObject carga1;
    private GameObject carga2;
    private GameObject carga3;
    public int vidaPlayer;
    public int vidaPersonagem;
    public GameObject Player;
        public GameObject particula;
        public GameObject particulaExpan;

    // Start is called before the first frame update
    void Start()
    {
        
        vida = 1;
        StartCoroutine("Tempo");
        StartCoroutine("Virar");        
    }

    // Update is called once per frame
    void Update()
    {
        carga1 = GameObject.Find("carga1");
        carga2 = GameObject.Find("carga2");
        carga3 = GameObject.Find("carga3");

        if(vida == 0){
            Destroy(gameObject);
        }
        
        if(andar == 1){
            render.flipX = true;
            transform.position = transform.position + new Vector3 (0.2f * speed * Time.deltaTime,0.1f * speed * Time.deltaTime,0f);
        }
        if(andar == 2){
            render.flipX = false;
            transform.position = transform.position + new Vector3 (-0.2f * speed * Time.deltaTime,-0.1f * speed * Time.deltaTime,0f);
        }
        if(andar == 3){
            render.flipX = true;
            transform.position = transform.position + new Vector3 (0.2f * speed * Time.deltaTime,0.2f * speed * Time.deltaTime,0f);
        }
        if(andar == 4){
            render.flipX = false;
            transform.position = transform.position + new Vector3 (-0.2f * speed * Time.deltaTime,-0.2f * speed * Time.deltaTime,0f);
        }
    }
    IEnumerator Tempo(){
        andar = Random.Range(1,4);
        yield return new WaitForSeconds(0.8f);
       StartCoroutine("Tempo"); 
    }
    
    IEnumerator Virar(){
        yield return new WaitForSeconds(tempoParaExpandir);
        if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == true && carga3.GetComponent<Image>().enabled == true){
            Instantiate(particulaExpan,transform.position,Quaternion.identity);
            carga1.GetComponent<Image>().enabled = true;
            carga2.GetComponent<Image>().enabled = true;
            carga3.GetComponent<Image>().enabled = false;
        }
        else
        {
            if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == true && carga3.GetComponent<Image>().enabled == false){
            Instantiate(particulaExpan,transform.position,Quaternion.identity);
            carga1.GetComponent<Image>().enabled = true;
            carga2.GetComponent<Image>().enabled = false;
            carga3.GetComponent<Image>().enabled = false;
            }
            
            else
            {
                if(carga1.GetComponent<Image>().enabled == true && carga2.GetComponent<Image>().enabled == false && carga3.GetComponent<Image>().enabled == false){
            Instantiate(particulaExpan,transform.position,Quaternion.identity);
            carga1.GetComponent<Image>().enabled = false;
            carga2.GetComponent<Image>().enabled =false;
            carga3.GetComponent<Image>().enabled = false;
            }
            }
        }
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Instantiate(particula,transform.position,Quaternion.identity);
            vida -= 1;
        }
    }
}
