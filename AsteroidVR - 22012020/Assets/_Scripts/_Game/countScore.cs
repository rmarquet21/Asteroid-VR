using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countScore : MonoBehaviour
{
    public static int score;

    private TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMesh>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score.ToString();
    }
    
}
