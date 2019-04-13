using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    [SerializeField] GameObject Silah;
    [SerializeField] GameObject CikisNoktasi;

    private GameObject SilahParent;
    private Animator Animator;
    private SaldiranSpawn SaldiriYolu;

    private void Start()
    {
        Animator = GetComponent<Animator>();
        SilahParent = GameObject.Find("Silahlar");
        if (!SilahParent)
        {
            SilahParent = new GameObject();
            SilahParent.name = "Silahlar";
        }
        SaldiraninKonumu();
    }

    private void Update()
    {
        Animator.SetBool("SaldiriVarMi", SaldiranVarMi());
    }

    private bool SaldiranVarMi()
    {
        if (SaldiriYolu.transform.childCount <= 0)
            return false;

        foreach (Transform saldiran in SaldiriYolu.transform)
        {
            if (saldiran.transform.position.x > transform.position.x)
                return true;
        }

        return false;
    }

    private void SaldiraninKonumu()
    {
        SaldiranSpawn[] saldiranlar = FindObjectsOfType<SaldiranSpawn>();

        foreach (SaldiranSpawn yolu in saldiranlar)
        {
            if(yolu.transform.position.y == transform.position.y)
            {
                SaldiriYolu = yolu;
                break;
            }
        }
    }

    private void AtesEt()
    {
        GameObject OlusanSilah = Instantiate(Silah) as GameObject;
        OlusanSilah.transform.position = CikisNoktasi.transform.position;
        OlusanSilah.transform.parent = SilahParent.transform;
    }
}
