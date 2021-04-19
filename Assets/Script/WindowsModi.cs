using UnityEngine;
using UnityEditor;

public class WindowsModi : EditorWindow{

    Color color;

   [MenuItem("Window/Colorizador")]
   public static void ShowWindow ()
    {
        GetWindow<WindowsModi>("Colorizador");
    }


    void OnGUI ()
    {
        GUILayout.Label("Colorear objeto seleccionado", EditorStyles.boldLabel);

       color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorear"))
        {
            Colorize();
        }
    }
    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}
