using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subirDeAndarAnomalias : MonoBehaviour
{
    public Transform player;
    public float alturaDoPulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(Input.GetKey(KeyCode.W) & Input.GetKeyDown(KeyCode.LeftControl)){
                player.position = player.position + new Vector3(0f, alturaDoPulo,0f);
            }
            if(Input.GetKey(KeyCode.S) & Input.GetKeyDown(KeyCode.LeftControl)){
                player.position = player.position + new Vector3(0f,-alturaDoPulo,0f);
            }
        }
    }
}
