using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        var healing = collision.gameObject.GetComponent<Health>();

        if(healing !=null){
            healing.TakeDamage(-10);
        Destroy(gameObject);
        }
    }
}
