## 100 Unity Tips

This tips where given by [Brackeys](https://www.youtube.com/user/Brackeys) on [this video](https://www.youtube.com/watch?v=thA3zv0IoUM&t=97s).

**1. Selection Outline**: Gizmos > Selection Outline

**2. Pixel Perfect Camera**: First, make sure to install 2D Pixel Perfect on Package Manager and use it to get super crisp pixel art.

**3. Sprite Y-based Sorting**: You can sort sprites based on its Y value going on Project Settings > Graphics > Transparency Sort Mode > Custom Axis (Y value to 1).

**4. Destroy delay**: You can add a second parameter to the Destroy method that sets a time delay in seconds. e.g Destroy(gameObject, 2f);

**5. Create material from shader**: Right click on a shader > Create > Material: It will create a material based on that shader.

**6. Execute code without empty object**: [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)] will execute code on your script without having to create an empty object.

**7. Save changes in play-mode**: Inspector: (Component) > Right click, Copy component (Play-mode) > Paste Component Values (Not Play-mode).

**8. Random boolean**: bool trueOrFalse = (Random.value > 0.5);

**9. Struct instead of Class**: Consider using struct when storing a few variables. Eliminates garbage collection compared to using a class.

**10. Auto-statements**: Double press tab to auto complete statements such as if and for.
