using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParayiTopla : MonoBehaviour
{
    private int Para = 1200;
    private Text ParaText;

    public enum ObjeOlusturmaDurumu { BASARILI, BASARISIZ};

    private void Start()
    {
        ParaText = GetComponent<Text>();
        ParaText.text = Para.ToString();
    }

    public void ParayiEkle(int miktar)
    {
        Para += miktar;
        ParaText.text = Para.ToString();
    }

    public ObjeOlusturmaDurumu ParayiKullan(int miktar)
    {
        //Para -= miktar;
        //ParaText.text = Para.ToString();
        if(Para >= miktar)
        {
            Para -= miktar;
            ParaText.text = Para.ToString();
            return ObjeOlusturmaDurumu.BASARILI;
        }
        else
            return ObjeOlusturmaDurumu.BASARISIZ;
    }
}
