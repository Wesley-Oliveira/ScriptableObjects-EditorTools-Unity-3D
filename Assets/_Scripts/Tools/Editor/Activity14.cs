using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Activity14Base))]
public class Activity14 : Editor
{
    public override void OnInspectorGUI()
    {
        Activity14Base t = (Activity14Base)target;
        t.min = EditorGUILayout.FloatField("Min", t.min);
        t.max = EditorGUILayout.FloatField("Max", t.max);

        EditorGUILayout.BeginHorizontal();

        t.value = EditorGUILayout.FloatField("Value", t.value);

        if (GUILayout.Button("Randomize"))
        {
            t.value = Random.Range(t.min, t.max);
        }

        EditorGUILayout.EndHorizontal();

        t.min = Mathf.Round(t.min);
        t.max = Mathf.Round(t.max);
        t.value = Mathf.Round(t.value);
    }
}
