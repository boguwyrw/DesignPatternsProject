using UnityEngine;

public class Cube_1 : MonoBehaviour
{
    private Cubes cube_1 = new Cubes();

    private void Start()
    {
        cube_1.setColorChanging(new BrightColor());
        GetComponent<MeshRenderer>().material.color = cube_1.ColorChange(new Color32(255, 255, 0, 255));
    }
}
