using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Produces waste but increases City's value
/// </summary>
public class Factory : Building
{
    public int goldCoinsOutput=0;
    public Factory()
    {
        DID = GameManager.instance.dataIDList.FindDataID("factory");
        polProg = GameManager.instance.polProg[2].progression[DID];
        pollutionOutput = polProg[1];
        goldCoinsOutput = 20;
        ResourceManager.instance.goldOutput = goldCoinsOutput;
        UpdatePollution();
    }
}
