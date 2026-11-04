using UnityEngine;

// Small bridge between UI pointer events and the existing keyboard controller.
public class MobileControls : MonoBehaviour
{
    public static bool LeftHeld, RightHeld, FireHeld, JumpPressed;
    public static float Horizontal => (RightHeld ? 1f : 0f) - (LeftHeld ? 1f : 0f);
    public static void ResetInput(){ LeftHeld=RightHeld=FireHeld=JumpPressed=false; }
    void Awake(){ ResetInput(); }
    public void LeftDown(){ LeftHeld=true; }
    public void LeftUp(){ LeftHeld=false; }
    public void RightDown(){ RightHeld=true; }
    public void RightUp(){ RightHeld=false; }
    public void FireDown(){ FireHeld=true; }
    public void FireUp(){ FireHeld=false; }
    public void Jump(){ JumpPressed=true; }
}
