using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class PerlibWindow : EditorWindow
{
    #region Public Vars
    #endregion

    #region Private Vars
    #endregion

    #region Public Functions
    #endregion

    #region Private Functions
    static PerlibWindow()
    {
        if (!EditorPrefs.GetBool("SardonicMe.Perlib.HasRunBefore"))
            Init();
    }

    [MenuItem("Window/Sardonic Me/Perlib")]
    static void Init()
    {
        EditorWindow window = EditorWindow.GetWindow<PerlibWindow>("Perlib");
        window.maxSize = new Vector2(355f, 400f);
        window.minSize = new Vector2(355f, 400f);
        window.Show();
    }

    void OnGUI()
    {
        Texture2D logo = EditorGUIUtility.Load("Sardonic Me/Perlib/Logo.png") as Texture2D;

        GUILayout.Box(logo);

        if (!EditorPrefs.GetBool("SardonicMe.Perlib.HasRunBefore"))
        {
            GUILayout.Space(20f);
            GUILayout.Label("Thank you for purchasing Perlib.");
        }

        GUILayout.Space(20f);

        GUILayout.Label("Please visit our thread if you need\nany help, have suggestions, or comments.");
        if (GUILayout.Button("Unity Thread"))
            Application.OpenURL(@"http://forum.unity3d.com/threads/released-perlib-a-better-safer-file-based-playerprefs.333989/");

        GUILayout.Space(20f);

        GUILayout.Label("You can also always contact me at: kaya@sardonic.me");

        GUILayout.Space(20f);

        GUILayout.Label("If you like Perlib, please take a moment to rate it\non the Asset Store. It helps a lot :)");
    }

    void OnDestroy()
    {
        EditorPrefs.SetBool("SardonicMe.Perlib.HasRunBefore", true);
    }
    #endregion
}
