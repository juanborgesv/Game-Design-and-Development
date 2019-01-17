# 100 Unity Tips!

The following  tips were given by [Brackeys](https://www.youtube.com/user/Brackeys) on [this video](https://www.youtube.com/watch?v=thA3zv0IoUM). If you prefer reading instead of watching the tips, this might what you are looking for.

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

**20. Rename a variable and keep the value**: Use [FormerlySerializeAs("example")] to rename a variable name in the Inspector.

**21. Folder shortcuts**: Drag and drop a folder out of Unity into to the Unity's project tab.

**22. Focus**: Select a GameObject and press F to focus on it.

**23. Focus Follow**: Press F twice to follow the GameObject around.

**24. Align with view**: Match the game camera to the scene view by selecting the camera in the hierarchy and pressing Ctrl+Shift+F.

**25. CompareTag function**: Avoid using "==" when comparing two tags. It is more performant to use other.CompareTag("Player").

**26. Empty objects as dividers**: You can use empty GameObjects as dividers in your hierarchy to help you organize your objects.

**27. Find objects with Component**: If you want to find all objects with a particular component use the Search field in the hierarchy.

**28. Find assets of type**: In project's search field t:scene shows all scenes and t:textures shows only textures and so on.

**29. Easily move lines**: Use Alt+Arrow Up and Down to quickly move lines without copy and paste.

**30. Documentation shortcut**: Quickly navigate to the documentation for a component by hitting the book in the upper right corner.

**31. Documentation History**: Check [this](https://docs.unity3d.com/Manual/ManualVersions.html) if you want to see all the documentation for previous Unity versions.

**32. Expand/Collapse All**: Hold down Alt while expanding an object to expand all child objects aswell, the same applies to collapsing.

**33. Changing Editor Layout**: You can customize unity as much as you want, move around windows as you please and then save your settings as a new layout.

**34. Change Editor Colors**: By going to Edit > Preferences > Colors you can adjust editor colors, including the background color of the Scene view.

**35. Tinting the editor in playmode**: You can also make the editor change its color when playing the game by adjusting the playmode tint.

**36. Toggle Scene Effects**: You can choose what effects to show in the scene view by going under the landscape drop-down at the top.

**37. Menu Item**: If you want to be able to quickly call a method, use the Menu Item attribute to assign a function to a new Menu Item at the top of the Unity Editor.

**38. Context Menu Item**: Use the Context Menu Item attribute to do the same thing but adding the method to the context menu instead.

**39. Hiding Layers**: Split up your object into layers to easily be able to toggle them on and off in the scene.

**40. Locking Layers**: You can also lock layers to avoid accidentally moving objects that you don't want to select.

**41. Layer sub menus**: When creating layers or tags you can use "/" to create submenus to make it easy to organize your project.

**42. Global C# Defines**: Use Project Settings > Player > Other Settings > Scripting Define Symbols to add global C# defined to your project. This can be used to ommit or include code when compiling 

**43. Color Picking**: You can use the Color Picker to get color outside of Uniy itself

**44. Copy/Paste Colors**: Copy-Paste works on colors.

**45. Maximising Windows**: Use Shift+Space to maximise a window.

**46. Serialize Structs and Classes**: Use [System.Serializable] attribute to be able to see and edit classes and structs in the inspector.

**47. Collision Matrix**: Change which layers collide with which by going to Project Settings > Physics 2D > Layer Collision Matrix.

**48. Collider Interaction Matrix**: [This](http://docs.unity3d.com/Manual/CollidersOverview.html) is how different colliders interact when all are in the same layer.

**49. Math in Inspector**: You can do math calculations inside of number fields in the inspector, no need to bring out the calculator.

**50. Locking the Inspector**: Unity allows you to lock the inspector, especially useful if you open a second inspector.

**51. Inpector Debug Mode**: The drop-down menu at the top of the inspector has a debug mode option, when enabled this will display all variables including private ones.

**52. Debug Log highlights an object**: When using Debug.Log you can add a GameObject as a second attribute, this will highlight a GameObject in the scene when clicking on the Log.

**53. Styling in Debug Logs**: You can use simple styling in debug logs to style up your console messages, e.g., Debug.Log("<color=red>I'M RED</color>" + "I'm not"); 

**54. Plotting debug values**: Sometimes when you have a variable that changes over time it would be great if you could see it on a graph, luckily we can use animation curves to achieve this fairly easy using [this](https://youtu.be/thA3zv0IoUM?t=366) code snippet.

**55. Add component shortcut**: You can quickly add a new script by pressing Add Component, typing the name of the script, and hitting enter twice.

**56. Importing save files**: Unity can read saved files from programs such as Photoshop or Blender and Maya, no need to export to another format first.

**57. Keep photoshop layers**: To keep individual Photoshop layers when importing to into Unity simply save as a PSP file instead, this does require you to install the PSD importer from the Package Manager.

**58. Gizmos**: Assign gizmos to objects using the inspector.

**59. Custom Gizmos**: You can choose your own custom gizmos by selecting "other".

**60. Show/Hide Gizmos**: Enable and disable gizmos categorically from the scene view.

**61. Show/Hide Gizmos in Game view**: You can do this for the game view aswell at the top.

**62. Stringbuilder**: Concatenating like this: Debug.Log("He" + "llo" + " Wor" + "ld!") creates a lot of strings and memory garbage, use [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=netframework-4.7.2) for concatenating multiple more effectively.

**63. ScriptableObjects**: Create your own editor objects using scriptable objects, this is great for organizing game data like items or achievements.

**64. Script changes while playing**: In the preferences window you can choose what happens when the script changes while playing, very useful since a lot of times weird stuff happens when you just continue playing.

**65. Custom Windows**: You can easily extend the unity editor (: EditorWindow) to add your own custom windows with tools and overviews.

**66. Custom Inspectors**: You can simply create a custom inspector, this way you can change how you display components in the editor to add buttons, display more information and so on.

**67. ToolsV**: You can use the QWERNT keys to quickly swap between tools.

**68. RectTransform in 3D**: You can use the RectTransform to scale 3D objects, it is perfect to scale from bounds instead of around the pivot.

**69. Snapping**: Holding Ctrl/Cmd while moving an object snaps to position to full world units.

**70. Snapping Options**: For more snapping options go to Edit > Snap Settings.

**71. Vertex Grab**: Hold V to grab and drag objects by their vertices, as well snap them to other vertices.

**72. Managed Assemblies**: Reduce C# compile time by creating your own managed assemblies, right click in the project, select assembly definition, and move it to the folder you want. Now all scripts inside that folder will be compiled to this assembly. 

**73. WaitForSeconds & yield**: yield return new WaitForSeconds(1f); will never stop if Time.timeScale is set to zero, to change this use WaitForSecondsRealtime instead.

**74. Cash variables**: You can store references to components that you are going to be using a lot in private variables to save on performance, this is called caching

**75. Never use Camera.main**: It literally does this: GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); behind the scenes.

**76. Performant non changing strings**: If you are using a lot of non-changing strings in your code, you can use "static readonly" string to avoid allocating a bit of memory each time.

**77. Range attribute**: [Range](https://unity3d.com/es/learn/tutorials/topics/tips/show-public-variables-sliders-rangemin-max) allows you to create a slider that goes between the min and max value.

**78. Space attribute**: [Space](https://docs.unity3d.com/ScriptReference/SpaceAttribute.html) adds an empty space.

**79. Header attribute**: [Header](https://docs.unity3d.com/ScriptReference/HeaderAttribute.html) creates a tiny bit of text above some fields in the inspector.

**80. Tooltip attribute**: [Tooltip](https://docs.unity3d.com/ScriptReference/TooltipAttribute.html) changes the tooltip when hovering over a variable.

**81. Asset Store in Editor**: You can visit the asset store by using a web browser or within the editor.

**82. Merge scenesV**: You can drag and drop one scene onto another to merge them.

**83. Duplicate**: Easily duplicate an object Ctrl/Cmd + D.

**84. Duplicate array items**: You can also use the same command to array items.

**85. Editor presets**: You can use presets to save configurations for your components. Use the slider in the corner to choose between presets or create a new one.

**86. Iterate over child objects**: To loop over all direct children of an object use [this](https://youtu.be/thA3zv0IoUM?t=550) code snippet.

**87. Change object order in hierarchy**: Use transform.SetSiblingIndex(mIndex); to change the order of objects in the hierarchy by script.

**88. Save selections**: Save your current selection by going Edit > Selection, and choosing a number. You can then load back the selection from the same menu.

**89. Regions**: Use regions to create collapsable sections in your code, for things like Singleton, Variables, Functions. Watch out this is a slippery slope that leads to very long scripts.

**90. Pause Editor through code**: You can pause the editor at a specific moment during runtime by setting: EditorApplication.isPaused = true;

**91. Frame Skip**: The Frame Skip button, next to pause can be used to proceed one frame at a time.

**92. Stats window**: Use the Game Stats Window to for a quick overview over your game statistics.

**93. Profiler**: For more in-depth look at performance use the [Profiler](https://docs.unity3d.com/Manual/Profiler.html) window.

**94. Measure function in Profiler**: You can use [this](https://youtu.be/thA3zv0IoUM?t=590) code snippet to measure the execution of a function in the Profiler.

**95. Undocking the preview**: Get a closer look of what you are inspecting by right clicking the upper part of the preview to undock it, and it will then act as any other window.

**96. Mute your game**: If you need a quick break of your game's audio, simply hit the mute button in the game view.

**97. Invoke repeating**: Monobehavior that invoked repeating does not stop repeating on deactivated game objects.

**98. Frame Debugger**: Go to Window > Frame debugger to see a breakdown of how each frame is rendered.

**99. Physics Debugger**: You can visualize physics shapes using the Physics Debugger. It is great for spotting errors in colliders.

**100. Don't make an MMORPG**: "Seriously, don't."
