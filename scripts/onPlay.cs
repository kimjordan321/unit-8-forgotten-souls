using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPlay : MonoBehaviour
{

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
        Reset();

    }
	
	// Update is called once per frame
	public void Reset ()
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
