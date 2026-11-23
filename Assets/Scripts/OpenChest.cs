using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] float internalDistance;
    [SerializeField] bool chestOpen = false;
    [SerializeField] GameObject chest;


    // Update is called once per frame
    void Update()
    {
        internalDistance = Raycasting.distanceFromTarget;
        if (!chestOpen && internalDistance < 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                chestOpen =  true;
                chest.GetComponent<Animator>().Play("OpenChest");
            }
            
        }
    }
}
