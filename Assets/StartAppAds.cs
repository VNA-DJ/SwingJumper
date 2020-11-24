using UnityEngine;
using System.Collections;
using StartApp;

public class StartAppAds : MonoBehaviour {

	void Start () {
		#if UNITY_ANDROID
		StartAppWrapper.addBanner( 
		                          StartAppWrapper.BannerType.AUTOMATIC,
		                          StartAppWrapper.BannerPosition.TOP);

		#endif
	}
}
