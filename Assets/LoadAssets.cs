using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    [SerializeField]
    private GameObject blueObj;
    public GameObject redObj;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        GameObject instantiatedRed = Instantiate(redObj, new Vector3(2f, 0f, 0f), Quaternion.identity);
        GameObject instantiatedBlue = Instantiate(blueObj, new Vector3(-2f, 0f, 0f), Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
