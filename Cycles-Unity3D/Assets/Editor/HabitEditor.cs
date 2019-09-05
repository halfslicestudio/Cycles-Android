using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HabitManager))]
public class HabitEditor : Editor
{
    int dayFlags = 0;
    string[] days = new string[] { "Sunday","Monday","Tuesday","Wednesday","Thursday", "Friday", "Saturday" };
    string HName;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.HelpBox("Custom editor by Laurence", MessageType.Info);
        var hm = (HabitManager)target;
        foreach(Habit h in hm.AllHabits)
        {
            EditorGUILayout.HelpBox("Habit Name:", MessageType.None);
            HName = GUILayout.TextField(HName);
            
            h.SetName(HName);

            dayFlags = EditorGUILayout.MaskField(dayFlags, days);
            Debug.Log(dayFlags);
            if (HName != string.Empty)
            {
                if (GUILayout.Button(h.GetName()))
                {

                }
            }
        }
        

    }
}
