# 1 DT ET prototype audit and development report

Track A Digital Twins and Big Science | Project 05

Zuyd University of Applied Sciences | Course SA01 | Class identifier not supplied

Emin Yılmaz, Danila Šhkarupin, Iustin Poleac and Vincent van Driel

Client contact named in the course brief: Josi Menezes da Silva

5 October 2026 | Interim technical audit and three week implementation plan

We are developing an explorable binary black-hole learning exhibit for university students aged 18-30, across knowledge, interest and discipline levels. The current demonstration establishes the visual environment, wrist interface, inspection controls and approximate stellar image bending. It is not yet the model-driven XR Digital Twin required by the briefs.

![Figure 1. Current Unity exhibit with the wrist lowered. Procedural paired markers and spatial lesson panels are visual staging; physical readings remain Not connected.](audit:Observe)

This report separates demonstrated features, tested source foundations, missing mandatory capabilities and proposed research. We do not claim learning gains, completed headset deployment, functional AI, a complete relativistic binary model or a guaranteed grade.

<!-- PAGE -->
# 2 Management summary

The audit found a usable visual foundation with important mandatory gaps. We corrected deterministic replay, the accelerating-motion visual cue, scenario pause/reset behaviour, custom-start labels, stale quiz feedback and misleading physics wording. We improved the compact procedural graphics and removed unnecessary optical recalculation from unchanged paused views.

| Area | Evidence now | Required next outcome |
| --- | --- | --- |
| Model and chirp | Tested SI model outside Unity; scene uses an authored storyboard | One model snapshot drives bodies, frequencies, graph and tutor |
| XR and Track A interaction | Same world-space interface with emulated head/wrist poses | Real headset deployment plus tracked grab, scale and reveal of abstract data |
| Learning and research | Upfront goal, layered explanations and one formative check | Evidence-linked design principles, expert review and consented target-user evaluation |
| AI | Explicit offline staging label and tested provider boundary | Functional state-grounded question answering with safe failure handling |
| Presentation and delivery | Corrected visual prototype, genuine screenshots and reproducible QA | Full research report, <=15-minute video and individual PI9 evidence |

The scene is deliberately honest about its limits. Orbital movement and chirp artwork are not physical readings. The endpoint is conceptual. The live thin-lens illustration is optional and is neither numerical relativity nor strong-field binary ray tracing.

Our priority is the causal learning chain: closer separation leads to faster orbital motion and higher gravitational-wave frequency in the disclosed simplified model. Realistic disks, redshift and dataset-backed optics are not MVP requirements in Project 05 [P, p. 2]. They must not displace model integration, XR manipulation, functional AI or evaluation.

The three-week plan targets evidence stronger than the minimum through traceable research, robust interaction and scientific honesty. Actual PI6/PI9 rubrics were not supplied. Only the assessors can determine whether the delivered evidence is above acceptable.

<!-- PAGE -->
# 3 AI technology statement

Codex assisted with source inspection, audit mapping, corrective code, regression checks, screenshot automation and this interim report. Proposed text and code were checked against supplied briefs, source tests and actual Unity player output. AI assistance does not substitute for expert physics validation, user research or individual professional reflection. A complete prompt/model-use log and team critical reflection remain final-submission tasks.

The in-exhibit guide is currently scripted and explicitly labeled offline staging. It is not a functional AI tutor. The portable tutor provider captures versioned simulation context and rejects stale replies in tests, but is not yet connected to the Unity experience or a working question-answering backend.

A separate ChatGPT review has not been performed. The user requested collaboration, but the destination ChatGPT chat has not been selected. A companion handoff supplies the evidence and review questions; this report does not misrepresent Codex audit assistance as an independent ChatGPT review.

# 4 Introduction

The learning problem is connecting a changing binary orbit to gravitational-wave frequency, rather than simply watching an attractive animation. An immersive exhibit can make viewpoint and data representations controllable, but its instructional value must be evaluated, not assumed.

Main research question: How can an interactive XR Digital Twin support university students in understanding the relationship between binary black-hole inspiral and the gravitational waves produced by the system? [P, p. 5; I; H]

We retain one focused experimental hypothesis: a dynamically linked chirp will support more accurate motion-to-frequency explanations than a static chirp under matched exposure. Manipulation, layered labels and a state-aware tutor are design expectations to investigate through usability and qualitative evidence, not extra controlled experiments promised within three weeks.

