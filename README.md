# Pearlbound

A solo 2D seabed survival platformer for Android, landscape, made in Unity 6000.6.1f1. Guide a diver through sunken ruins, collect pearls, avoid sinking mines and survive until the rescue beacon activates after 60 seconds.

Open this folder in Unity Hub, open Assets/Scenes/MainMenu.unity, then press Play. MainMenu and Game are the enabled scenes in Build Settings. Android Build Support is needed for an APK export.

Controls: hold LEFT / RIGHT to move. KICK gives one upward impulse when on the seabed or a ledge. Hold BUBBLE to emit visual projectiles with the original 0.3-second cooldown. Keyboard fallback: A/D or arrows, Space, X. Pause offers RESUME, RESTART and MENU. QUIT closes a built player; in the Editor it only logs the request.

Canvas: Scale With Screen Size, 1920x1080, Match Height (1). Text and controls live in SafeArea panels. InputSystemUIInputModule handles the UI; gameplay keeps the instructor's keyboard examples with the existing small mobile input bridge. Active Input Handling: Both. Visible Meta Files and Force Text are enabled.

Original visual assets and licenses: [Docs/Assets.md](Docs/Assets.md). Game design and the ten required sections: [Docs/Pearlbound_GDD.pdf](Docs/Pearlbound_GDD.pdf). Weekly delivery plan: [Docs/Plan.md](Docs/Plan.md). Requirement evidence and remaining submission steps: [Docs/Kickoff-Checklist.md](Docs/Kickoff-Checklist.md).

The repository retains the earlier prototype's history. The underwater concept is developed on feature/pearlbound-underwater and merged through a pull request. Generated Library, Temp, Logs and build output are excluded by GitHub's Unity .gitignore.
