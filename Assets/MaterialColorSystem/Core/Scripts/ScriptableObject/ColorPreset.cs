using System.Xml;
using UnityEngine;

namespace Morm.ColorSystem
{
    public enum ColorType
    {
        Primary,
        OnPrimary,
        PrimaryContainer,
        OnPrimaryContainer,
        Secondary,
        OnSecondary,
        SecondaryContainer,
        OnSecondaryContainer,
        Tertiary,
        OnTertiary,
        TertiaryContainer,
        OnTertiaryContainer,
        Error,
        OnError,
        ErrorContainer,
        OnErrorContainer,
        Background,
        OnBackground,
        Surface,
        OnSurface,
        SurfaceVariant,
        OnSurfaceVariant,
        Outline,
        InverseSurface,
        InverseOnSurface,
        InversePrimary,
        Shadow,
        PrimaryInverse,
    }

    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MaterialColorPreset", order = 1)]
    public class ColorPreset : ScriptableObject
    {
        public TextAsset xmlFile;

        public Color Primary;
        public Color OnPrimary;
        public Color PrimaryContainer;
        public Color OnPrimaryContainer;
        public Color Secondary;
        public Color OnSecondary;
        public Color SecondaryContainer;
        public Color OnSecondaryContainer;
        public Color Tertiary;
        public Color OnTertiary;
        public Color TertiaryContainer;
        public Color OnTertiaryContainer;
        public Color Error;
        public Color OnError;
        public Color ErrorContainer;
        public Color OnErrorContainer;
        public Color Background;
        public Color OnBackground;
        public Color Surface;
        public Color OnSurface;
        public Color SurfaceVariant;
        public Color OnSurfaceVariant;
        public Color Outline;
        public Color InverseSurface;
        public Color InverseOnSurface;
        public Color InversePrimary;
        public Color Shadow;
        public Color PrimaryInverse;
        public SerializeDictionary<ColorType, Color> dic = new SerializeDictionary<ColorType, Color>();

        private const string lightKey = "light";
        private const string darkKey = "dark";
        
        public void LoadXML(bool isDark = false)
        {
            TextAsset txtAsset = xmlFile;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(txtAsset.text);

            string defaultTheme = lightKey;
            if (isDark)
                defaultTheme = darkKey;

            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_primary']")                  ?.InnerText, out Primary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onPrimary']")                  ?.InnerText, out OnPrimary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_primaryContainer']")                  ?.InnerText, out PrimaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onPrimaryContainer']")                  ?.InnerText, out OnPrimaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_secondary']")                  ?.InnerText, out Secondary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onSecondary']")                  ?.InnerText, out OnSecondary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_secondaryContainer']")                  ?.InnerText, out SecondaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onSecondaryContainer']")                  ?.InnerText, out OnSecondaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_tertiary']")                  ?.InnerText, out Tertiary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onTertiary']")                  ?.InnerText, out OnTertiary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_tertiaryContainer']")                  ?.InnerText, out TertiaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onTertiaryContainer']")                  ?.InnerText, out OnTertiaryContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_error']")                  ?.InnerText, out Error);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onError']")                  ?.InnerText, out OnError);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_errorContainer']")                  ?.InnerText, out ErrorContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onErrorContainer']")                  ?.InnerText, out OnErrorContainer);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_background']")                  ?.InnerText, out Background);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onBackground']")                  ?.InnerText, out OnBackground);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_surface']")                  ?.InnerText, out Surface);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onSurface']")                  ?.InnerText, out OnSurface);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_surfaceVariant']")                  ?.InnerText, out SurfaceVariant);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_onSurfaceVariant']")                  ?.InnerText, out OnSurfaceVariant);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_outline']")                  ?.InnerText, out Outline);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_inverseOnSurface']")                  ?.InnerText, out InverseOnSurface);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_inverseSurface']")                  ?.InnerText, out InverseSurface);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_inversePrimary']")                  ?.InnerText, out InversePrimary);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_shadow']")                  ?.InnerText, out Shadow);
            ColorUtility.TryParseHtmlString(xmlDoc.SelectSingleNode($"resources/color[@name='md_theme_{defaultTheme}_primaryInverse']")                  ?.InnerText, out PrimaryInverse);

            dic.Clear();
            dic.Add(ColorType.Primary,                           Primary);
            dic.Add(ColorType.OnPrimary,                         OnPrimary);
            dic.Add(ColorType.PrimaryContainer,                  PrimaryContainer);
            dic.Add(ColorType.OnPrimaryContainer,                OnPrimaryContainer);
            dic.Add(ColorType.Secondary,                         Secondary);
            dic.Add(ColorType.OnSecondary,                       OnSecondary);
            dic.Add(ColorType.SecondaryContainer,                SecondaryContainer);
            dic.Add(ColorType.OnSecondaryContainer,              OnSecondaryContainer);
            dic.Add(ColorType.Tertiary,                          Tertiary);
            dic.Add(ColorType.OnTertiary,                        OnTertiary);
            dic.Add(ColorType.TertiaryContainer,                 TertiaryContainer);
            dic.Add(ColorType.OnTertiaryContainer,               OnTertiaryContainer);
            dic.Add(ColorType.Error,                             Error);
            dic.Add(ColorType.OnError,                           OnError);
            dic.Add(ColorType.ErrorContainer,                           ErrorContainer);
            dic.Add(ColorType.OnErrorContainer,                  OnErrorContainer);
            dic.Add(ColorType.Background,                        Background);
            dic.Add(ColorType.OnBackground,                      OnBackground);
            dic.Add(ColorType.Surface,                           Surface);
            dic.Add(ColorType.OnSurface,                         OnSurface);
            dic.Add(ColorType.SurfaceVariant,                    SurfaceVariant);
            dic.Add(ColorType.OnSurfaceVariant,                  OnSurfaceVariant);
            dic.Add(ColorType.Outline,                           Outline);
            dic.Add(ColorType.InverseOnSurface,                  InverseOnSurface);
            dic.Add(ColorType.InverseSurface,                    InverseSurface);
            dic.Add(ColorType.InversePrimary,                    InversePrimary);
            dic.Add(ColorType.Shadow,                    Shadow);
            dic.Add(ColorType.PrimaryInverse,                    PrimaryInverse);
        }
    }
}

    




