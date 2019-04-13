using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuklenmeEkranı : MonoBehaviour
{
    [SerializeField] AudioClip YuklenmeSesi;
    [SerializeField] AudioClip YuklenmeBittiSesi;

    private AudioSource muzikAraci;

    // Start is called before the first frame update
    void Start()
    {
        muzikAraci = GetComponent<AudioSource>();
        muzikAraci.PlayOneShot(YuklenmeSesi);
        Invoke("YuklenmeTamamlandi", 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void YuklenmeTamamlandi()
    {
        muzikAraci.Stop();
        muzikAraci.PlayOneShot(YuklenmeBittiSesi);
    }
}
