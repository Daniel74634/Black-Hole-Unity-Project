# Black-Hole-Unity-Project

VR-style DT-ET learning exhibit for university students aged 18–30, across different prior knowledge and interest levels. Desktop inputs emulate head/visitor and hand poses in the same world-space experience; there is **no separate desktop control layout**. The current Unity scene combines an **artistic orbital storyboard** with **approximate thin-lens stellar bending**, not a full relativistic simulation. A separate deterministic inspiral model and tests are preserved under `Staging/` for a later integration milestone.

## Open the visual prototype

Clone or download this repository, then open `BinaryBlackHole` in Unity Hub. The editable Unity source consists of `Assets`, `Packages` (including the lock file), and `ProjectSettings`; Unity recreates its ignored cache on first import. Generated Windows players and recordings are not stored in Git.

1. Install Unity Hub and Unity Editor **6000.3.25f1 (Unity 6.3 LTS)**, then sign in and activate a valid Unity license.
2. In Unity Hub, add the project folder `BinaryBlackHole` (not the repository root). Let Package Manager import the Universal Render Pipeline dependencies.
3. Open `Assets/DTET/Scenes/BinaryBlackHole_VisualStaging.unity` and press Play. The scene is also the sole enabled Build Settings scene. It now starts **paused**; Space or the wrist Play button begins the storyboard.
4. The scene opens in a first-person virtual visitor view. Right-drag to look, use WASD to move, Q/E to change height, Shift for faster movement, and the mouse wheel to move closer/farther. **V raises/lowers your virtual left wrist**. Left-click its world-space controls for play/pause, replay, speed, Start / Halfway / End, information, learning, dimming, or exit. Looking away leaves the wrist in its body-relative pose rather than pinning its menu to the screen. The glove, sleeve, cuff, and controls share a wrist transform.
5. **T** takes the visitor to the information panels; **H** opens and approaches the world-space learning board. Story / Graph / Model, scenario A / B, initial separation, playback rate, and the quick check remain there. A slider change is pending until **Apply Start**; applying resets and pauses the storyboard. H hides the board; F or Home returns to the exhibit. At the endpoint the markers give way to a **conceptual** remnant. Navigation and wrist inspection work while playback is paused and do not change the storyboard.

Keyboard shortcuts: V raises/lowers the wrist, **O opens/closes wrist input options**, Space toggles pause/play, Esc pauses immediately, R resets, B dims the view, T approaches information, H approaches learning, F/Home returns to the event, and C toggles optional orbit inspection. **Default wheel movement is now 3× faster**; options provide independent mouse-look and scroll sensitivity sliders, local saved preferences and a reset-defaults button. See [input options](Docs/INPUT_OPTIONS.md). 1/2/3 select Story/Graph/Model on the learning board. Exit is on the wrist and learning board; in the Editor, use the Play toolbar to stop. An entrance plaque explains the emulation controls. The quick check is formative content, not a measured learning outcome.

The partner-inspired **lesson HUD** consists of spatial readout/chirp/tutor panels and a world-space control canvas physically attached to the virtual wrist. **U** hides/restores the whole partner interface; V only lowers/raises the wrist. Its controls use the same storyboard state as the learning sliders. Physical readings say **Not connected** until model integration; visual separation is a percentage of its starting separation, and remaining time is playback time. See [partner HUD integration](Docs/PARTNER_HUD_INTEGRATION.md) for recovered features and scope.

The scene uses the Input System for its UI and a runtime bootstrap to create procedural, editable-in-code visuals: paired dark silhouettes, layered animated annulus meshes with a shallow thickness visible from below/edge-on, soft inner and outer rims, fading motion trails, orbital reference rings/ticks, **1,400 fixed stellar source objects with batched point images**, a chirp illustration with story-position cursor, and optional learning panels. Custom URP shaders are in `Assets/Resources/DTET/`; the geometry and material parameters are in `Assets/DTET/VisualAssetFactory.cs` and `StellarSourceField.cs`. There is no imported third-party art. The luminous disks are an artistic visual aid, **not** predicted gas emission, ray tracing, or a binary-spacetime model. The graph is explicitly not live data, the controls are visual choreography rather than physical time, and the tutor badge points to an offline staging adapter rather than a functional AI tutor.

