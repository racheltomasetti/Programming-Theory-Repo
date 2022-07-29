using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//INHERITANCE
public class Circle : Shape
{
    private string name = "Circle";
    public TextMeshProUGUI nameText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            DisplayInfo();
        }
        //ABSTRACTION
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EraseNames();
        }

    }
    //POLYMORPHISM
    protected override void DisplayInfo()
    {
        nameText.gameObject.SetActive(true);
        nameText.text = "Name: " + CircleName;
    }
    void EraseNames()
    {
        nameText.gameObject.SetActive(false);
    }
    //ENCAPSULATION
    public string CircleName
    {
        get { return name; }
    }
}
