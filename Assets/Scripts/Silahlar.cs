using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silahlar : MonoBehaviour
{
    [SerializeField] float Hiz;
    [SerializeField] float Hasar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Hiz * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Saldiranlar saldiran = collision.gameObject.GetComponent<Saldiranlar>();
        Saglik saglik = collision.gameObject.GetComponent<Saglik>();

        if(saldiran && saglik)
        {
            saglik.ZararAlma(Hasar);
            Destroy(gameObject);
        }
    }
}
