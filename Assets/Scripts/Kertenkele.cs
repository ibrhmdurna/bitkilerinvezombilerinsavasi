using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Saldiranlar))]
public class Kertenkele : MonoBehaviour
{
    private Saldiranlar saldiran;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        saldiran = GetComponent<Saldiranlar>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject HedefNesne = collision.gameObject;

        if (!HedefNesne.GetComponent<Savunanlar>())
            return;

        
        if(HedefNesne.GetComponent<Savunanlar>())
        {
            animator.SetBool("SaldiriVarMi", true);
            saldiran.HedefeSaldir(HedefNesne);
        }
    }
}
