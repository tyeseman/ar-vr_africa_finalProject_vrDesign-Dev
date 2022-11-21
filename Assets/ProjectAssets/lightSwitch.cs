using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour

{
    public GameObject[] light;
    public AudioSource clickSound;
    public int numberOfLights;
    public bool isLightOff = false;


    private void OnMouseDown()
    {
        if (!isLightOff)
        {
            clickSound.Play();
            for (int i = 0; i < numberOfLights; i++)
            {
                light[i].SetActive(false);
                isLightOff = true;
            }
            

        }
        else
        {
            clickSound.Play();
            for (int i = 0; i < numberOfLights; i++)
            {
                light[i].SetActive(true);
                isLightOff = false;
            }

        }
    }

    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
