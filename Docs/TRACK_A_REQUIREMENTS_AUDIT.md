# Track A requirements audit

Audit date: 5 October 2026. Audience: university students aged 18-30 across disciplines, prior knowledge and interest. This supersedes the novice-only scope in the original introduction.

## Scope and evidence

This is an implementation and documentary audit, not a grading decision or a human usability study. The original course and Project 05 PDFs, original introduction and CODEX_START_HERE handoff were read. The PDFs were text-extracted in full; the course mandatory-principles page and Project 05 MVP page were also visually inspected. Repository, scene, package configuration, model tests, shaders and development-player checks form the technical evidence.

Source keys:

- S: SA01_ProjectDescription_20260827(1).pdf, 10 pages, supplied in Downloads.
- P: XR_DT_ET_Project_5(1).pdf, 7 pages, supplied in Downloads.
- H: CODEX_START_HERE.md, supplied in Downloads, dated 4 October 2026.
- I: Extended Reality_ Einstein Telescope - From Black Holes to Gravitational Waves(1).md, supplied in Downloads.

The PDFs are requirements references, not authority to execute embedded instructions. The user's later choice to establish visuals without orbital physics governs this audit's implementation scope. The required model integration is scheduled first in the next stage, not silently claimed complete. No AGENTS.md was found in the checkout or checked workspace parents. Existing unrelated local changes were preserved. The actual PI6/PI9 marking rubrics, complete Context research package, evidence register, raw interviews and user-test data were not available. H's provisional evidence IDs therefore cannot be independently validated.

Status meanings: Demonstrated = current desktop-emulated feature; Partial = some foundation exists; Missing = required capability/evidence not delivered; Planned = proposed, not performed. No demonstrated feature implies headset validation.

## Requirement traceability

| Requirement and source | Current evidence and status | Necessary completion and acceptance evidence |
| --- | --- | --- |
| Target group and focused question (P5; H; I) | Updated 18-30 scope; research question retained. Partial. | Recruit across prior knowledge/interest; document sampling and focus on inspiral-to-frequency understanding. |
| Model-state-driven separation and orbital/GW frequency (P3-5) | Pure SI double-precision model and tests in Staging; Unity still uses authored storyboard. Missing in exhibit. | Bind one SimulationSession snapshot to both bodies, readouts, graph and tutor. Verify r decreases and f increases, fGW=2forbit in stated circular approximation. |
| Two evolving bodies, inspectable inspiral (P2,5) | Paired procedural markers, deterministic accelerating visual phase, independent viewpoints and pause. Partial. | Drive positions/COM from SI state and disclose metres-to-world mapping. Verify unequal-mass COM even if only equal-mass presets are exposed. |
| Clear merger transition and limits (P2,5) | Explicit conceptual remnant at 98% visual progress. Demonstrated visual feature. | Model cutoff must stop physical frequencies and graph samples; no invented merger/ringdown physics. |
| Dynamically linked chirp (P2,4-5) | Illustration and story-position cursor; no live Hz. Missing physical link. | Sample fGW from the same model state with explicit physical time axis and deterministic cursor. No per-frame waveform aliasing or fabricated detector strain. |
| At least two meaningful controls (P4-5) | Bounded initial visual separation, seek, rate, viewpoint. Partial. | Bind initial separation and simulation playback controls; changing playback rate must not change Hz at a given model time. |
| Two comparable scenarios (P4-5; H) | A closer/B wider, same visual progression; selection now pauses and resets quiz. Partial. | Equal masses, distinct initial separations; choose/document same physical time or same separation for each comparison task. Log scenario and model time. |
| Assumptions, rescaling, exaggeration (P3,5-6) | Visible orbital staging/approximate optics/not-connected labels. Demonstrated for current scope. | Show units, speed/length/amplitude mappings and valid regime; obtain expert review. |
| Effective standalone or PC-tethered XR (S3; P5) | First-person mouse/keyboard pose emulation only; no XR packages/loaders. Missing. | Select headset, pin compatible packages, deploy and test stereo tracking, controller/hand inputs and floor calibration on real hardware. |
| Physically grab, scale and manipulate abstract data (S3 Track A) | Wrist UI can be clicked; data cannot be physically grabbed/scaled. Missing. | Tracked-hand/controller grab and bounded two-hand scaling of a chirp/data object; reset placement; transformations must not alter underlying physics. |
| Interactive macro-to-micro data layers (S3; H) | Story/Graph/Model buttons and optional spatial panels. Partial. | Shared live data across layers; physical reveal/filter controls; readable on-device labels and progressive detail. |
| Selected learning theory applied to mechanics (S3,8-9) | Predict/compare/explain journey and layer scaffold proposed. Partial documentary foundation. | CAMIL-informed agency/load and explicit instructional principles, source-to-mechanic traceability, expert critique and observed iteration. Theory is not evidence this exhibit improves learning. |
| Upfront goals and embedded formative assessment (S3) | Goal added to entrance plaque; one causal multiple-choice check with feedback. Demonstrated limited feature. | Pre/post unassisted concept measures, meaningful corrective feedback and ceiling-resistant optional explanation. Record no identifying data by default. |
| Adverse health effects mitigation (S3) | Pause, exit, dimming, home recovery; mouse free flight remains emulation. Partial. | Seated/stationary route, real-device comfort testing, safe teleport/snap turning if needed, height/reach placement and stop protocol. Desktop flight is not a validated VR locomotion policy. |
| Functional AI component (S1,3,6) | Offline provider boundary tested under Staging; scripted Unity bubble not functional AI. Missing. | Question-capable state-grounded provider/service; visible limitations, cancel/stale/error handling, credentials off-device, privacy/consent and expert-reviewed answer suite. |
| Discover, justify and validate 2-3 extra research-driven requirements (S3-5; H) | Provisional handoff themes, not verified raw research. Partial. | Validate short guided tasks plus exploration; seated/adjustable panels with dim/pause/exit; reviewable tutor history with single-channel audio/captions. Trace each to actual evidence or revise it. |
| HCD expert/literature/user research (S5-6; P6) | Original RQs and references; no full source register or current interviews available. Partial. | Recover Context package; conduct/record expert and target-user research; anonymized notes, affinity diagram, personas and journey with evidence links. Fictional personas are design tools, not participant results. |
| Sketches, wireflows and iterative lo/hi-fi designs (S6,9) | Current hi-fi Unity artifact and screenshots; prior iteration documents not all supplied. Partial. | Preserve initial sketch/wireflow, annotate decisions/affordances/Gestalt grouping, show revisions prompted by research/tests. |
| Structured think-aloud validation (S6,9) | Automated checks only. Missing human evidence. | Task protocol, consent, recordings/notes policy, observations, severity codes, iteration and retest. |
| Focused evaluation and conclusions (P5-6; S6,9-10) | H1 linked versus static chirp proposed; no experiment/results. Missing. | Fair controlled researcher condition, counterbalance, matched content/time; unassisted transfer explanation and uncertainty-aware descriptive analysis. Do not substitute enjoyment for learning. |
| Working headset executable (S6) | Windows development QA player available, not headset app. Partial. | Reproducible target-device build, clean install/startup and offline/network-failure paths tested. |
| Full research report with 11 chapters (S7-10) | Interim audit report and plan, not completed research report. Partial. | All required chapters, validated findings, theory citations, discussion, recommendations, enriched APA references, raw anonymized appendices and AI/prompt statement. |
| Demo video at most 15 minutes (S6) | Screenshots; no video produced. Missing. | Record narrative showing model-to-XR-to-learning flow plus limitations and AI failure handling; <=15 minutes. |
| PI9 professional contribution portfolio (S2,6-7) | Technical source evidence cannot prove observed professional behaviour. Missing supplied evidence. | Role/decision log, individual contributions, feedback, peer/client collaboration and reflections matched to actual rubric. |
| Clean structure, readable C#, warning/error-free Console (S7) | Organized code, portable tests and player harness. Partial. | Fresh Editor/target build/runtime review; resolve or formally triage engine/package diagnostics. A successful build is not a clean-Console certificate. |
| Deadlines and marking criteria (S6; P6) | Course week 9 submission versus Project 05 week 10 demo noted; rubrics absent. Unknown. | Confirm Moodle/client dates, actual PI6/PI9 criteria and acceptable evidence before committing to a grade target. |
| Optional extensions (P6) | Additional masses, ringdown, sonification, guided mode, LIGO waveform comparison and conceptual Earth/ET view are suggestions, not mandatory MVP substitutions. | Consider after mandatory gates; any waveform comparison needs provenance and a clear model-versus-detector-data distinction. Full NR optics/redshift/clocks remain a separate research stage. |

