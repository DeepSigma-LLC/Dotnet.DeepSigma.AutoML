namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the observability type of a variable.
/// </summary>
public enum VariableObservabilityType
{
    /// <summary>
    /// The variable is directly observable or measurable.
    /// </summary>
    Observable,
    /// <summary>
    /// The variable is not directly observable and must be inferred from other data.
    /// </summary>
    Latent
}
