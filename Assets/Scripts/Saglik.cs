using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saglik : MonoBehaviour
{
    [SerializeField] float Can;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZararAlma(float zararMiktari)
    {
        Can -= zararMiktari;
        
        if(Can <= 0)
        {
            YokEt();
        }
    }

    public void YokEt()
    {
        Destroy(gameObject);
    }
}
