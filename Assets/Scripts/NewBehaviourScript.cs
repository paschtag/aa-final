using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text finalScore;

    void Start()
    {
        finalScore.text = Score.PinCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
