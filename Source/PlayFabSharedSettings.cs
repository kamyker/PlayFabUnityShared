using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("PlayFabSDK")]
namespace PlayFab
{
	[CreateAssetMenu(fileName = "PlayFabSharedSettings", menuName = "PlayFab/CreateSharedSettings", order = 1)]
	public class PlayFabSharedSettings : ScriptableObject
	{
		public string TitleId;
		internal string VerticalName = null;
#if ENABLE_PLAYFABSERVER_API || ENABLE_PLAYFABADMIN_API || UNITY_EDITOR
		public string DeveloperSecretKey;
#endif
		public string ProductionEnvironmentUrl = "";

		public WebRequestType RequestType = WebRequestType.UnityWebRequest;

		public string AdvertisingIdType;
		public string AdvertisingIdValue;

		public bool DisableAdvertising;
		public bool DisableDeviceInfo;
		public bool DisableFocusTimeCollection;

		public int RequestTimeout = 2000;
		public bool RequestKeepAlive = true;
		public bool CompressApiData = true;

		public PlayFabLogLevel LogLevel = PlayFabLogLevel.Warning | PlayFabLogLevel.Error;
		public string LoggerHost = "";
		public int LoggerPort = 0;
		public bool EnableRealTimeLogging = false;
		public int LogCapLimit = 30;
	}

	public enum WebRequestType
	{
#if !UNITY_2018_2_OR_NEWER // Unity has deprecated Www
        UnityWww, // High compatability Unity api calls
#endif
		UnityWebRequest, // Modern unity HTTP component
		HttpWebRequest, // High performance multi-threaded api calls
		CustomHttp //If this is used, you must set the Http to an IPlayFabHttp object.
	}

	[Flags]
	public enum PlayFabLogLevel
	{
		None = 0,
		Debug = 1 << 0,
		Info = 1 << 1,
		Warning = 1 << 2,
		Error = 1 << 3,
		All = Debug | Info | Warning | Error,
	}
}
