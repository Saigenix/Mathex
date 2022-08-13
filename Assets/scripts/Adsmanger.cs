using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Adsmanger : MonoBehaviour,IUnityAdsListener
{
   
   
  static public bool succad = false;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4439669");
        Advertisement.AddListener(this);
        bannerad();
    }
   



    public void playvideo(){

            if (Advertisement.IsReady("Interstitial_Android"))
            {
                Advertisement.Show("Interstitial_Android");
            }

    }
    public void playvideoreward(){

            if (Advertisement.IsReady("Rewarded_Android"))
            {
               succad =true;
                Advertisement.Show("Rewarded_Android");
            }else {

                succad=false;
            }

    }
    public void bannerad(){

            if (Advertisement.IsReady("Banner_Android"))
            {
                Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
                Advertisement.Banner.Show("Banner_Android");
            }else {

                StartCoroutine(repeatshowbanner());
            }

    }
     IEnumerator repeatshowbanner(){
        yield return new WaitForSeconds(2);
        bannerad();

    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("something happen");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("something happen");
        succad=false;
        
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("something happen");
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {

            if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
            {
                succad=true;
            }

    }
}
