using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterAd : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        AdColony.Ads.RequestInterstitialAd("zone_id_1", null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostrarInter()
    {
        if (_ad != null)
        {
            AdColony.Ads.ShowAd(_ad);
        }
    }
}
