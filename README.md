# Preview
Use Google Material Color System in Unity

![enter image description here](https://user-images.githubusercontent.com/49914295/153880498-98ad0165-2668-4565-9af4-f3be8ab9c5c7.gif)
![enter image description here](https://user-images.githubusercontent.com/49914295/153880515-04f6e904-bd79-411d-a2ed-54854a298b55.gif)

# sample code
    using UnityEngine;  
    using UnityEngine.UI;  
    using Morm.MaterialDesign;
	
	private Image img;

    private void Start()  
    {  
	    //Action that is called when Theme changes
		ColorSystem.Instance.OnThemeChanged += OnThemeChagned;  

		//get color
		img.color = ColorSystem.Instance.GetColor(ColorType.Primary);

		//change theme
		ColorSystem.Instance.ChangeTheme(ColorSystem.Theme.Dark)
    }
    



# Getting Started
 
 1. Install the [Material Theme Builder](https://www.figma.com/community/plugin/1034969338659738588/Material-Theme-Builder).
 2. Please sign in at https://www.figma.com/ and create a New design file.
 3. Open the Material Theme Builder Plugin.![enter image description here](https://user-images.githubusercontent.com/49914295/153881700-a00deab2-ac4c-47a5-876b-44add44e0eff.png)
4. Select an image to extract the color preset, or select the color you want. And export the file. ![enter image description here](https://user-images.githubusercontent.com/49914295/153883296-ac26e15a-2664-4290-96c5-7fa1345cb55c.gif)
5. Unzip the file. Keep the colors.xml file in the value folder.
6. Create Color Preset in Unity.![enter image description here](https://user-images.githubusercontent.com/49914295/153884795-ce1c9218-f6f4-4c12-9d7d-a28ccce05c91.png)
7. Put colors.xml in Inspector's Xml File. And click [Load Color Xml_Light] or [Load Color Xml_Dark] to extract the color.
8. Two Scriptable Objects must be created for two themes (Light, Dark).
9. Preparations are complete. Check the Resources Path within ColorSystem.cs.
10. If the path is correct...
11. Use the **Morm.MaterialDesign.ColorSystem.Instance.GetColor(ColorType type)** function.
12. There's not much code. Look at it, modify it, and use it as you want. Please refer to the demo.


