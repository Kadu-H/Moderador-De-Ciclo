using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NavAnomalia : MonoBehaviour
{

    public float speed;
    public int andar;
    public SpriteRenderer renderSprite;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Tempo");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(andar == 1){
            renderSprite.flipX = true;
            transform.position = transform.position + new Vector3 (0.2f * speed * Time.deltaTime,0.2f * speed * Time.deltaTime,0f);
        }
        if(andar == 2){
            renderSprite.flipX = false;
            transform.position = transform.position + new Vector3 (-0.2f * speed * Time.deltaTime,-0.2f * speed * Time.deltaTime,0f);
        }
        if(andar == 3){
            renderSprite.flipX = false;
            transform.position = transform.position + new Vector3 (-0.2f * speed * Time.deltaTime,0.2f * speed * Time.deltaTime,0f);
        }
        if(andar == 4){
            renderSprite.flipX = false;
            transform.position = transform.position + new Vector3 (0.2f * speed * Time.deltaTime,-0.2f * speed * Time.deltaTime,0f);
        }
        
    }
    IEnumerator Tempo(){
        andar = Random.Range(1,4);
        yield return new WaitForSeconds(1f);
       StartCoroutine("Tempo"); 
    }
    
}
