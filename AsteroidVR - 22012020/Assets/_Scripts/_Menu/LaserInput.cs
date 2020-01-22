using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Valve.VR;
using Valve.VR.Extras;

public class LaserInput : MonoBehaviour
{

    private SteamVR_LaserPointer laserPointer;
    public SteamVR_Action_Boolean shootAction;
    public SteamVR_Input_Sources handType;

    private void OnEnable()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerIn -= HandlePointerIn;
        laserPointer.PointerIn += HandlePointerIn;
        laserPointer.PointerOut -= HandlePointerOut;
        laserPointer.PointerOut += HandlePointerOut;

        
        
    }

    private void Update()
    {
        if (shootAction.GetLastState(handType))
        {
            HandleTriggerClicked();
            Debug.Log("clic");
        }
        Cursor.lockState = CursorLockMode.Locked;
    }

    

    private void HandleTriggerClicked()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
    }

    private void HandlePointerIn(object sender, PointerEventArgs e)
    {
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            button.Select();
            Debug.Log("HandlePointerIn", e.target.gameObject);
        }
    }

    private void HandlePointerOut(object sender, PointerEventArgs e)
    {

        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Debug.Log("HandlePointerOut", e.target.gameObject);
        }
    }
}
