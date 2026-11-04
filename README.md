# Gatefall

A 2D survival game for Android, landscape, Unity 6000.6.1f1.

Open this folder through Unity Hub, then open Assets/Scenes/MainMenu.unity and press Play. Build Settings contains MainMenu followed by Game. Android Build Support is needed to export an APK.

Survive for 60 seconds, dodge rocks and bombs, and collect hearts and coins. Mobile buttons: Left, Right, Jump and Fire. Desktop: A/D or arrows, Space and X. Pause offers Resume, Restart and Menu. Quit exits a built player; in the Editor it only logs the request.

The Canvas uses Scale With Screen Size, 1920x1080, Match Height (1). Controls and text live inside the SafeArea panel. The UI uses InputSystemUIInputModule; gameplay keeps the earlier keyboard examples with a small mobile input bridge. Active Input Handling is Both.

The instructor's animation kit supplies hero, coin and fire sprites. Audio comes from Kenney Digital Audio (CC0); its license is under Assets/Audio/Kenney. Flat arena geometry is retained from the earlier survival prototype.

See Docs/Gatefall_GDD.pdf for the two-page design and weeks 9-13 plan. Docs/Screenshots contains Menu, Pause and three native Device Simulator HUD captures. Docs/Verification.md describes checks and limits.
