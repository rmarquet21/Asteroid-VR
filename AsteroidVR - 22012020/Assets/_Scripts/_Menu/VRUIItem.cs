using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class VRUIItem : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;


    private void Update()
    {
        if (gameObject.GetComponentInParent<Canvas>().isActiveAndEnabled == false)
        {
            Destroy(GetComponent<Collider>());
        }
        else
        {
            ValidateCollider();
        }
    }

    public void ValidateCollider()
    {
        
        rectTransform = GetComponent<RectTransform>();

        boxCollider = GetComponent<BoxCollider>();

        if (boxCollider == null && gameObject.activeSelf)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }
            boxCollider.size = rectTransform.sizeDelta;
    }
}