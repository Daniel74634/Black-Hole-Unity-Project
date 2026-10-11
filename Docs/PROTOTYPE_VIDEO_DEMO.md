# Prototype demonstration video

Recorded 6 October 2026 with Unity 6.3 LTS (6000.3.25f1).

The deliverable is a 36-second, 30 fps, H.264/yuv420p MP4. The actual 1600 × 900 Unity frames are preserved, with a 100-pixel editorial caption strip below them. It is a silent, captioned tour; no artificial gravitational-wave audio is presented as a measured chirp.

## What the tour shows

- 0–5.2 s: visitor movement, changing angle, approaching and withdrawing from the illustrated binary.
- 5.2–10.4 s: raising the emulated wrist; pause, seek halfway, replay; adjustable look and scroll sensitivity.
- 10.4–17.5 s: approaching the world-space Story board; closer/wider presets, bounded custom separation, seek and rate controls, formative prediction and feedback.
- 17.5–22 s: Graph and Model layers, including dimming.
- 22–27 s: fixed-star alignment, direct-image versus approximate bending, ray guides and changing apparent images with observer movement.
- 27–30.5 s: illustrative chirp, explicitly scripted offline guide, unavailable future time-dilation clocks.
- 30.5–36 s: returning to the exhibit and its explicitly conceptual remnant.

## Recording boundary

`Assets/DTET/PrototypeVideoCapture.cs` is compiled only for the Editor/development player and is installed only when `DTET_VIDEO_PATH` is set. It drives a smooth visitor pose and invokes existing UI commands; brief outlines indicate selected buttons. These are scripted demonstrations, not a recording of a human usability test or tracked headset session. It temporarily hides the entrance plaque for framing. No product UI or physics is replaced, and input preferences are not persisted.

The capture pipes completed RGB screen frames directly to ffmpeg, avoiding a large image sequence. The source master is bottom-up because of Unity ReadPixels; the presentation encoder applies `vflip`, adds the caption strip, and embeds captions. The final MP4 must be used for presentation, not the raw master.

## Reproduce

From the repository root in PowerShell, with ffmpeg/ffprobe on PATH and the Unity project closed:

```powershell
.\Scripts\Record-PrototypeDemo.ps1 `
  -OutputDirectory '.\outputs\prototype-video' `
  -CaptionPath '.\Scripts\PrototypeDemo.ass' `
  -Rebuild
```

The script creates the QA player if requested, records it in a visible window, closes that recording session on completion, encodes the presentation, and creates a machine-readable ffprobe receipt. It does not kill existing processes. Use a new output directory to retain previous editions; the recording filenames are overwritten on a repeat run.

## Verification and limits

The Unity QA build succeeded; the capture completed 1080 frames. The presentation is checked with ffprobe, decoded in full, and sampled visually across the feature chapters. The six portable test groups pass, including the separate model and optics fixtures. That does not bind the staging model to Unity or validate a physical binary spacetime.

No headset recording, per-eye optics, measured VR GPU performance, physical orbital integration, redshift, live clock rates, AI tutor, simulated merger/ringdown, or human comprehension/usability validation is claimed. The video deliberately labels those boundaries.
