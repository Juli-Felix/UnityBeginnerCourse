using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice; 
    int myOtherNumber;
    
    [SerializeField] GameObject myGate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber = 67;
        myChoice = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (myNumber == 67)
        {
            myName = "Juli";
            myGate.SetActive(true);
        } else
        {
            myName = "Gabriel";
            myGate.SetActive(false);
        }
    }
}
