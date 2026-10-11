# Windows demo submission package

The submission is a standalone, non-development Windows x64 Unity player, not a Unity source-project ZIP. A recipient does not need Unity Editor or the .NET SDK installed. Unity's generated player, game data and managed runtime are bundled together.

## Layout

```text
DTET_Prototype_Demo/
  START_DEMO.cmd
  READ_ME_FIRST.txt
  Demo/                       # Shipping release-build components
    DTET_Prototype.exe
    DTET_Prototype_Data/
    UnityPlayer.dll
    MonoBleedingEdge/
    D3D12/
    UnityCrashHandler64.exe
  Guide/Controls_and_Limits.txt
  Video/DTET_Prototype_Demo.mp4
```

Extract the entire ZIP, then double-click START_DEMO.cmd. The launcher resolves its runtime relative to itself, not the caller's working directory. The executable can also be run directly inside Demo. The guide includes a two-minute walkthrough, controls and honest scientific/hardware limits.

No Library, source checkout, package cache, old build, backup, symbol/debug directory, audit log, screenshot, raw video or unused staging-model/test dependency is shipped. Standard release-engine dependencies, including graphics libraries and the crash handler, are retained for reliable startup; engine dependency DLLs are not guessed away merely because their names appear unused.

## Reproduce

With the project closed, build in Unity using DT-ET > Build Submission Demo, or invoke:

```powershell
& 'C:\Program Files\Unity\Hub\Editor\6000.3.25f1\Editor\Unity.exe' `
  -projectPath '<absolute repository path>\BinaryBlackHole' `
  -executeMethod DTET.VisualPrototype.Editor.PrototypeBuild.BuildSubmissionPlayer `
  -batchmode -nographics -quit -logFile '<absolute build-log path>'

.\Scripts\Package-SubmissionDemo.ps1 `
  -OutputDirectory '<new absolute output directory>' `
  -VideoPath '<absolute path to DTET_Prototype_Demo.mp4>'
```

Packaging uses a whitelist of shipping build roots and excludes DoNotShip directories, PDB/MDB symbols, backups and logs. It refuses an existing package/ZIP target. The manifest is stored beside, not inside, the submission ZIP. It checks archive entry count and unwanted paths. Independently extract and compare every SHA-256 against the manifest before delivery.

## Verification on 6 October 2026

- Unity 6000.3.25f1 release build returned 0 and DTET_SUBMISSION_BUILD_SUCCEEDED. No C# or custom shader compile error found. Existing URP import diagnostics remain disclosed in the project audit.
- ZIP: 42,385,322 bytes (40.42 MiB). Expanded package: 104,340,435 bytes (99.51 MiB), 169 files.
- All 169 freshly extracted files matched staged SHA-256 hashes; forbidden paths/symbols absent.
- Development-only VisualQaCapture, PrototypeVideoCapture and SetQualityCheckView names were absent from the packaged Assembly-CSharp.dll.
- START_DEMO.cmd was launched from an unrelated working directory. It started the exact executable in the freshly extracted package, which exposed the expected responsive window. The player loaded its packaged Mono assemblies and initialized Direct3D 12 on the RTX 3060 Ti. No runtime exception/missing-dependency error was logged.
- Windows screenshot capture failed twice: `FrameArrived timed out: timed out waiting on channel`, then `window capture timed out: timed out waiting on channel`. A fresh visual inspection and release-only interactive control playthrough are therefore unverified. Prior development-player UI/input tests and the genuine video capture are separate evidence, not a substitute for this check.
- The test session was closed with targeted Alt+F4, and normal player cleanup was logged.
- The package was not tested on a clean second computer, alternative GPU or headset, and is unsigned. No security-setting changes were made.

Archive SHA-256: `FF8BB93594E80EEAFFCF05280CE038882CC043AE64B3FA8D39A8C54F42FA01EE`.

Evidence stays outside the submitted folder under workspace outputs/submission_2026-10-06: unity-release-build.log, package-manifest.json, extracted-demo-player.log and a freshly extracted verification copy. The user's source and prior work are preserved.
