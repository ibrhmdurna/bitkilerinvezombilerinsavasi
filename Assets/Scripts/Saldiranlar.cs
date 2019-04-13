using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldiranlar : MonoBehaviour
{
    //[Range(0f,2f)]
    private float Hiz;
    private GameObject MevcutHedef;
    private Animator animator;
    
    [SerializeField] public float OlusmaZamani;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Hiz * Time.deltaTime);

        if (!MevcutHedef)
        {
            animator.SetBool("SaldiriVarMi", false);
        }
    }

    private void MevcutHiziAyarla(float hiz)
    {
        Hiz = hiz;
    }

    public void ZararVerme(float zarar)
    {
        if (MevcutHedef)
        {
            Saglik saglik = MevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAlma(zarar);
            }
        }
    }

    public void HedefeSaldir(GameObject hedef)
    {
        MevcutHedef = hedef;
    }
}