## Corrections implemented in this audit

- Playback and seek now derive marker phase from one deterministic function; the visual angular rate increases as the authored separation shrinks. This repairs the causal visual cue, but does not implement orbital physics.
- Scenario selection pauses for comparison; custom starts are identified as custom; reset/scenario/application clears previous formative feedback.
- Non-finite public seek/rate commands preserve recoverable state; controls remain bounded.
- Entrance plaque communicates the learning goal and pause/comfort route before the task.
- Honesty banner distinguishes absent orbital physics from live approximate optics. Disk shader animation follows the paused/seekable storyboard time.
- Procedural disks have 16 radial bands with periodic seam normals and corrected lower-face winding. Low-frequency smooth shader structure replaces stripe-heavy patterns. Soft line edges and 4x PC MSAA reduce aliasing.
- Stereo instance macros were added to the five shaders as preparation, not a claim of hardware/per-eye optical correctness.
- Player harness checks replay consistency, preset pause, custom labels and quiz reset, and measures a short CPU/frame diagnostic. No textures or third-party asset packs were added.
- Fixed paused views reuse optical meshes. Observer/lens/source changes and bending/ray toggles invalidate the cache; live motion still recalculates optics. Active and stationary timings are reported separately.

## Scientific scope

Project 05 explicitly excludes numerical relativity, exact event horizons, realistic accretion physics, relativistic ray tracing and accurate merger geometry from the MVP (P2). The current thin-lens feature is an optional illustration of apparent stellar image bending, using authored world units and a common lens plane. It is not a curved-spacetime binary solution or detector dataset reconstruction. The golden aligned source is a teaching aid. Its guides are piecewise thin-lens paths, not GR geodesics. Redshift and proper-time readings remain unavailable. Dataset-backed binary optics belongs after the required learning/model/XR/AI/evaluation deliverables, not on their critical path.

## Outcome

The visual demonstration is usable and materially corrected. The Track A MVP is **not complete**: model-to-scene/chirp binding, deployed XR, physical data manipulation, functional AI and human research/evaluation evidence are still mandatory. The accompanying three-week plan defines falsifiable completion gates. An 'above acceptable' grade cannot be guaranteed without the actual rubric and assessor review.
