using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuAyarlari : MonoBehaviour
{
    const string ANA_SES_ANAHTARI = "ana_ses";
    const string ZORLUK_ANAHTARI = "zorluk";
    const string SEVIYE_ANAHTARI = "seviye_acik_";

    public static void AnaSesiAyarla(float ses)
    {
        if(ses >= 0f && ses <= 1f)
        {
            PlayerPrefs.SetFloat(ANA_SES_ANAHTARI, ses);
        }
        else
        {
            Debug.LogError("Hatalı ses aralığı girildi!");
        }
    }

    public static float AnaSesiAl()
    {
        return PlayerPrefs.GetFloat(ANA_SES_ANAHTARI
);
    }

    public static void SeviyeninKilidi(int seviye)
    {
        if(seviye < SceneManager.sceneCountInBuildSettings)
        {
            PlayerPrefs.SetInt(SEVIYE_ANAHTARI + seviye, 1);
        }
        else
        {
            Debug.Log("Hatalı sahne girildi!");
        }
    }

    public static bool SeviyeAcikMi(int seviye)
    {
        if (seviye < SceneManager.sceneCountInBuildSettings)
        {
            return PlayerPrefs.GetInt(SEVIYE_ANAHTARI + seviye) == 1;
        }
        else
        {
            Debug.Log("Hatalı sahne girildi!");
            return false;
        }
    }

    public static void ZorluguAyarla(float zorluk)
    {
        if(zorluk >= 1f && zorluk <= 5f)
        {
            PlayerPrefs.SetFloat(ZORLUK_ANAHTARI, zorluk);
        }
        else
        {
            Debug.LogError("Hatalı zorluk aralığı girildi!");
        }
    }

    public static float ZorluguAl()
    {
        return PlayerPrefs.GetFloat(ZORLUK_ANAHTARI);
    }
}
