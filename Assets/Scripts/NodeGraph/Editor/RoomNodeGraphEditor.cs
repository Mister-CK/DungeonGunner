using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class RoomNodeGraphEditor : EditorWindow
{
    // Node layout values
    private const float nodeWidth = 160f;
    private const float nodeHeight = 75f;
    private const int nodePadding = 25;
    private const int nodeBorder = 12;
    private GUIStyle roomNodeStyle;
    [MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
    private static void OpenWindow()
    {
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
    }

    private void OnEnable()
    {
        // Define node layout style
        roomNodeStyle = new GUIStyle();
        roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
        roomNodeStyle.normal.textColor = Color.white;
        roomNodeStyle.padding = new RectOffset(nodePadding, nodePadding, nodePadding, nodePadding);
        roomNodeStyle.border = new RectOffset(nodeBorder, nodeBorder, nodeBorder, nodeBorder);
    }

    private void OnGUI()
    {
        // Draw one node
        float nodePositionX = 100f;
        float nodePositionY = 100f;
        GUILayout.BeginArea(new Rect(new Vector2(nodePositionX, nodePositionY), new Vector2(nodeWidth, nodeHeight)), roomNodeStyle);
        EditorGUILayout.LabelField("Node 1");
        GUILayout.EndArea();

        // Draw second node
        nodePositionX = 300f;
        nodePositionY = 300f;
        GUILayout.BeginArea(new Rect(new Vector2(nodePositionX, nodePositionY), new Vector2(nodeWidth, nodeHeight)), roomNodeStyle);
        EditorGUILayout.LabelField("Node 2");
        GUILayout.EndArea();
    }
}