Subquestions: Which learning and human-AI principles fit these students? How do prior knowledge and interest affect guidance needs? Which manipulation and layer interactions clarify the causal chain? How should state-grounded AI explain the current scenario? How can mappings and approximation limits remain understandable? What learning, usability, comfort and trust evidence supports or contradicts the design? [I; H]

The previous novice-only audience description is superseded by the user's 18-30 university scope. Prior knowledge and interest must be recorded, with optional advanced explanations to reduce expert ceiling effects. The artifact is the research instrument; screenshots and automated tests are not research results about learning.

<!-- PAGE -->
# 5 Theoretical framework

CAMIL treats presence and agency as affordances mediated by cognitive and affective processes, including cognitive load and self-regulation. It is a theoretical synthesis, not a trial establishing this exhibit's effectiveness. Our proposed application is agency through bounded data manipulation, progressive detail, short tasks and explicit learner control of pace. [Makransky & Petersen, 2021]

Human-AI interaction guidelines inform capability labels, relevant context, user control and correction/error recovery. Amershi et al. validated guidelines through multiple rounds including 49 practitioners inspecting 20 AI-infused products; those findings are not an XR-tutor learning result. Our application is visible provider status, snapshot grounding, cancel/retry and rejection of stale context. [Amershi et al., 2019]

The physics foundation for the next stage is a circular Newtonian relation, omega squared approximately GM/r cubed, with fGW approximately twice orbital frequency in the stated regime [P, p. 3]. Leading quadrupole inspiral provides an explicitly simplified decay model; it is not a complete merger solution [Peters, 1964]. Length, time and graphical amplitude mappings must remain visible.

# 6 Methodology

This audit read both original PDFs in full, the handoff and original introduction; inspected Unity scene, code, shaders and package versions; ran portable regression tests; built a development player; exercised injected inputs and captured feature screenshots. Selected source pages were rendered to verify the mandatory-principles, formula, MVP and report-reference layouts. This is technical validation, not a think-aloud study.

The planned human-centred process combines client/expert review, literature, varied target-user interviews, affinity grouping, evidence-linked personas/journey, wireflows, iterative prototyping and think-aloud evaluation. The Context package and raw evidence register were not available; provisional handoff themes cannot be independently verified. No participant results or quotations are invented.

For the focused evaluation, prepare consented sessions, matched linked/static conditions, counterbalancing or reviewed allocation, parallel concept questions and unassisted post-task explanations. A proposed feasible target is 8-12 adults, subject to recruitment and approval; this is not a sample already obtained or a powered efficacy claim. Record prior knowledge, order, missing data, comfort, confusion and trust; report descriptive outcomes and limitations.

<!-- PAGE -->
# 7 Results

## Requirement audit of the exhibit

The full row-by-row traceability matrix is in Docs/TRACK_A_REQUIREMENTS_AUDIT.md. Demonstrated below means desktop-emulated, not headset-certified. P refers to Project 05; S to the course brief.

| Required capability | Current status | Completion evidence |
| --- | --- | --- |
| Model evolves separation and frequencies [P3-5] | Missing in scene; tested portable foundation | Shared SI snapshot controls both bodies and readouts; fixtures agree |
| Linked chirp and clear cutoff [P2,5] | Illustrated cursor/curve; conceptual endpoint | Model-sampled Hz/time graph stops physical output at cutoff |
| Two controls and two scenarios [P4-5] | Bounded visual controls and paused A/B presets | Meaningful model controls and documented comparison convention |
| Grab, scale and manipulate abstract data [S3] | Missing; click UI is insufficient | Tracked data-object interaction tested on chosen headset |
| Interactive macro-to-micro layers [S3] | Partial Story/Graph/Model scaffold | Shared live data with on-device reveal/filter and legible detail |
| Effective XR and comfort [S3; P5] | Pose emulation, pause/dim/exit only | Deployed stereo tracking, seated reach and real-device comfort evidence |
| Functional AI [S1,3,6] | Missing; offline placeholder is honest | Working state-grounded questions, safe failures and expert-reviewed answers |

