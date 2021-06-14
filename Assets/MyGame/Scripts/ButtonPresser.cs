using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresser : MonoBehaviour
{
    public ClickData ClickData;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickData.clickInfoRuntime > 100)
        {
            ClickData.clickInfoRuntime = 0;
        }
    }

    private void Counter()
    {
        ClickData.clickInfoRuntime += 10;
    }

    private void OnMouseDown()
    {
        Counter();
    }
}
