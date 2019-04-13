using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savunanlar : MonoBehaviour
{
    [SerializeField] public int Maliyet;

    private ParayiTopla ParaToplama;

    private void Start()
    {
        ParaToplama = FindObjectOfType<ParayiTopla>();
    }

    public void ParayiArttir(int para)
    {
        ParaToplama.ParayiEkle(para);
    }
}
