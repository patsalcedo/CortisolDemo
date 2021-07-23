using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using UnityEngine;
using UnityEngine.UI;

public class QTScript : MonoBehaviour
{
    public float fillAmount;
    public float timeThreshold;
    public string eventSuccess = "n";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            fillAmount += .1f;
        }

        timeThreshold += Time.deltaTime;

        if (timeThreshold > .1)
        {
            timeThreshold = 0;
            fillAmount -= .02f;
        }

        if (fillAmount < 0)
        {
            fillAmount = 0;
        }

        if (fillAmount > 1)
        {
            eventSuccess = "y";
            Debug.Log(eventSuccess);
        }
        
        GetComponent<Image>().fillAmount = fillAmount;

    }
}
