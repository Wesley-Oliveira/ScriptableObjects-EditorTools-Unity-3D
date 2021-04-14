using UnityEditor;
using UnityEngine;

public class WindowImage : EditorWindow
{
    private Rect boxRect;
    private GUIStyle boxStyle;
    private Vector2 imagePosition = new Vector2(0, 0);
    private bool isDragging;

    [MenuItem("Window/Window Image")]
    private static void OpenWindow()
    {
        WindowImage window = GetWindow<WindowImage>();
        window.titleContent = new GUIContent("Window Image");
    }

    private void OnEnable()
    {
        boxStyle = new GUIStyle();
        boxStyle.normal.background = Resources.Load("hp") as Texture2D;
    }

    private void OnGUI()
    {
        boxRect = new Rect(imagePosition, new Vector2(100, 100));
        GUI.Box(boxRect, GUIContent.none, boxStyle);

        ProcessEvents(Event.current);
        if (GUI.changed) Repaint();
    }

    private void ProcessEvents(Event e)
    {
        switch (e.type)
        {
            case EventType.MouseDown:
                if (e.button == 0 && boxRect.Contains(e.mousePosition))
                    isDragging = true;
                break;
            case EventType.MouseUp:
                isDragging = false;
                break;
        }
        Drag(e);
    }

    private void Drag(Event e)
    {
        if (isDragging)
        {
            imagePosition = e.mousePosition - (boxRect.size * 0.5f);
            EditorGUIUtility.AddCursorRect(boxRect, MouseCursor.Pan);
            Repaint();
        }
    }
}
