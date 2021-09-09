using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cisco : MonoBehaviour
{
    GameObject player;
    public GameObject particulas;
    public GameObject particulasMorte;
    public float tempo;
    public float tamanhoX;
    public float tamanhoY;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        StartCoroutine("Cisco");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Cisco(){
        yield return new WaitForSeconds(tempo);
        Instantiate(particulas,transform.position,Quaternion.identity);
        Destroy(gameObject,2f);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Instantiate(particulasMorte, transform.position,Quaternion.identity);
            player.transform.localScale += new Vector3(tamanhoX,tamanhoY,0f);
            Destroy(gameObject);
        }
    }
}
