using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ColorPoint))]
public class ColorPointDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        /*label = EditorGUI.BeginProperty(position, label, property);
        Rect contentPosition = EditorGUI.PrefixLabel(position, label);

        if(position.height > 18f)
        {
            position.height = 18f;
            EditorGUI.indentLevel += 1;
            contentPosition = EditorGUI.IndentedRect(position);
            contentPosition.y += 20; 
        }
        contentPosition.width *= 0.75f;
        EditorGUI.indentLevel = 0;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("position"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        contentPosition.width /= 3f;
        EditorGUIUtility.labelWidth = 14f;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("color"), new GUIContent("C"));
        EditorGUI.EndProperty();
        */

        /*if(GUI.Button(contentPosition, "Generate"))
        {
            //criar uma parada de min
            //criar uma parada de max
            //um botão pra ser clicado e gerar um valor
            //criar uma parada para receber o valor
            var min = property.FindPropertyRelative("Min").intValue;
            var max = property.FindPropertyRelative("Max").intValue + 1;
            var newValue = Random.Range(min, max);
            property.FindPropertyRelative("RandomNumber").intValue = newValue;
        }*/
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return Screen.width < 331 ? (18f + 20f) : 18f;
    }
}