The central correction is consistency: both playing and seeking now evaluate one deterministic visual phase. The angular rate increases as the authored orbit shrinks. This repairs a misleading visual cue without pretending that the new choreography is physics. Applying a custom start and choosing a preset now resets formative feedback; presets pause for fair inspection.

Public seek/rate commands ignore non-finite values without corrupting state. Shader disk flow follows storyboard time, so pause/seek affects the illustration too. The entrance plaque states the causal learning goal, pause shortcut and comfort route upfront.

<!-- PAGE -->
# 7 Results continued

## Learning research and submission evidence

| Requirement | Evidence available | Action still needed |
| --- | --- | --- |
| Selected theories applied to mechanics [S3] | Proposed CAMIL and human-AI traceability | Expert critique and observable mechanism-to-test mapping |
| Upfront goals and formative assessment [S3] | Entrance goal; one causal question with feedback | Baseline/post concept measures and explanatory feedback |
| 2-3 additional research requirements [S3-5] | Provisional handoff preference themes | Validate short guided tasks, adjustable seated comfort and reviewable tutor/captions |
| Expert and target-user research [S5-6] | Original questions/references; incomplete source package | Recover evidence register; anonymized interviews and affinity analysis |
| Personas journey and iterative design [S6,9] | Current hi-fi artifact; handoff personas are design tools | Evidence-linked personas, sketches/wireflow and revision rationale |
| Think-aloud usability evaluation [S6,9] | No human evaluation supplied | Task observations, coded severity, fixes and retest |
| Focused learning evaluation [P5-6] | H1 proposed; no results | Matched linked/static comparison and unassisted explanations |
| Working headset executable [S6] | Windows development player | Target-device release candidate and clean install test |
| Eleven-chapter research report [S7-10] | This interim audit uses required structure | Complete actual research/design/validation results and appendices |
| Demo video <=15 minutes [S6] | Screenshots only | Record causal model, tracked interaction, tutor and limitation/failure paths |
| PI9 professional contribution [S2,6-7] | Technical evidence is not observed behaviour | Individual contribution, feedback, collaboration and reflection portfolio |
| Clean readable code and Console [S7] | Portable tests/player build pass; engine diagnostics remain | Fresh Editor/device warning/error review and resolution |

The course submission and project demo weeks differ in the supplied briefs. Confirm the actual Moodle schedule and PI6/PI9 rubric before promising a deadline or grade. These requirements cannot be replaced by higher-fidelity art.

<!-- PAGE -->
# 7 Results continued

## Independent observation viewpoints

![Figure 2. Above-view inspection. The procedural annuli have continuous circumferential detail, explicit thickness and softer edges. They are illustrative assets, not predicted accretion emission.](audit:Above)

![Figure 3. Side-view inspection. Navigation is independent of storyboard time; changing viewpoint does not alter the learning state. The environment uses fixed finite-distance stellar sources, not a camera-following sky image.](audit:Side)

<!-- PAGE -->
# 7 Results continued

## Body attached wrist and input options

![Figure 4. Raised emulated wrist. The glove, cuff and control canvas share a wrist transform; looking away does not pin the menu to the head. This is not hardware hand tracking.](audit:Wrist)

![Figure 5. Wrist options. Mouse-look and scroll sensitivities are independent, bounded and resettable. Default scroll travel is three times the earlier setting. QA does not overwrite visitor preferences.](audit:Options)

<!-- PAGE -->
# 7 Results continued

## Story and graph layers

![Figure 6. Story layer. Students can inspect closer/wider presets, apply a bounded custom start, seek, change playback and answer a causal formative question. These controls currently operate visual staging.](audit:Story)

![Figure 7. Graph layer. The curve is explicitly an illustration with a story-position cursor, not a model-sampled Hz graph. Connecting this layer to the SI model is a Week 1 requirement.](audit:Graph)

<!-- PAGE -->
# 7 Results continued

## Model layer and conceptual endpoint

![Figure 8. Model layer. The display distinguishes the simplified frequency relationship and missing physical connection from the artwork. Advanced details are optional rather than imposed on every visitor.](audit:Model)

![Figure 9. Conceptual remnant. At the visual endpoint, the two markers are replaced by a labeled remnant. No merger geometry, ringdown, final mass or relativistic clock value is asserted.](audit:HudEnd)

<!-- PAGE -->
# 7 Results continued

## Approximate stellar bending comparison

