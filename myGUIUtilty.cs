using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myGUIUtilty : MonoBehaviour
{
    public Rect rect;
    List<string> texts;
    // Start is called before the first frame update
    void Start()
    {
        rect = new Rect(10, 10, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        texts = new List<string>();
        texts.Clear();
        for (int i = 0; i < 10; i++)
        {
            var rand = Random.Range(10, 10000);
            texts.Add(rand.ToString());
        }
    }

    private void OnGUI()
    {
        TextItemize(rect, texts, Color.blue, "label", 30);
    }

    public void TextItemize(Rect rect, List<string> texts, Color color, string title = "", int fontSize = 10)
    {
        
        var mergeText = "";
        if (title != "")
        {
            mergeText += title; 
            mergeText += "\n";
        }
        foreach (var text in texts)
        {
            mergeText += text;
            mergeText += "\n";
        }
     
        var gUIContent = new GUIContent(mergeText);
      
        var guiStyle = new GUIStyle();
        guiStyle.fontSize = fontSize;
        guiStyle.CalcSize(gUIContent);
        guiStyle.normal.textColor = color;

       
        GUI.TextArea(rect, mergeText, guiStyle);
        
    }

    public void TextItemize(Vector2 pos, List<string> texts, Color color, string title = "", int fontSize = 10)
    {
        var rect = new Rect(pos, pos);
        var mergeText = "";
        if (title != "")
        {
            mergeText += title;
            mergeText += "\n";
        }
        foreach (var text in texts)
        {
            mergeText += text;
            mergeText += "\n";
        }

        var gUIContent = new GUIContent(mergeText);

        var guiStyle = new GUIStyle();
        guiStyle.fontSize = fontSize;
        guiStyle.CalcSize(gUIContent);
        guiStyle.normal.textColor = color;

        GUI.TextArea(rect, mergeText, guiStyle);

    }
}
