using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 4;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        
        if (gameObject.CompareTag("Blue") && i >= Random.Range(150, 251))
        {
            rend.enabled = false;
        }

        Debug.Log($"{gameObject.name}:{i}");
        i++;
    }
}