![Figure 10. Bending enabled at a fixed demonstration alignment. The golden background source has split/stretched apparent images; source objects stay fixed. Lens strength, distances and display magnification are authored, not astronomical calibration.](audit:Lensing)

![Figure 11. Bending disabled at the same observer/story pose. The direct source direction is restored; at this alignment the foreground illustrative marker occludes it. The marker disks remain artwork in both conditions.](audit:LensingOff)

<!-- PAGE -->
# 7 Results continued

## Ray guides and future relativity boundary

![Figure 12. Optional thin-lens broken-ray guides. These three-point paths indicate source to common lens plane to observer geometry. They are not GR geodesics and must not be presented as a binary spacetime solution.](audit:LensingRays)

There are 1,400 independent synthetic stellar emitter objects with stable identities and finite positions. Their apparent images share one dynamic mesh. Bending is recalculated when the observer, lenses, sources or display toggles change. Unchanged paused views reuse the existing mesh; this saves CPU work without moving the source objects or freezing optics during actual movement.

The proper-time comparison card and observer provider boundary are preparatory. Physical clock totals and redshift are unavailable and visibly say Not connected. Analytic ADM/local clock fixtures test mathematics and stale-history contracts, not an installed binary metric. A true strong-field binary display requires validated evolving spacetime data and ray tracing; it is a separate research stage.

Project 05 excludes this level of relativistic rendering from its MVP [P, p. 2]. We should keep the optional illustration bounded, clearly labeled and profiled, while prioritising the required model, learning interactions, AI and evaluation. Mono-camera optical projection remains a specific stereo implementation risk even though shader instance macros are present.

<!-- PAGE -->
# 7 Results continued

## Technical verification and compact graphics

{{VERIFICATION_TABLE}}

The actual Editor version is 6000.3.25f1, Unity 6.3 LTS. URP is 17.3.0, Input System 1.17.0 and UGUI 2.0.0. The manifest requests Test Framework 1.4.2; the lockfile and Editor resolve 1.6.0. No OpenXR, XRI or XR loader is configured. Source model tests run in .NET; no separate Unity NUnit suite or headset tests are claimed.

The asset changes use no texture pack or external art. Disk meshes now use 16 radial bands, periodic normals and corrected underside winding; the shader replaces angular stripe patterns with lower-frequency smooth procedural variation. Soft line edges and PC 4x MSAA improve aliasing. These choices increase runtime geometry/shading and MSAA buffer cost, not texture download size. They need real-headset profiling before being adopted for that target.

{{SIZE_TABLE}}

The source asset folder remains less than 0.4 MiB. Library and Builds are generated caches/output, not imported artwork; none was broadly deleted. Screenshots and PDF are outside Unity Assets and should not be shipped in the headset player.

{{PERFORMANCE_SUMMARY}}

Limits: successful builds do not certify a clean Editor Console. The log still has a URP TraceRenderingLayerMask.urtshader host-type diagnostic and a licensing token-refresh error alongside successful licensed build completion. Player startup also reports a D3D12 info-queue diagnostic. Investigate/triage them before final submission. Screenshots and injected inputs do not establish human usability, Editor Play-window feel, stereo correctness or hardware comfort.

<!-- PAGE -->
# 8 Discussion and conclusion

We can now demonstrate a more coherent, compact visual exhibit. Replay and seek agree, scenario comparison starts paused, formative feedback no longer survives a reset, the learning goal is visible, and optional optics avoid needless paused recalculation. Genuine player captures show viewpoints, body-attached controls, layers, bending comparison and the conceptual endpoint.

We cannot yet answer the main learning research question from human results. No user study, measured learning gain or validated target-device comfort is available. The model exists and passes tests, but the exhibit is not yet model-driven. Functional AI and physical data manipulation are absent. These are requirements gaps, not optional polish items.

Teamwork and PI9 reflection must be written by the actual contributors from observed work and feedback. This report does not invent ownership, attendance, quotes or professional behaviour. Separate ChatGPT critique is still pending the chosen destination chat.

# 9 Recommendations

## Week 1 5 to 11 October

Kickoff: allocate team owners/reviewers; obtain actual rubrics/deadlines and Context research evidence; choose headset and AI service/data policy; book expert and participant sessions. Escalate lack of hardware by day 3 rather than leaving it until evaluation week.

