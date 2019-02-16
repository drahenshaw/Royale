using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [Header("Interface Elements")]
    [SerializeField] private Text resourcesText;

    [Header("Tool Selector")]
    [SerializeField] private GameObject toolFocus;
    [SerializeField] private GameObject[] tools;

    public int ResourcesText
    {
        //get { return resourcesText.text; }
        set { resourcesText.text = "Resources: " + value; }
    }


  


    // Start is called before the first frame update
    void Start()
    {
        toolFocus.transform.position = new Vector3(
            tools[0].transform.position.x,
            tools[0].transform.position.y
            );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
