using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfficiencyUpgrades : MonoBehaviour {

    public GameObject UpgradePanel;
    public GameObject Upgradepanel;
    public Vector2 UpgradePanelPos;
    public GameObject Upgrade;
    public GameObject Upgrade2;
    public Upgrades BuildingUpgrade;
    public int buildingUpgradeReq = 10;
    public bool upgradeReady;
    public bool firstUpgrade = true;


	// Use this for initialization
	public void SpawnUpgrade ()
    {
        UpgradePanelPos = UpgradePanel.transform.position;
        GameObject upgrade = Instantiate(Upgrade, new Vector2 (UpgradePanel.transform.position.x, UpgradePanel.transform.position.y), Quaternion.identity /*UpgradePanel.transform.parent*/) ;
        upgrade.transform.parent = Upgradepanel.transform;
        print("Spawn Upgrade Added.");
    }

    public void SpawnUpgrade2()
    {
        UpgradePanelPos = UpgradePanel.transform.position;
        GameObject upgrade2 = Instantiate(Upgrade2, new Vector2(UpgradePanel.transform.position.x, UpgradePanel.transform.position.y), Quaternion.identity /*UpgradePanel.transform.parent*/);
        upgrade2.transform.parent = Upgradepanel.transform;
        print("Spawn Upgrade2 Added.");
    }

    public void Update()
    {
        if (BuildingUpgrade.Count >= buildingUpgradeReq && firstUpgrade == true)
        {
                print("first Upgrade");
                SpawnUpgrade();
                buildingUpgradeReq += 15;
                firstUpgrade = false;
        }

        if (BuildingUpgrade.Count >= buildingUpgradeReq && firstUpgrade == false)
        {
            print("More than one upgrade");
            SpawnUpgrade();
            buildingUpgradeReq += 25;

        }
    }
}
