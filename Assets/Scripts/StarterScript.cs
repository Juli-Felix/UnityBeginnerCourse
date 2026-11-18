using System.Collections;
using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice; 
    int myOtherNumber;
    
    [SerializeField] GameObject myGate;
    [SerializeField] GameObject name1;
    [SerializeField] GameObject name2;
    [SerializeField] GameObject firstButton;

    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject hiddenSphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber = 67;
        myChoice = true;
        StartCoroutine(MySequence());
    }

    // Update is called once per frame
   void Update()
    {
        if (myNumber == 4 && myChoice == true)
        {
            myName = "Juli";
            //myGate.SetActive(true);
            name1.GetComponent<TMPro.TMP_Text>().text = "My Number: " + myNumber + " My Name: " + myName;
            name2.GetComponent<TMPro.TMP_Text>().text = "";
        }
        else
        {
            myName = "Gabriel";
            //myGate.SetActive(false);
            name2.GetComponent<TMPro.TMP_Text>().text = "Gabriel is active";
            name1.GetComponent<TMPro.TMP_Text>().text = "Juli is inactive";
        }
    }

    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("GateSwing", 0, 0f);
    }

    public void HideButton()
    {
        firstButton.SetActive(false);
    }

    IEnumerator MySequence()
    {
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(false);
        myGate.GetComponent<Animator>().Play("GateSwing");
        yield return new WaitForSeconds(4);
        firstButton.SetActive(false);
        yield return new WaitForSeconds(5);
        hiddenSphere.SetActive(true);
        yield return new WaitForSeconds(4);
        fadeOut.SetActive(true);
    }
}
