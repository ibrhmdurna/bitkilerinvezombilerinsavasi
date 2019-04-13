using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] Saldiranlar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject Saldiran in Saldiranlar)
        {
            if (SaldiriVaktiMi(Saldiran))
            {
                SaldiraniGonder(Saldiran);
            }
        }
    }

    private void SaldiraniGonder(GameObject saldiran)
    {
        GameObject Saldiran = Instantiate(saldiran) as GameObject;
        Saldiran.transform.parent = transform;
        Saldiran.transform.position = transform.position;
    }

    private bool SaldiriVaktiMi(GameObject saldiran)
    {
        Saldiranlar Saldiran = saldiran.GetComponent<Saldiranlar>();

        float BeklemeSuresi = Saldiran.OlusmaZamani;
        float BeklemeOrani = 1 / BeklemeSuresi;

        float SonOran = BeklemeOrani * Time.deltaTime;

        return (UnityEngine.Random.value < SonOran);
    }
}
