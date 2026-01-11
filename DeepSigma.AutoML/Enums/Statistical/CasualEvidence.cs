namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies the type of evidence supporting a causal relationship between a cause and an effect.
/// Truely randon controlled experiments are the gold standard for establishing causality, but in many cases, such experiments are not feasible or ethical.
/// Below are various types of evidence that can support causal inferences in observational studies and other non-experimental settings.
/// </summary>
public enum CasualEvidence
{
    ///////////////////////////////////
    //Direct evidence
    ///////////////////////////////////

    /// <summary>
    /// Size of effect is so large it cannot be explained by confounding factors.
    /// </summary>
    SizeOfEffectCannotBeExplainedByConfounding,

    /// <summary>
    /// The cause precedes the effect in time, and they occur close together in time and/or space. 
    /// The cause preceeds effect and effect follows cause after a plausible time interval, and/or cause occures at the same site as the effect.
    /// </summary>
    TemporalAndOrSpatialProximity,
    /// <summary>
    /// The effect changes when the cause is changed. The effect increases as exposure increases.
    /// Additionally, the evidence is even stronger if effect reduces upon removal of the cause.
    /// </summary>
    ResponsivenessAndReversibilityOfEffect,

    /////////////////////////////////////
    //Mechanistic evidence
    /////////////////////////////////////

    /// <summary>
    /// There is a plausible mechanism of action between the cause and the effect: biological, social, technical, chemical, mechanical, etc.
    /// External evidence supports the proposed mechanism of action through a "causal chain".
    /// </summary>
    PlausibleMechanismOfAction,

    /////////////////////////////////////
    //Parallel evidence
    ///////////////////////////////////

    /// <summary>
    /// The effect is consistent with other knowledge, including established facts, theories, and principles.
    /// </summary>
    EffectFitsWithOtherKnowledge,

    /// <summary>
    /// The effect has been observed in other studies when replicating the study.
    /// </summary>
    ReplicationOfFindings,

    /// <summary>
    /// Similar effects have been observed in related but not identical studies.
    /// </summary>
    SimilarEffectsInRelatedButNotIdenticalStudies
}

/// <summary>
/// Extension methods for the <see cref="CasualEvidence"/> enum.
/// </summary>

public static class CasualEvidenceExtensions
{
    /// <summary>
    /// Gets the type of evidence for the specified casual evidence.
    /// </summary>
    /// <param name="evidence"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static EvidenceType GetEvidenceType(this CasualEvidence evidence)
    {
        return evidence switch
        {
            CasualEvidence.SizeOfEffectCannotBeExplainedByConfounding => EvidenceType.Direct,
            CasualEvidence.TemporalAndOrSpatialProximity => EvidenceType.Direct,
            CasualEvidence.ResponsivenessAndReversibilityOfEffect => EvidenceType.Direct,
            CasualEvidence.PlausibleMechanismOfAction => EvidenceType.Mechanistic,
            CasualEvidence.EffectFitsWithOtherKnowledge => EvidenceType.Parallel,
            CasualEvidence.ReplicationOfFindings => EvidenceType.Parallel,
            CasualEvidence.SimilarEffectsInRelatedButNotIdenticalStudies => EvidenceType.Parallel,
            _ => throw new ArgumentOutOfRangeException(nameof(evidence), evidence, null)
        };
    }
}
