using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Example : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public GameObject upgradeDesc;

    public UpgradeScriptBuilding script;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        script.ShowUpgradeDesc();
        upgradeDesc.SetActive(true);
        Debug.Log("Cursor Entering " + name + " GameObject");
    }


    public void OnPointerExit(PointerEventData pointerEventData)
    {
        upgradeDesc.SetActive(false);
        Debug.Log("Cursor Exiting " + name + " GameObject");
    }
}