Bind the tested SI SimulationSession to Unity bodies, readouts, graph and tutor snapshot. Keep double precision internally; document metres-to-world and physical-to-playback time mapping. Use equal masses and different initial separations for A/B. Declare whether comparison uses equal physical time or equal separation. Preserve conceptual cutoff without fake merger output.

Prepare evidence-linked wireflow, interviews, affinity grouping and task/assessment protocol. Establish real tracked camera/wrist smoke build and an external tutor service skeleton with credentials off the client.

Gate 1: Unity positions and frequencies match portable fixtures at multiple times; fGW=2forbit in the model; pause/seek/rate/layer changes preserve invariants; expert reviews limits; headset tracking and readable wrist are demonstrated; evaluation recruitment/protocol are ready.

<!-- PAGE -->
# 9 Recommendations continued

## Week 2 12 to 18 October

Implement tracked grab and bounded two-hand scale/rotate of an abstract chirp/data object, reset placement and macro-to-micro reveal/filter. Scaling the display must not change model quantities. Add seated/stationary reach, safe optional teleport/snap turn and adjustable readable panels; test both eyes. Disable optional optics in headset builds until per-eye projection is validated.

Make the tutor functionally answer student questions using captured model state and approved lesson material. Include uncertainty/limitations, reviewable history, cancel/retry/timeout, offline and stale-reply states. Always provide text/captions; any speech needs one user-controlled audio channel and approved privacy handling.

Pilot think-aloud tasks and revise the three provisional research extras: short guided tasks with exploration breaks, seated adjustable comfort, and reviewable tutor/caption history. Add unassisted baseline/post questions and a researcher-only static-chirp condition, while normal use always stays dynamically linked.

Gate 2: on-device grab/scale/filter, seated controls and stereo shaders work; CPU/GPU/memory are measured; tutor passes expert-reviewed unit, unsupported-physics, timeout/cancel and stale-context cases; pilot evidence produces documented design revisions.

## Week 3 19 to 25 October

Conduct approved target-user sessions across knowledge and interest levels. Match condition exposure/content, counterbalance or justify allocation, record order/prior knowledge and evaluate unassisted conceptual explanations. Proposed target 8-12 adults is feasibility planning, not proof of statistical power. Analyse descriptive outcomes, uncertainty, ceilings/order effects, missing data and coded usability/comfort/trust themes.

Correct high-severity issues and retest critical tasks. Profile worst-case real-device scenes, produce reproducible headset build, then complete all 11 course report chapters with actual findings, annotated APA sources, anonymized appendices and AI reflection. Record a <=15-minute demo and individual PI9 evidence.

Gate 3: every mandatory audit row has real implementation/research evidence against the actual rubric; supported device installs/runs; defects and failure cases are reviewed; research results exist; report, video and portfolio pass peer review. Failed mandatory gates mean partial completion, not a concealed claim of success.

<!-- PAGE -->
# 10 References

S. Zuyd University of Applied Sciences. (2026). SA01 project description [Course brief supplied by the student]. File: SA01_ProjectDescription_20260827(1).pdf. Discovery: direct user attachment; no database search. Design/participants: requirements document, not an empirical study. Relevance: defines Track A interactions, AI, research, report and portfolio requirements.

P. DT-ET XR research projects: Project 05. (n.d.). [Project brief supplied by the student; author/date not stated in available metadata]. File: XR_DT_ET_Project_5(1).pdf. Discovery: direct user attachment. Design/participants: project specification, no participant study. Relevance: defines the simplified binary model, linked chirp, MVP and optional physics scope.

H. DT-ET student team. (2026, October 4). CODEX START HERE [Project handoff]. Discovery: direct user file, CODEX_START_HERE.md. Design/participants: implementation handoff containing provisional research themes; underlying Context register not available. Relevance: provides model/provider contracts and the broader university audience; themes still require source validation.

I. DT-ET student team. (n.d.). Extended reality Einstein Telescope from black holes to gravitational waves [Original introduction]. Discovery: direct user Markdown attachment. Design/participants: research framing, not supplied study outcomes. Relevance: supplies questions and H1; novice-only scope is superseded by the later user instruction.

