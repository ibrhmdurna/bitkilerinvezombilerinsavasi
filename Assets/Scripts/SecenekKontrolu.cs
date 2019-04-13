using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecenekKontrolu : MonoBehaviour
{
    [SerializeField] Slider SesAyari;
    [SerializeField] Slider ZorlukAyari;
    [SerializeField] sahneKontrolu sahneYoneticisi;

    private muzikKontrolu muzikYoneticisi;

    // Start is called before the first frame update
    void Start()
    {
        muzikYoneticisi = FindObjectOfType<muzikKontrolu>();
        SesAyari.value = OyuncuAyarlari.AnaSesiAl();
        ZorlukAyari.value = OyuncuAyarlari.ZorluguAl();
    }

    // Update is called once per frame
    void Update()
    {
        muzikYoneticisi.SesiAyarla(SesAyari.value);
    }

    public void KaydetVeCik()
    {
        OyuncuAyarlari.AnaSesiAyarla(SesAyari.value);
        OyuncuAyarlari.ZorluguAyarla(ZorlukAyari.value);
        sahneYoneticisi.SahneGetir("Menu");
    }

    public void BaslangicAyarlari()
    {
        SesAyari.value = 0.5f;
        ZorlukAyari.value = 0f;
    }
}
