using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascension : MonoBehaviour {

    public static float freedSoul;
    public static int freedSoulsReq = 1000000;
    public onPlay script;
    
    public GameObject UpgradePanel;
    public GameObject Upgradepanel;
    public Vector2 UpgradePanelPos;
    public GameObject Upgrade;
    public bool AscensionSpawned = false;

    public Upgrades GhostCar;
    public Upgrades HODS;
    public Upgrades GhostTrain;
    public Upgrades LD;
    public Upgrades UC;
    public Upgrades UM;
    public Upgrades UD;


    // Use this for initialization
    void Start ()
    {
        script = gameObject.GetComponent<onPlay>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (ClickSouls.souls > freedSoulsReq && AscensionSpawned == false)
        {
            UpgradePanelPos = UpgradePanel.transform.position;
            GameObject upgrade = Instantiate(Upgrade, new Vector2(UpgradePanel.transform.position.x, UpgradePanel.transform.position.y), Quaternion.identity /*UpgradePanel.transform.parent*/);
            upgrade.transform.parent = Upgradepanel.transform;
            AscensionSpawned = true;
        }
	}

    public void ascend()
    {
        if (ClickSouls.souls > freedSoulsReq)
        {
            print("ascend start");
            Reset();
            print("reset Done");
            freedSoul += 1;
            freedSoul *= 0.0001f * ClickSouls.souls;
            print(freedSoul);
            ClickSouls.souls = 0;
            print("ascend end");
            AscensionSpawned = false;
            destroy();
            print(AscensionSpawned);
            Destroy(this.gameObject);
        }
    }
    public void destroy()
    {
        GameObject[] icons = GameObject.FindGameObjectsWithTag("icons");
        foreach (GameObject icon in icons)
            GameObject.Destroy(icon);
    }
    

    public void Reset()
    {
        GhostCar.price = Baseupgradenumbers.GhostCarprice;
        GhostCar.BasePerSec = Baseupgradenumbers.GhostCarBasePerSec;
        GhostCar.Efficiency = Baseupgradenumbers.GhostCarEfficiency;
        GhostCar.Count = Baseupgradenumbers.GhostCarCount;

        HODS.price = Baseupgradenumbers.HODSprice;
        HODS.BasePerSec = Baseupgradenumbers.HODSBasePerSec;
        HODS.Count = Baseupgradenumbers.HODSCount;
        HODS.Efficiency = Baseupgradenumbers.HODSEfficiency;

        GhostTrain.price = Baseupgradenumbers.GhostTrainprice;
        GhostTrain.BasePerSec = Baseupgradenumbers.GhostTrainBasePerSec;
        GhostTrain.Efficiency = Baseupgradenumbers.GhostTrainEfficiency;
        GhostTrain.Count = Baseupgradenumbers.GhostTrainCount;

        LD.price = Baseupgradenumbers.LDPrice;
        LD.BasePerSec = Baseupgradenumbers.LDBasePerSec;
        LD.Count = Baseupgradenumbers.LDCount;
        LD.Efficiency = Baseupgradenumbers.LDEfficiency;

        UC.price = Baseupgradenumbers.UCprice;
        UC.Efficiency = Baseupgradenumbers.UCEfficiency;
        UC.Count = Baseupgradenumbers.UCCount;
        UC.BasePerSec = Baseupgradenumbers.UCBasePerSec;

        UM.price = Baseupgradenumbers.UMprice;
        UM.BasePerSec = Baseupgradenumbers.UMBasePerSec;
        UM.Count = Baseupgradenumbers.UMCount;
        UM.Efficiency = Baseupgradenumbers.UMEfficiency;

        UD.price = Baseupgradenumbers.UDprice;
        UD.BasePerSec = Baseupgradenumbers.UDBasePerSec;
        UD.Count = Baseupgradenumbers.UDCount;
        UD.Efficiency = Baseupgradenumbers.UDEfficiency;
    }


}
