
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// ModelMemory is an enumeration that defines the memory type of a machine learning model, indicating whether it maintains an internal state that can be updated over time based on new inputs or interactions (Stateful) or if it generates outputs solely based on the current input without any influence from previous interactions or inputs (Stateless).
/// </summary>
public enum ModelMemory
{
    /// <summary>
    /// Stateful models maintain an internal state that can be updated over time based on new inputs or interactions.
    /// </summary>
    Stateful,
    /// <summary>
    /// Stateless models do not maintain any internal state and generate outputs solely based on the current input, without any influence from previous interactions or inputs.
    /// </summary>
    Stateless
}
