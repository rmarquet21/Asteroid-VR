using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Panel : MonoBehaviour
{
    private Canvas canvas = null;
    private MenuManager menuManager;

    public void Awake()
    {
        canvas = GetComponent<Canvas>(); 
    }

    public void Setup(MenuManager menuManager)
    {
        this.menuManager = menuManager;
        Hide();
    }

    public void Show()
    {
        canvas.enabled = true;

    }

    public void Hide()
    {
        canvas.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
