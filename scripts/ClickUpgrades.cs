using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickUpgrades : MonoBehaviour {

    public static float clickUpgradePrice = 100;
    public static float clickUpgradePercentPrice = 500;
    public static bool ClickUpgradeReady = true;
    public static bool ClickUpgradeReady2 = true;
    public static bool ClickPercentUpgradeReady = true;
    public int LesserDemonRequirement = 10;
    public EfficiencyUpgrades efficiencyUpgrades;
    public Upgrades AllUpgrade;
    public Upgrades GhostCar;
    public int GhostCarRequirement = 10;
    public Upgrades LesserDemon;
    public string Desc;

	// Use this for initialization
	void Start ()
    {
        efficiencyUpgrades = GetComponent<EfficiencyUpgrades>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Desc = "Increases your click amount! Cost: " + clickUpgradePrice;
        spawnUpgrades();
        spawnUpgrade2();
        Desc = "Increases your click amount! Cost: " + clickUpgradePrice;
    }

    public void BuyX2Upgrade()
    {
        if (ClickSouls.souls >= clickUpgradePrice)
        {
            ClickSouls.souls -= clickUpgradePrice;
            clickUpgradePrice *= 1.5f;
            ClickSouls.click *= 2;
            ClickUpgradeReady = true;
            Destroy(this.gameObject);
        }
    }

   

    public void Buy10PercentUpgrade()
    {
        if (ClickSouls.souls >= clickUpgradePercentPrice)
        {
            ClickSouls.souls -= clickUpgradePercentPrice;
            clickUpgradePercentPrice *= 1.5f;
            ClickSouls.click *= 1.10f;
            ClickPercentUpgradeReady = true;
            Destroy(this.gameObject);
        }
    }

    public void spawnUpgrades()
    {
        if (ClickUpgradeReady == true && LesserDemon.Count >= LesserDemonRequirement)
        {
            efficiencyUpgrades.SpawnUpgrade();
            LesserDemonRequirement += 10;
        }
    }

    public void spawnUpgrade2()
    {
        if (ClickUpgradeReady2 == true && GhostCar.Count >= GhostCarRequirement)
        {
            efficiencyUpgrades.SpawnUpgrade2();
            GhostCarRequirement += 10;
        }
    }

   
}
