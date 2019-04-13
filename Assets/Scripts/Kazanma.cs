using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Kazanma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value -= 0.000099f;

        if(GetComponent<Slider>().value <= 0)
        {
            SceneManager.LoadScene("Kazanma");
        }
    }
}
