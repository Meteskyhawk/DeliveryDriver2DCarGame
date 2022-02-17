using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 haspackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 nopackageColor = new Color32 (5,5,5,5);
    
    bool hasPackage;


    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    [SerializeField] float destroyDelay = 0.5f;
        void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("temas edildi");
    }


    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = haspackageColor;
            Destroy(other.gameObject,destroyDelay);
            
        }
        if (other.tag == "Customer" && hasPackage){

            Debug.Log("Pakcage deliverd");
            hasPackage = false;
            spriteRenderer.color = nopackageColor;

        }
    }


}
