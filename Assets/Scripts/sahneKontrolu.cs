using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneKontrolu : MonoBehaviour
{
    [SerializeField] float sahneYuklenmeSuresi;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Başlangıç")
        {
            Invoke("SonrakiSahne", sahneYuklenmeSuresi);
        }
    }

    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OyundanCikis()
    {
        Application.Quit();
    }

    public void SahneGetir(string isim)
    {
        SceneManager.LoadScene(isim);
    }

    public void SahneGetir(int index)
    {
        SceneManager.LoadScene(index);
    }
}
