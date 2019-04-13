using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavunanObjeleriOlustur : MonoBehaviour
{
    [SerializeField] Camera camera;

    private GameObject savunanObjeParent;
    private ParayiTopla ToplamPara;

    // Start is called before the first frame update
    void Start()
    {
        ToplamPara = FindObjectOfType<ParayiTopla>();
        savunanObjeParent = GameObject.Find("Savunanlar");

        if (!savunanObjeParent)
        {
            savunanObjeParent = new GameObject("Savunanlar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector2 objePozisyonu = DuzenliPozisyon(GercekPozisyon());

        GameObject SecilenEleman = PanelElemanlari.SeciliEleman;

        int maliyet = SecilenEleman.GetComponent<Savunanlar>().Maliyet;

        if (ToplamPara.ParayiKullan(maliyet).Equals(ParayiTopla.ObjeOlusturmaDurumu.BASARILI))
        {
            ObjeOlustur(SecilenEleman, objePozisyonu);
        }
        else
        {
            Debug.Log("Yetersiz Bakiye!");
        }

    }

    private void ObjeOlustur(GameObject savunan, Vector2 pozisyon)
    {
        GameObject yeniObje = Instantiate(savunan, pozisyon, Quaternion.identity);
        yeniObje.transform.parent = savunanObjeParent.transform;
    }

    private Vector2 DuzenliPozisyon(Vector2 deger)
    {
        float X = Mathf.CeilToInt(deger.x);
        float Y = Mathf.CeilToInt(deger.y);

        return new Vector2(X, Y);
    }

    private Vector2 GercekPozisyon()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float kameraUzakligi = 15f;

        Vector3 mousePozisyon = new Vector3(mouseX, mouseY, kameraUzakligi);
        Vector2 gercekPozisyon = camera.ScreenToWorldPoint(mousePozisyon);

        return gercekPozisyon;
    }
}
