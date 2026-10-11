# Graphics and footprint audit

5 October 2026. All measurements describe the Windows development prototype, not headset performance or physically realistic emission.

## Compact visual corrections

The shared shallow annulus now uses 192 sectors and 16 radial bands across two surfaces (6,562 vertices, 12,288 triangles per shared mesh). Explicit periodic normals remove a seam in the mesh data, and underside winding is corrected. The unlit disk shader does not currently use those normals for physical lighting. The old high-frequency angular stripe pattern was replaced with smooth periodic Cartesian noise and derivative-filtered secondary detail. Inner/outer edge opacity and line thickness were retuned; the glow-line shader feathers its width. PC URP uses 4x MSAA instead of 1x. Disk flow follows the story clock so pausing/seek behaves consistently.

Five custom shaders now have stereo instance macros. This is preparatory code, **not** verified XR support. In particular, StellarSourceField still constructs its apparent images from one observer camera position; stereo projection requires explicit validation/redesign or disabling that optional feature on hardware until correct.

There are no imported textures, asset-store packs, downloaded stellar backgrounds or third-party artwork. Assets remain editable procedural C#/shader source. Soft illustrative disks are not accretion physics, event-horizon ray tracing or realistic strong-field binary rendering. Visibility/readability and causal teaching take priority over extra ornament.

## Measured storage

| Folder | Before this audit | Final audit snapshot | Meaning |
| --- | --- | --- | --- |
| Unity Assets | 361,639 bytes, 83 files | 375,746 bytes, 85 files | Less than 0.4 MiB of source assets; increase 14,107 bytes, about 3.9% |
| Builds | 163,745,598 bytes | 163,756,829 bytes | Generated Windows development output, about 156.17 MiB |
| Library | 1,774,940,389 bytes | 1,775,003,464 bytes | Regenerable import/build cache, about 1.65 GiB; not imported artwork |

These are dated filesystem sums, not RAM/VRAM figures. No broad cache or build cleanup was performed. Report/screenshot output is deliberately outside Unity Assets and should not be included in headset runtime content. Higher MSAA and denser shared geometry have runtime costs even though source files remain tiny.

## Performance correction and receipts

Before caching, the paused overview's 90-frame optical CPU mean was 8.305 ms (p95 8.545 ms). The final unchanged overview measured mean 0.087 ms (p95 0.120 ms). These independent short samples are not a controlled benchmark, but identify and verify removal of repeated root-solving and mesh uploads when nothing changed.

Across 12 final feature views, unchanged-view CPU means were 0.076-0.092 ms and p95 0.116-0.125 ms. The separate 90-frame active-lens runs were 8.493-8.986 ms mean and 8.825-9.904 ms p95. This remaining cost is material for a headset; a paused-cache measurement is not an active-VR performance pass. All measurements are CPU method timings on an RTX 3060 Ti Windows workstation; GPU cost, VRAM/RAM, device thermals and sustained target frame budgets remain unmeasured.

The cache is invalidated by observer position, field transform, lens positions/activation, source transforms/activation and bending/ray display toggles. Source reinitialization marks its transform dirty. ImageUpdateCount tests prove static reuse, live observer updates and external source movement detection. Head rotation alone need not rebuild these current world-position billboards; this does not solve per-eye rendering.

## Visual review and remaining risks

Twelve genuine 1600x900 captures were inspected: overview, above, side, wrist, options, Story, Graph, Model, bending on/off, ray guides and conceptual remnant. Source PNGs are unretouched. World panels remain fixed in space, so side/above views can show panel edges/nearby panels; U hides them. This is not a separate desktop screen-space interface. Later on-device layout should make optional panels movable/reachable and test both eyes, heights and seated use.

Test wrist/label size and contrast on real hardware; current screenshots cannot certify comfort or legibility there. Profile transparency overdraw, MSAA, disk meshes and active binary optics. Keep optional lensing off if it threatens the required model/interaction budget; do not spend the three-week MVP schedule developing numerical relativity or loading huge texture packs. Keep approximation labels and Not connected physics/clock fields until real providers are validated.
