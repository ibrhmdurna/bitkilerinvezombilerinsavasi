using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelElemanlari : MonoBehaviour
{
    [SerializeField] GameObject ElemanPrefab;

    private PanelElemanlari[] Elemanlar;
    public static GameObject SeciliEleman;

    // Start is called before the first frame update
    void Start()
    {
        Elemanlar = FindObjectsOfType<PanelElemanlari>();

        foreach (PanelElemanlari eleman in Elemanlar)
        {
            eleman.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SeciliEleman = ElemanPrefab;

        foreach (PanelElemanlari eleman in Elemanlar)
        {
            eleman.GetComponent<SpriteRenderer>().color = Color.black;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
