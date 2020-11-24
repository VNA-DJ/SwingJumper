using UnityEngine;
using System.Collections;
using StartApp;

public class StartAppInterstitial : MonoBehaviour {


		
	void Start () {
		#if UNITY_ANDROID
		StartAppWrapper.init();
		StartAppWrapper.showAd();
		StartAppWrapper.loadAd();
		#endif
	}
}
