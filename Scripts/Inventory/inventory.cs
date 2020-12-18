using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventoty;
    private bool inventoryOn;

    private void Start()
    {
        inventoryOn = false;
    }

    public void Chest()
    {
        if (inventoryOn == false)
        {
            inventoryOn = true;
            inventoty.SetActive(true);
        }
        else if (inventoryOn == true)
        {
            inventoryOn = false;
            inventoty.SetActive(false);
        }
    }
}