Stars no longer follow the camera: movement changes their viewing directions through finite-distance geometric parallax. **Live approximate lensing** shifts, splits and stretches background stellar images as the viewer moves. **J** pauses and aligns a fixed demonstration star behind a marker, **L** toggles bending for comparison, and **G** toggles thin-lens broken-ray guides. These commands are also on the wrist. Distances, lens strength, sizes and colours are authored exhibit values, not calibrated astronomical data. See [approximate lensing and its limits](Docs/APPROXIMATE_LENSING.md). The disks and orbit remain artwork; redshift is deliberately deferred.

Future **dataset-backed strong-field binary optics** still needs suitable evolving metric data and a validated ray tracer; the thin-lens approximation does not supply it. `ObserverPhysicsBridge` provides a shared optics/clock provider boundary on the visitor, with an explicitly unavailable staging adapter. `AdmObserverPhysics.cs` supplies tested local metric-based proper-time/photon-energy mathematics, not a binary spacetime solver. A spatial clock comparison card is ready for future visitor and ideal far-away reference proper-time readings; it currently says **Not connected**. **K approaches that card; F returns to the exhibit.** Reset/seek/scenario changes and teleports invalidate incompatible history. See [optics and clocks](Docs/OPTICS_AND_CLOCKS.md) and the [dataset request](Docs/NUMERICAL_SPACETIME_DATA_REQUEST.md) for the future relativistic contract and data-access requirements.

All canvases are world-space. Desktop input is a pose emulator, not an alternative exhibit UI. `VirtualWristRig.BindTrackedWrist` is a transform-pose attachment boundary for later hardware integration; `ExhibitCameraRig.EmulatedInputEnabled` can disable keyboard/mouse head input. No headset SDK, controller/hand tracking, stereo build, teleport safety, or device comfort is claimed yet. Those require the selected headset/deployment target and real device tests. The mouse wheel moves the visitor, not the bodies or their separation.

## Source layout

- `BinaryBlackHole/`: Unity 6.3 LTS Universal 3D project, derived from Unity's included `com.unity.template.3d-cross-platform-17.0.14` template.
- `BinaryBlackHole/Assets/DTET/VisualPrototypeBootstrap.cs`: interactive visual composition and storyboard controls.
- `BinaryBlackHole/Assets/DTET/ExhibitCameraRig.cs`: independent orbit/fly navigation, tracking, zoom limits, and recoverable viewpoints.
- `BinaryBlackHole/Assets/DTET/VirtualWristRig.cs`: emulated raise/lower pose, visible glove/forearm/cuff, and tracked-wrist transform boundary.
- `BinaryBlackHole/Assets/DTET/VisualAssetFactory.cs`: reproducible geometry/material construction; no external texture dependency.
- `BinaryBlackHole/Assets/DTET/StellarSourceField.cs` and `StellarSource.cs`: fixed synthetic emitter objects and their shared approximate thin-lens image mesh, cached only when sources, lenses, observer and options are unchanged.
- `BinaryBlackHole/Assets/DTET/ObserverPhysicsBridge.cs` and `RelativityClockSnapshot.cs`: observer-attached provider boundary and proper-time comparison contract; no GR solver installed.
- `BinaryBlackHole/Assets/Resources/DTET/`: five URP shaders for illustrated disks, dark silhouettes, star points, glow lines, and shaded glove surfaces. Kept in Resources so a player build can retain them without a serialized material reference.
- `Staging/Simulation/`: pure C# circular-inspiral, session, graph, and tutor-provider boundary, not yet bound into Unity.
- `Staging/Simulation.Tests/`: reproducible source tests; see `Staging/README.md`.

The partner's `InspiralDemo_Build.zip` was a Unity **6000.5.10f1 compiled Windows player**, with no editable `Assets`, `Packages`, `ProjectSettings`, or source scene. Its saved HUD layout and script metadata informed a source reconstruction in this 6.3 project; its binary assemblies were not imported. Please provide the editable partner project if direct asset/scene integration is desired.

