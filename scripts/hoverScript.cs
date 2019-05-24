using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;


public class hoverScript : MonoBehaviour
{
    public UnityEngine.GameObject canvas;
    private EventSystem eventSystem;
    private GraphicRaycaster raycaster;
    private PointerEventData pointerData;
    private UpgradeScriptBuilding script;
    private ClickUpgrades script2;
    public GameObject selectedObject;
    public TextMeshProUGUI Desc;
    public GameObject textBox;
    
    private void Start()
    {
        eventSystem = canvas.GetComponent<EventSystem>();
        raycaster = canvas.GetComponent<GraphicRaycaster>();
    }

    private void Update()
    {
        selectedObject = CheckPosition();
        CheckButton();
    }

    private GameObject CheckPosition()
    {
        pointerData = new PointerEventData(eventSystem);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        raycaster.Raycast(pointerData, results);

        if (results.Count > 0) return results[0].gameObject;

        return null;
    }

    private void CheckButton() //Deals with purchasing an upgrade
    {
        if (selectedObject != null)
        {
            if (selectedObject.GetComponent<UpgradeScriptBuilding>() != null)
            {
                script = selectedObject.GetComponent<UpgradeScriptBuilding>();
                textBox.SetActive(true);
                print(script.desc);
                Desc.text = (script.Desc);

            }
            else textBox.SetActive(false);

            if (selectedObject.GetComponent<ClickUpgrades>() !=null)
            {
                script2 = selectedObject.GetComponent<ClickUpgrades>();
                textBox.SetActive(true);
                print(script2.Desc);
                Desc.text = (script2.Desc);

            }
            
        }

    }
 
}