Makransky, G., & Petersen, G. B. (2021). The cognitive affective model of immersive learning (CAMIL): A theoretical research-based model of learning in immersive virtual reality. Educational Psychology Review, 33, 937-958. [Publisher article](https://link.springer.com/article/10.1007/s10648-020-09586-2). Discovery: primary-source web query 'Makransky Petersen 2021 cognitive affective model immersive learning CAMIL', 5 October 2026. Design/participants: theoretical research synthesis; no new single trial sample. Relevance: guides agency, cognitive-load and self-regulation design; does not validate this prototype.

Amershi, S., Weld, D., Vorvoreanu, M., Fourney, A., Nushi, B., Collisson, P., Suh, J., Iqbal, S., Bennett, P. N., Inkpen, K., Teevan, J., Kikin-Gil, R., & Horvitz, E. (2019). Guidelines for human-AI interaction. Proceedings of CHI 2019, 1-13. [Author-hosted paper](https://www.microsoft.com/en-us/research/wp-content/uploads/2019/01/Guidelines-for-Human-AI-Interaction-camera-ready.pdf). Discovery: primary-source web query 'guidelines human ai interaction Amershi 2019 paper', 5 October 2026. Design/participants: multi-round guideline evaluation, including 49 practitioners and 20 products. Relevance: informs tutor capabilities, contextual relevance, control and error recovery, not XR learning efficacy.

Peters, P. C. (1964). Gravitational radiation and the motion of two point masses. Physical Review, 136, B1224-B1232. [APS article](https://journals.aps.org/pr/abstract/10.1103/PhysRev.136.B1224). Discovery: Project 05/handoff referral, checked by primary-source web query on 5 October 2026. Design/participants: analytic gravitational-radiation model, no human participants. Relevance: supports the simplified leading-quadrupole foundation, not full strong-field merger rendering.

These annotations are a verified starting set, not an exhaustive literature review. Final source metadata and additional theories must be checked and expanded by the team as required by the course.

<!-- PAGE -->
# 11 Appendices

## Reproducible scene and run steps

Open BinaryBlackHole in Unity Hub with Editor 6000.3.25f1. Open Assets/DTET/Scenes/BinaryBlackHole_VisualStaging.unity and press Play. The scene now starts paused. Space or the raised wrist Play button begins the visual storyboard. Unity's Play toolbar stops Editor playback; wrist Exit is for the built player.

WASD moves the emulated visitor; Q/E changes height; Shift moves faster; right-drag looks; wheel moves closer/farther, not model separation. V raises/lowers the wrist; O opens input options; F/Home recovers overview; T approaches information; H opens learning; 1/2/3 selects Story/Graph/Model; Space toggles playback; Esc pauses; R resets; B dims; U hides/restores the partner interface. J pauses/aligns the bending demonstration; L toggles bending; G toggles ray guides. K approaches the unavailable clock card.

Use DT-ET > Validate Assets and Build QA Player for the Windows development build. Output: BinaryBlackHole/Builds/VisualQA/BinaryBlackHole_VisualQA.exe. Portable test command from the repository: dotnet run --project Staging/Simulation.Tests/BlackHole.Staging.Simulation.Tests.csproj -c Release. Capture-PrototypeAudit.ps1 reproduces the screenshot variants after building; it requires a chosen output directory and checks exit code, nine pass groups and screenshot hashes.

## Evidence inventory

The screenshot package contains 12 original 1600x900 Unity player PNGs, player logs, capture-receipts.json and provenance. They are not AI-rendered screenshots or retouched composites. Portable test output and final Unity build log sit in the workspace audit evidence folder. Report images come from these same feature captures. Docs/TRACK_A_REQUIREMENTS_AUDIT.md contains the full matrix; Docs/THREE_WEEK_IMPLEMENTATION_PLAN.md contains detailed workstream gates; Docs/GRAPHICS_AUDIT.md explains size/performance tradeoffs.

Still missing for the final research submission: approved participant/expert materials, full evidence register, anonymized raw test data, affinity/persona/journey source links, pilot/main-study analysis, headset profiler captures, live tutor validation/prompt logs, video and individual PI9 reflections. None is manufactured in this interim report.

## Collaboration handoff

Docs/CHATGPT_REPORT_HANDOFF.md provides a review prompt and verified boundaries for an existing ChatGPT chat. Selecting that chat is still needed before a separate review can be sent. The team should have a peer independently check all current-versus-planned claims and every requirement row before submission.
