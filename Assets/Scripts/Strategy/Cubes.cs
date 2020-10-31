using UnityEngine;

public class Cubes
{
    private IColorChanging colorChanging;

    public Color32 ColorChange(Color32 newColor)
    {
        return colorChanging.ChangeColor(newColor);
    }

    public void setColorChanging(IColorChanging colorChanging)
    {
        this.colorChanging = colorChanging;
    }
}
