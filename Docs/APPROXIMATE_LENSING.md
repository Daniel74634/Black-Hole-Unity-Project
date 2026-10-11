# Live approximate light bending

On 2026-10-05 the user explicitly requested approximate lensing and deferred redshift. This feature does not require the numerical spacetime export discussed earlier. That export remains necessary only for a future validated strong-field binary renderer.

## Try it

Open `Assets/DTET/Scenes/BinaryBlackHole_VisualStaging.unity` in Unity 6000.3.25f1 and press Play, or run the QA player. Bending is enabled initially.

- **J** pauses the orbital storyboard and places the viewer near alignment with the fixed, bright demonstration star behind body A (or the conceptual remnant at the endpoint). A 0.35-unit upward offset helps avoid hiding the images behind the artistic disks. Alignment is a visitor relocation, not a change to the star position. The apparent images split/stretch around the foreground marker. Move with WASD/Q/E and right-drag to inspect changing alignment.
- **L** toggles lensing off/on to compare direct and apparent source directions at the same viewpoint.
- **G** toggles the demonstration source's broken-ray guides. These join observer, lens-plane impact point and source. Their kink expresses the thin-lens approximation; they are **not** curved GR geodesics or a photon flight-time simulation.
- **V** raises the wrist. The new LENS, RAYS and ALIGN buttons perform the same commands. **F** returns to the main exhibit, and Space resumes the storyboard.

The world-space information area has an **Approximate bending** card. The entrance plaque and wrist controls also identify the new keys. No desktop-specific interface was added.

## What is calculated

The 1,400 synthetic stellar objects stay fixed. Their apparent images are rebuilt from the current observer and marker positions each frame, using the paraxial thin-lens equation for one or two positive point masses projected onto a common instantaneous plane. For a single lens, its strength is `theta_E² = 4 r_g (D_s-D_l)/(D_l D_s)`, and the lens equation gives two analytic point images when off-axis. For two lenses, deflections sum in that common-plane equation; a bounded, damped multi-start Newton search finds up to five roots. The local lens-map Jacobian stretches the circular source sprites. Exact/numerically aligned single-lens demonstration views use an annular point-sprite display.

Foreground sources are left direct. Sources outside the implemented forward cone and unsupported close viewpoints also use a direct preview. Rest colours do not change: no redshift, blueshift, spectral calculation or gravitational clock rate is produced by this feature. Physical clocks remain unavailable, because a thin-lens map does not supply the full metric/worldline history needed for them.

The gravitational radius parameter is **0.055 exhibit units per active marker**, chosen for a visible pedagogical effect. It is not inferred from the artistic silhouettes, their disk sizes or the displayed solar-mass scenario. Stellar distances, sizes and tints remain authored display values. Source 0000 has an enlarged 0.50-unit display radius to make the inspection example legible. The remnant lens is a conceptual illustration, not a merger prediction.

## Important limits

- This is a static/instantaneous common-plane, small-angle approximation, not a moving binary spacetime. Motion during photon propagation, time delays, relativistic observer aberration, spinning-hole effects and near-horizon photon loops are absent.
- Summing point-mass deflections in the thin-lens equation does not solve the Einstein equations for the binary. It is suitable for demonstrating lens alignment, displaced/split images and stretching, not for quantitative strong-field predictions.
- The two markers may have different depths in a side view; projecting both onto one plane is another approximation. Close viewpoints are excluded rather than presented as an accurate horizon view.
- A bounded Newton search can miss roots near caustics. A failed solve uses the direct preview, never a claim of photon capture. Image-stretch magnitudes are capped at 18 times the authored source size to avoid point-source singularities; the sprite/ring brightness is not a calibrated flux or magnification measurement.
- Existing dark silhouettes geometrically occlude some images; they are not calculated relativistic shadows. Accretion disks are still artwork and are not ray-traced by this star-only effect.
- Per-eye stereo rendering and headset performance/comfort have not been verified. The source mesh is batched, but source projection and root solving currently run on the CPU.

Scientific basis: [point-mass lens equation and multiple images](https://ned.ipac.caltech.edu/level5/Blandford/Blandford3_2.html), [ESA explanation of lens alignment](https://www.esa.int/ESA_Multimedia/Images/2025/02/Einstein_ring_explained). These support the lensing principle, not a claim that this implementation reproduces full black-hole optics.

## Verification

`dotnet run --project Staging/Simulation.Tests/BlackHole.Staging.Simulation.Tests.csproj -c Release` links the actual Unity-independent `ThinLensModel.cs` source. Tests compare 100 single-lens offsets with analytic image positions and parity; verify a symmetric two-mass case with five independently known roots; check residuals, translation invariance, the Jacobian by finite differences, foreground geometry and invalid input rejection. All existing model/clock/ADM regressions still run. These are tests of the approximate equation, not numerical-relativity validation.

Development captures add `Lensing` and `LensingOff` variants and `DTET_APPROXIMATE_LENSING_PASS`: live split/deflected images, fixed source position under navigation, changing apparent position, unchanged rest tint, broken-ray guides, direct-image restoration and wrist command wiring. Player and screenshot receipts are recorded in DESKTOP_VISUAL_QA.md after running them.

Verified 2026-10-05: Unity 6000.3.25f1 compiled and built successfully; Lensing, LensingOff and Wrist development players returned 0 with all seven checks and fresh screenshots. All three captures were visually inspected. Existing source model, clock, ADM and new thin-lens tests pass. The two comparison captures have the same paused storyboard and near-aligned observer pose, with guides hidden and wrist lowered; only bending changes. Headset/stereo rendering, frame-time profiling and human usability remain unverified.
