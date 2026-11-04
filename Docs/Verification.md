# Verification: Pearlbound

Unity 6000.6.1f1, 2026-11-04. Final Play Mode run: 376 assertions passed, no failed assertions. Five resulting screenshots were visually reviewed. The GDD has two pages and was rendered and visually reviewed.

Verified flows:
- MainMenu Play loads Game; Pause stops scaled time and the dive timer; Resume continues the run.
- Pointer callbacks move left/right, Kick performs the original grounded jump, and holding Bubble emits repeated projectiles with cooldown.
- Restart resets health and time; Menu returns to MainMenu with timeScale 1. Quit's persistent callback is wired to Application.Quit; tests do not close the Editor.
- All active buttons are >=120x120 reference pixels. TMP text is >=36 pixels. Button AND text bounds remain inside Screen.safeArea for the tested screen.
- Damage removes HP; immediate repeated damage is blocked by invulnerability; healing restores HP.
- Physical overlap with a pearl increments score and updates the HUD.
- Reaching the dive timer goal activates Open on the rescue arch Animator and updates the HUD to RESCUE READY.
- The new title/product name and licensed diver/pearl sprite references are present.

Native Device Simulator, landscape:
- Apple iPhone 8 Plus: 1920x1080, full safe area.
- Apple iPhone 12: 2532x1170, safe area x141 y63 width2250 height1107.
- Apple iPad (5th gen): 2048x1536, full safe area.

Temporary scene-authoring and automated verification scripts are excluded from the delivered Assets. The gameplay scripts remain the earlier instructor-based scripts; HUD labels changed for the new concept. New visual work consists of sprite imports, animation frames, prefab appearance, scene art and UI styling, with a collider fitted to the diver.

Limits: Editor Play Mode and simulated screen layouts were checked. No Android APK or physical-device run is included. The English MP4 with the student's own voice and the Canvas upload are still required; see Kickoff-Checklist.md and English-Video-Guide.txt.

Screenshot refresh: all five native Device Simulator captures were retaken after simplifying the menu to Play and Quit. Each resulting PNG was visually reviewed. The game title and extra menu captions are hidden by request; the original Kickoff title requirement is flagged in Kickoff-Checklist.md.
