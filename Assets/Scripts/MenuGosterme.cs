using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGosterme : MonoBehaviour
{
    [SerializeField] float GostermeSuresi;

    private Color guncelRenk = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad < GostermeSuresi)
        {
            float alfaDegisimi = Time.deltaTime / GostermeSuresi;
            guncelRenk.a -= alfaDegisimi;
            GetComponent<Image>().color = guncelRenk;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
