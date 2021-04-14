using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LuckyComponent))]
public class LuckyComponentInspector : Editor
{
    public override void OnInspectorGUI()
    {
        LuckyComponent t = (LuckyComponent) target;
        t.min = EditorGUILayout.FloatField("Min", t.min);
        t.max = EditorGUILayout.FloatField("Max", t.max);
        EditorGUILayout.MinMaxSlider("Range", ref t.min, ref t.max, -50f, 50f);

        EditorGUILayout.BeginHorizontal();

        t.value = EditorGUILayout.FloatField("Value", t.value);

        if(GUILayout.Button("Randomize"))
        {
            t.value = Random.Range(t.min, t.max);
        }

        EditorGUILayout.EndHorizontal();

        t.min = Mathf.Round(t.min);
        t.max = Mathf.Round(t.max);
        t.value = Mathf.Round(t.value);
    }
}
