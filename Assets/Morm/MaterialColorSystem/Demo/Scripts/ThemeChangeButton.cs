using UnityEngine;
using UnityEngine.UI;
using Morm.ColorSystem;

[RequireComponent(typeof(Button))]
public class ThemeChangeButton : MonoBehaviour
{
    public ColorSystem.Theme theme;
    private Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => ColorSystem.Instance.ChangeTheme(theme));
    }
}
