using System;
public class ColorRGB
{
    public byte r { get; }
    public byte g { get; }
    public byte b { get; }
    public ColorRGB(byte red, byte green, byte blue)
    {
        r = red;
        g = green;
        b = blue;
    }

    public string getCode()
    {
        byte[] arr = {r, g, b};
        return $"#{Convert.ToHexString(arr)}";
    }
}