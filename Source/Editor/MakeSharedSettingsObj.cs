#if UNITY_2017_1_OR_NEWER
using UnityEditor;
using UnityEngine;

namespace PlayFab
{
    public static class MakeScriptableObject
    {
        [MenuItem("PlayFab/MakePlayFabSharedSettings")]
        public static void MakePlayFabSharedSettings()
        {
            PlayFabSharedSettings asset = ScriptableObject.CreateInstance<PlayFabSharedSettings>();

            AssetDatabase.CreateAsset(asset, "Assets/PlayFabSDK/PlayFabSharedSettings.asset"); // TODO: Path should not be hard coded
            AssetDatabase.SaveAssets();

            EditorUtility.FocusProjectWindow();

            Selection.activeObject = asset;
        }
    }
}
#endif
