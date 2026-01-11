
namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies different types of evidence used in statistical analysis and reasoning.
/// </summary>
public enum EvidenceType
{
    /// <summary>
    /// Direct evidence refers to information that directly supports a conclusion without the need for additional inference or interpretation.
    /// </summary>
    Direct,
    /// <summary>
    /// Mechanistic evidence involves understanding the underlying mechanisms or processes that explain how and why a particular outcome occurs.
    /// </summary>
    Mechanistic,
    /// <summary>
    /// Parallel evidence (also known as Analogous evidence) involves comparing similar cases or situations to draw conclusions based on observed patterns or relationships.
    /// </summary>
    Parallel,
    /// <summary>
    /// Circumstantial evidence refers to information that indirectly supports a conclusion by suggesting a connection or correlation, often requiring inference to establish its relevance.
    /// </summary>
    Circumstantial,
    /// <summary>
    /// Inferential evidence involves drawing conclusions based on reasoning and logical deduction from available data or observations.
    /// </summary>
    Inferential
}
