using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeScriptBuilding : MonoBehaviour {

    public Upgrades Upgrade;
    public int UpgradePrice;
    public GameObject upgradeDesc;
    public TextMeshProUGUI desc;
    [SerializeField]
    public Ray ray;
    public RaycastHit hit;
    public string Desc;

    public void ShowUpgradeDesc()
    {
        upgradeDesc.SetActive(true);
    }

	public void BuyUpgrade ()
    {
		if (ClickSouls.souls >= UpgradePrice)
        {
            Upgrade.Efficiency *= 2;
            ClickSouls.souls -= UpgradePrice;
            UpgradePrice *= 2;
            Destroy(this.gameObject);
        }
	}

    public void Update()
    {
        print("Desc");
        Desc = "An efficiency upgrade for your minions, cost: " + UpgradePrice + " It increases your efficiency by 2x";
        print("Desc");
    }

}
