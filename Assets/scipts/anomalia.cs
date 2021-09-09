using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anomalia : MonoBehaviour
{
    public int vida;
    public float tempoParaSpawnarColapso;
    public GameObject colapso;
    public GameObject particula;
    
    // Start is called before the first frame update
    void Start()
    {
        vida = 2;
        StartCoroutine("Colapso");
    }

    // Update is called once per frame
    void Update()
    {
        if(vida == 0){
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Instantiate(particula,transform.position,Quaternion.identity);
            vida -= 1;
        }
    }
    IEnumerator Colapso(){
        yield return new WaitForSeconds(tempoParaSpawnarColapso);
        Instantiate(colapso,transform.position,Quaternion.identity);
    }
    
    
    
}
