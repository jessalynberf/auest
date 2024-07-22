using System;
using UnityEngine;

public class ColorConverter : MonoBehaviour
{
    public static Color HexToRgb(string hex)
    {
        hex = hex.Replace("#", "");

        byte r = Convert.ToByte(hex.Substring(0, 2), 16);
        byte g = Convert.ToByte(hex.Substring(2, 2), 16);
        byte b = Convert.ToByte(hex.Substring(4, 2), 16);

        return new Color32(r, g, b, 255);
    }

    void Start()
    {
        string[] colors = { "#FF0000", "#00FF00", "#0000FF" }; // An array of hex colors
        for (int i = 0; i < colors.Length; i++)
        {
            Color rgbColor = HexToRgb(colors[i]);
            Debug.Log($"Color {i}: {rgbColor}"); // Output in the Unity console
        }
    }
}
