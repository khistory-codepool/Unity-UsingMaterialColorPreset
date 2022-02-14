using UnityEditor;
using UnityEngine;

namespace Morm.MaterialDesign
{
    [CustomEditor(typeof(ColorPreset))]
    public class ColorPresetEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            ColorPreset colorPreset = (ColorPreset)target;

            GUILayout.Space(12);
            if (GUILayout.Button("LoadColorXml_Light"))
            {
                colorPreset.LoadXML();
            }
            if (GUILayout.Button("LoadColorXml_Dark"))
            {
                colorPreset.LoadXML(true);
            }
        }
    }
}
