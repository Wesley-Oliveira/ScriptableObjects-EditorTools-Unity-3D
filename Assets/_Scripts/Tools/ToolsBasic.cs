using UnityEngine;

public class ToolsBasic : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 100), "Teste");

        if (GUI.Button(new Rect(120, 10, 100, 30), "Botão"))
        {
            Debug.Log("Apertou botão!");
        }
    }
}
