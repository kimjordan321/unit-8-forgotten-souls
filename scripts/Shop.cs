using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public Upgrades upgrade;
    public TextMeshProUGUI UpgradeCostD;
    public TextMeshProUGUI UpgradeNameD;
    public Vector2 Panel1pos;
    public GameObject panel1;
    public GameObject LdemonPic;
    

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1.0f;
    }

   

    // Update is called once per frame
    void FixedUpdate ()
    {
        ClickSouls.souls += upgrade.Count * upgrade.BasePerSec * upgrade.Efficiency * Time.deltaTime;
        UpgradeCostD.text = Mathf.Floor(upgrade.price).ToString();
        UpgradeNameD.text = upgrade.name;
    }

    public void buyUpgrade()
    {
        if (ClickSouls.souls >= upgrade.price )
        {
            ClickSouls.souls -= upgrade.price;
            upgrade.Count++;
            print(upgrade.Count);
            upgrade.price *= 1.11f;
            spawnIcon();
        }
    }

    public void spawnIcon()
    {
        Panel1pos = panel1.transform.position;
        GameObject upgrade = Instantiate(LdemonPic, new Vector2(panel1.transform.position.x, panel1.transform.position.y), Quaternion.identity /*UpgradePanel.transform.parent*/);
        upgrade.transform.parent = panel1.transform;
    }

    
}
