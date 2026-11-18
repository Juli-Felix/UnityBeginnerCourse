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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber = 67;
        myChoice = true;
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
}
