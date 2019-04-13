using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikKontrolu : MonoBehaviour
{
    private static muzikKontrolu muzikOynaticisi;

    private void Awake()
    {
        if (muzikOynaticisi != null)
            Destroy(gameObject);
        else
        {
            muzikOynaticisi = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SesiAyarla(float ses)
    {
        GetComponent<AudioSource>().volume = ses;
    }
}
