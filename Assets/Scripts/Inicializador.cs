using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicializador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] zoneIds = new string[] { "", "" };
        AdColony.Ads.Configure("appc9c75aa4c17b4d49a4", null, zoneIds);
    }

    // Update is called once per frame
    void Update()
    {
        AdColony.InterstitialAd _ad = null;

        AdColony.Ads.OnRequestInterstitial += (AdColony.InterstitialAd ad) => {
            _ad = ad;
        };

        AdColony.Ads.OnExpiring += (AdColony.InterstitialAd ad) => {
            AdColony.Ads.RequestInterstitialAd(ad.ZoneId, null);
        };
    }
}
