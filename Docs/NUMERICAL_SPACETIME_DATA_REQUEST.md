# Binary optical exhibit: numerical spacetime data request

Status: unsent research specification, not evidence of access or a working renderer.

We are developing a Unity 6.3 LTS educational VR-style binary black-hole exhibit for university students aged 18–30. The aim is observer-dependent strong-field gravitational lensing, photon frequency shifts and proper-time comparisons using one consistent numerical spacetime. A small, well-documented dataset with adequate coverage and validation is preferable to an unbounded download of raw simulation output.

## Requested export

- A time-resolved binary spacetime over a documented observation window, with binary masses/spins/eccentricity, gauge and coordinate conventions. Equal 30+30 solar masses is the existing staging scenario, but **do not rescale a different mass ratio or spin configuration to claim it matches**. A geometrized simulation can be assigned an appropriate total physical mass only with explicit units.
- Lapse alpha, contravariant shift beta^i and all six covariant spatial-metric gamma_ij components throughout the traversable region, including their interpolation/derivative strategy. Extrinsic curvature K_ij is also needed for a normalized 3+1 integrator that uses it. Otherwise sufficient time/spatial metric derivatives must support the chosen geodesic formulation. State whether saved fields are conformal or physical and how to reconstruct them.
- Time slices, spatial coordinates, AMR/multipatch maps, tensor bases, ghost-zone rules, refinement boundaries and validity/excision masks. Do not treat fields on different coordinate bases as directly interchangeable.
- Enough **past** temporal coverage to trace each observation back to its emitters or a quantitatively justified outer boundary. Beginning at the dataset's first slice is not generally a valid observing time. Rays leaving coverage must be unavailable, not mislabeled as black-hole capture. Do not loop merger data or freeze the binary while light travels.
- Horizon/excision information and a reviewed ray-termination rule. Apparent-horizon tracks alone are not an event-horizon or ray-capture solution.
- Boundary/far-field prescription, its error bounds and the source/reference-clock worldlines. A far-away reference clock is an ideal weak-field/asymptotic reference, not a literal no-gravity clock. Include a source spectral model or catalogue definitions for measured shifts and physically justified intensity/colour rendering.
- Resolution/cadence, constraints and convergence results, plus a second resolution or independent validation dataset where possible. Ray-step, spatial/temporal interpolation and boundary errors need separate budgets.
- Provenance, source/version identifiers, checksums, redistribution permission and attribution requirements. Dataset licensing is separate from project-code licensing.

We would like guidance on the smallest spatial/time subset that retains the relevant lensing physics and allows interactive camera movement. A GPU-oriented reduction is acceptable only with quantified error against the original dataset. Pre-rendered videos, gravitational-wave strain, apparent-horizon coordinates, curvature scalars or one initial slice alone do not meet these requirements.

## Local activation gates

1. Inventory and hash a real supplied export. Verify fields, coordinate maps, masks, units and time coverage. Do not invent a vendor-specific importer before inspecting its schema.
2. Implement a bounds-checked reader and interpolation backend. Reject gaps, missing fields, unsupported gauges/maps and nonphysical numerical samples. Compare retained data against raw samples and establish derivative accuracy.
3. Connect display poses to metric coordinates, a physical clock and timelike observer trajectories. Separate walking/velocity from head rotation and teleport resets. Bind body/horizon playback to **that dataset**, not the present artistic motion.
4. Implement backwards null-geodesic integration and photon energy tracking, with finite error controls. Validate analytic fixtures, null constraints, convergence and independent binary rays. Finite-path failure is not photon capture.
5. Integrate the visitor and reference proper times over their recorded worldlines. Validate history replay, pause/rate independence, resets/seeks and synchronization conventions.
6. Add adaptive star-image sampling, multiple images, spectra/frequency readouts, magnification and shadow rendering. Keep the scientific values separate from any visibility enhancement.
7. Profile actual Unity GPU/CPU performance and separately test stereo per-eye origins and target-headset comfort. Reduced resolution/interpolation caches may improve responsiveness but do not establish accuracy by themselves.

## Investigated leads

- [Einstein Toolkit binary example](https://einsteintoolkit.org/gallery/bbh/index.html): full output offered by request; its public [Zenodo subset](https://zenodo.org/records/155394) is not a verified complete metric history.
- [SXS/SpEC](https://data.black-holes.org/waveforms/documentation.html): waveform/horizon/initial-state documentation does not establish access to full evolving volume fields. The [Bohn et al. ray-tracing paper](https://arxiv.org/abs/1410.7775) demonstrates the intended dataset-based approach.

No collaborator was contacted automatically. Provide a local dataset directory or accessible data link to start schema inspection; otherwise the project group/supervisor must arrange the required export with a numerical-relativity provider or authorize a separately scoped simulation-generation route.