## Build a standalone Windows demo

With Unity Editor **6000.3.25f1**, choose **DT-ET > Build Submission Demo**. This creates a non-development player at `BinaryBlackHole/Builds/Submission/DTET_Prototype.exe`, with its required runtime/data folders alongside it. Keep those folders together; the executable does not require Unity Editor on the recipient's Windows computer. The development-only screenshot/video harnesses are excluded from this build.

For a clean submission ZIP with a prominent launcher, see [submission packaging](Docs/SUBMISSION_DEMO_PACKAGE.md) and `Scripts/Package-SubmissionDemo.ps1`. Templates are in `Packaging/Demo/`. The [video capture guide](Docs/PROTOTYPE_VIDEO_DEMO.md) describes the 36-second captioned prototype tour and how to reproduce it; its caption source is `Scripts/PrototypeDemo.ass`. Generated MP4s remain outside this source repository.

For the separate, currently unbound model tests:

```powershell
dotnet run --project Staging/Simulation.Tests/BlackHole.Staging.Simulation.Tests.csproj -c Release
```

## Evidence and limitations

Unity 6.3.25f1 import is now licensed and the visual C# compiles. The template's Input System 1.12.0 failed with `BuildTarget.ReservedCFE`, so the project uses Input System 1.17.0; the Editor resolves built-in URP 17.3.0. Unused Visual Scripting, Plastic collaboration, navigation and Timeline template packages were removed after first-import errors. The source model tests pass but remain unbound to the scene. The QA build menu is `DT-ET > Validate Assets and Build QA Player`; it checks all five custom shaders and builds a Windows development player. Set `DTET_CAPTURE_PATH` and optionally `DTET_CAPTURE_VARIANT` (`Observe`, `Above`, `Side`, `Close`, `Story`, `Graph`, `Model`, `Endpoint`, or `ScenarioB`) before running that development player to execute automated UI/camera checks and write a screenshot. This harness is omitted from release builds. A headset/build target is only needed when deploying real device support, not for this pose-emulated exhibit.

`Hud` and `HudEnd` capture variants additionally show the partner HUD during the storyboard and at its conceptual endpoint; HUD command checks run in every capture variant.

## Track A audit 5 October 2026

The visual prototype has deterministic accelerating choreography shared by playback and seek, paused scenario selection, accurate custom labels and fresh formative feedback after resets. Shader disk flow pauses/seeks with the storyboard. Soft procedural disk detail, 16-band annuli and 4x PC MSAA improve presentation without imported textures. Unchanged optical views reuse the image mesh; moving observers/lenses/sources and toggles trigger live recalculation. CPU diagnostics distinguish active optics from stationary cached views.

The [full requirements audit](Docs/TRACK_A_REQUIREMENTS_AUDIT.md) and [three-week implementation plan](Docs/THREE_WEEK_IMPLEMENTATION_PLAN.md) cover the original Track A and Project 05 requirements. The [report source](Docs/PROTOTYPE_AUDIT_REPORT.md) is rendered with `Scripts/build_audit_report.py` using verified capture receipts; the delivered PDF and expanded editable Markdown are outside Unity Assets. `Scripts/Capture-PrototypeAudit.ps1 -OutputDirectory <chosen-folder>` captures 12 views with nine pass groups each. QA variants include Wrist, Options, Lensing, LensingOff and LensingRays. The [ChatGPT review handoff](Docs/CHATGPT_REPORT_HANDOFF.md) is ready, but a separate review still needs the destination chat.

**Not a completed Track A MVP:** model-to-scene/chirp binding, actual headset deployment, tracked grab/scale/reveal of abstract data, functional AI, human evaluation and the final report/video/PI9 portfolio remain required. Realistic accretion/NR optics are optional, not substitutes. See the audit for source page references and unavailable rubric/research evidence. Build success does not imply a clean Editor Console or headset comfort/performance.
