using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MenuManager : MonoBehaviour
{

    public GameObject panelMain;
    public Panel currentPanel = null;
    private List<Panel> panelHistory = new  List<Panel>();

    // Start is called before the first frame update
    private void Start()
    {
        SetupPanels();
    }

    // Update is called once per frame
    private void SetupPanels()
    {
        Panel[] panels = GetComponentsInChildren<Panel>();

        foreach(Panel panel in panels)
            panel.Setup(this);
        currentPanel.Show();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            GoToPrevious();
    }

    public void GoToPrevious()
    {
        currentPanel.Hide();
        panelMain.GetComponent<Canvas>().enabled = true ;      
    }

    public void SetCurrentWithHistory(Panel panel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(panel);
    }

    private void SetCurrent(Panel panel)
    {
        currentPanel.Hide();
        currentPanel = panel;
        currentPanel.Show();
    }

}
