using UnityEngine;
using UnityEngine.UI;
using Morm.MaterialDesign;

[ExecuteAlways]
public class SetColor : MonoBehaviour
{
    public ColorType targetColorType;

    private Image img;
    private Text txt;
    private Button btn;

    private void Start()
    {
        ColorSystem.Instance.OnThemeChanged -= TryGetComponentAndSetColor;
        ColorSystem.Instance.OnThemeChanged += TryGetComponentAndSetColor;
        TryGetComponentAndSetColor();
    }

    private void Update()
    {
#if UNITY_EDITOR   
        TryGetComponentAndSetColor();
#endif
    }

    public void TryGetComponentAndSetColor()
    {
        if (img == null)
            img = GetComponent<Image>();

        if (txt == null)
            txt = GetComponent<Text>();
        
        if (btn == null)
            btn = GetComponent<Button>();

        if (img != null)
            img.color = ColorSystem.Instance.GetColor(targetColorType, img.color.a);
        
        if (txt != null)
            txt.color = ColorSystem.Instance.GetColor(targetColorType, txt.color.a);
        //
        // ColorBlock colorBlock = ColorBlock.defaultColorBlock;
        // // colorBlock.normalColor = colorPreset.dic[targetColors];
        // // colorBlock.highlightedColor = colorPreset.dic[targetColors];
        // // colorBlock.pressedColor = colorPreset.dic[targetColors];
        // // colorBlock.selectedColor = colorPreset.dic[targetColors];
        // // colorBlock.disabledColor = Color.gray;
        //
        // if (btn != null)
        //     btn.colors = colorBlock;
    }
}
