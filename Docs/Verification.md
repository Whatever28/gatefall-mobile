# Verification

Unity 6000.6.1f1 Play Mode verification passed on 2026-11-04.

- Play loads Game; Resume continues time; Restart resets health and timer; Menu restores MainMenu and timeScale 1.
- Pause stops scaled time and the survival timer.
- Pointer callbacks move left/right, jump and repeatedly fire with the original cooldown.
- Button reference dimensions are at least 120x120; text is at least 36 reference pixels.
- UI bounds stay inside Screen.safeArea on Apple iPhone 8 Plus (1920x1080), Apple iPhone 12 (2532x1170, notched safe area), and Apple iPad 5th generation (2048x1536).
- Five screenshots were captured through Unity's native Device Simulator and visually checked.
- Quit has a persistent callback; Application.Quit was not invoked during automated Editor tests.

This verifies Editor Play Mode and simulated layouts. An Android APK and physical-device testing are not included. The submission video must still be recorded with the student's own English voice (2-3 minutes).
