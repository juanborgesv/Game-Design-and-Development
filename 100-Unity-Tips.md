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

**11. Coroutine(ception**: Calling a coroutine inside another coroutine.

**12. Animate script paramaters**: Animation window is capable to animate pretty much everything, this includes parameters in your own custom scripts.

**13. Focus in the animation window**: Ctrl+A to select everything in the animation window and then F to frame it all.

**14. Toggle between Curves and Keyframes**: You can use C to toggle between both views in the animation window.

**15. Reverse Animation**: In Animator : Inspector you can reverse an animation by setting its speed to -1.

**16. Comparing distances quicker**: Use sqrMagnitude instead of Vector3.Distance(...), this saves a Sqr call which is really slow. E.g: If (Vector3.Distance(pointA, pointB) < dist) vs if ((pointA - pointB).sqrMagnitude < dist * dist).

**17. TextMesh Pro**: Use TextMesh Pro instead default Text objects to get way more control and crisper text at all sizes.

**18. SerializeField**: Use [SerializeField] to show private variables in Inspector.

**19. HideInspector**: Use [HideInspector] to hide public variables in Inspector.

**20. FormerlySerializeAs**: Use [FormerlySerializeAs("example")] to rename a variable name in the Inspector.


