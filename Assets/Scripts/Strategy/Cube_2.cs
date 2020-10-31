using UnityEngine;

public class Cube_2 : MonoBehaviour
{
    private Cubes cube_2 = new Cubes();

    private void Start()
    {
        cube_2.setColorChanging(new DarkColor());
        GetComponent<MeshRenderer>().material.color = cube_2.ColorChange(new Color32(0, 0, 0, 255));
    }
}
