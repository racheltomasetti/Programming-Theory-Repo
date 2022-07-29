using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//INHERITANCE
public class Square : Shape
{
    private string name = "Square";
    public TextMeshProUGUI nameText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
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
        nameText.text = "Name: " + SquareName;
        Debug.Log("hello");
    }
    void EraseNames()
    {
        nameText.gameObject.SetActive(false);
    }
    //ENCAPSULATION
    public string SquareName
    {
        get { return name; }
    }
}
