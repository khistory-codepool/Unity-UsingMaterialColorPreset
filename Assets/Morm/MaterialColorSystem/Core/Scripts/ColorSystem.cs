using System;
using UnityEngine;

namespace Morm.MaterialDesign
{
    [ExecuteAlways]
    public class ColorSystem : MonoBehaviour
    {
        private static ColorSystem s_instance; 
        public static ColorSystem Instance { get { Init(); return s_instance; } }

        private const string HierarchyObjName = "@ColorSystem";
        private const string PlayerPrefSaveKey = "SaveColorTheme";
        
        //Resources path
        private const string LightPath = "ColorSystem/Light";
        private const string DarkPath = "ColorSystem/Dark";
        
        private ColorPreset CurrentPreset { get
        {
            if (currentTheme.Equals(Theme.Light)) return _lightPreset;
            return _darkPreset;
        }}
        private ColorPreset _lightPreset;
        private ColorPreset _darkPreset;
        private readonly Color _errColor = Color.red;

        public enum Theme { Light, Dark, }
        public Theme currentTheme;
        public Action OnThemeChanged;
        
        private void Awake()
        {
            Init();

            TryResourcesLoadColorPreset(Theme.Light);
            TryResourcesLoadColorPreset(Theme.Dark);

            LoadSavedCurrentTheme();
        }

        /// <param name="alpha">0~1</param>
        public Color GetColor(ColorType targetColorType, float alpha = 1)
        {
            Color getColor = TryGetColor(targetColorType);
            
            alpha = Mathf.Clamp(alpha, 0, 1);
            getColor.a = alpha;

            return getColor;
        }
        
        public void ChangeTheme(Theme theme)
        {
            currentTheme = theme;
            SaveCurrentTheme();
            OnThemeChanged?.Invoke();
        }

        private Color TryGetColor(ColorType targetColorType)
        {
            try
            {
                return CurrentPreset.dic[targetColorType];
            }
            catch (Exception e)
            {
                Debug.LogWarning(e);
                if (TryResourcesLoadColorPreset(Theme.Light))
                    return _lightPreset.dic[targetColorType];
                else if (TryResourcesLoadColorPreset(Theme.Dark))
                    return _darkPreset.dic[targetColorType];
                else
                    return _errColor;
            }
        }

        private bool TryResourcesLoadColorPreset(Theme theme)
        {
            switch (theme)
            {
                case Theme.Light:
                    _lightPreset = Resources.Load<ColorPreset>(LightPath);
                    return _lightPreset != null;
                case Theme.Dark:
                    _darkPreset = Resources.Load<ColorPreset>(DarkPath);
                    return _darkPreset != null;
            }

            return false;
        }
        
        private void LoadSavedCurrentTheme()
        {
            if (PlayerPrefs.HasKey(PlayerPrefSaveKey))
                currentTheme = (Theme)PlayerPrefs.GetInt(PlayerPrefSaveKey);
        }
        
        private void SaveCurrentTheme()
        {
            PlayerPrefs.SetInt(PlayerPrefSaveKey, (int)currentTheme);
        }

        static void Init()
        {
            if (s_instance == null)
            {
                GameObject obj = GameObject.Find(HierarchyObjName);
                if (obj == null)
                {
                    obj = new GameObject {name = HierarchyObjName};
                    obj.AddComponent<ColorSystem>();
                }
                s_instance = obj.GetComponent<ColorSystem>();
                
                if(Application.isPlaying)
                    DontDestroyOnLoad(obj);
            }
        }
    }
}
