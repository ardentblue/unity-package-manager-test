using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class HelloPluginBinding : MonoBehaviour
{
    //Lets make our calls from the Plugin
    [DllImport("HelloPlugin", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr PrintHello();

    [DllImport("HelloPlugin", CallingConvention = CallingConvention.Cdecl)]
    private static extern int PrintANumber();

    [DllImport("HelloPlugin", CallingConvention = CallingConvention.Cdecl)]
    private static extern float AddTwoFloats(float f1, float f2);


    void Start()
    {
        Debug.Log(Marshal.PtrToStringAnsi(PrintHello()));
        Debug.Log(PrintANumber());
        Debug.Log(AddTwoFloats(2.5F, 4F));
    }
}
