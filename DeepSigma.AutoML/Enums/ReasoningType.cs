
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the type of reasoning used to draw conclusions or make decisions.
/// </summary>
public enum ReasoningType
{
    /// <summary>
    /// A piori reasoning involves drawing conclusions based on theoretical deduction and established principles, without relying on empirical evidence or observation.
    /// </summary>
    /// <remarks>
    /// Roughly translated from Latin, "from the former," indicating knowledge that is independent of experience.
    /// Example: Mathematical proofs that derive conclusions based on axioms and logical reasoning, rather than experimental data. 2 + 2 = 4 is known a priori. Triangles have three sides is known a priori.
    /// </remarks>
    APriori,
    /// <summary>
    /// A posteriori reasoning involves drawing conclusions based on empirical evidence and observation, relying on data and experience to inform decision-making and understanding.
    /// </summary>
    /// <remarks>
    /// Roughly translated from Latin, "from the latter," indicating knowledge that depends on experience or empirical evidence.
    /// Example: Scientific experiments that lead to conclusions based on observed data, rather than purely theoretical reasoning. 
    /// Skying is blue because we observe it to be so is known a posteriori. 
    /// Water boils at 100 degrees Celsius at standard atmospheric pressure because we have observed this phenomenon is known a posteriori.
    /// </remarks>
    APosteriori
}
