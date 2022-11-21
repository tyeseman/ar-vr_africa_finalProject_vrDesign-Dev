using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;
using DG.Tweening;

public class check : MonoBehaviour
{
    public TMP_Text result;
    public TMP_InputField username;
    public TMP_InputField password;
    public TMP_InputField netWorth;

    public Animator oldAnimator;
    public Animator youngAnimator;
    public GameObject mainCharacter;

    private string usertyped; 
    private string passwordtyped;
    private float netWorthtyped;
    

   
    public void OnMouseDown()
    {

        usertyped = username.text;
        passwordtyped = password.text;
        netWorthtyped = float.Parse(netWorth.text);

        if ((usertyped == "Leon" )&&(passwordtyped == "1234"))
        {
            if (netWorthtyped <1)
            {
                result.text = "You are Broke";
                youngAnimator.SetBool("Dance", false);
                youngAnimator.SetBool("Idle", true);
                oldAnimator.SetBool("Dance", false);
                oldAnimator.SetBool("Idle", true);

            }
            if (netWorthtyped >= 1 && netWorthtyped <4.5)
            {
                result.text = "Welcome to the village house";
                oldAnimator.SetBool("Dance",true);
                oldAnimator.SetBool("Idle",false);
                youngAnimator.SetBool("Dance", false);
                youngAnimator.SetBool("Idle", true);
                mainCharacter.transform.DOMove(new Vector3(-2.2f, 2.26f, 43.5f), 7f );
                mainCharacter.transform.DORotate(new Vector3(-1.511f, 308.71f, 0.003f), 3f);
            }
            if (netWorthtyped >= 4.5)
            {
                result.text = "Welcome to the City house";
                youngAnimator.SetBool("Dance", true);
                youngAnimator.SetBool("Idle", false);
                oldAnimator.SetBool("Dance", false);
                oldAnimator.SetBool("Idle", true);
                mainCharacter.transform.DOMove(new Vector3(-6.262f, 2.82f, -7.777f), 7f);
                mainCharacter.transform.DORotate(new Vector3(-0.99f, 28.1f, 0.001f), 3f);
                

            }

        }
        else
        {
            result.text = "Check username or password";
            youngAnimator.SetBool("Dance", false);
            youngAnimator.SetBool("Idle", true);
            oldAnimator.SetBool("Dance", false);
            oldAnimator.SetBool("Idle", true);

        }
    }

    /*/ Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

}
