
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies whether a model parameter is a hyperparameter or a regular parameter.
/// </summary>
public enum ParameterType
{
    /// <summary>
    /// Indicates that the model parameter is a hyperparameter, which is set before the learning process begins and controls the learning algorithm's behavior.
    /// </summary>
    Hyperparameter,
    /// <summary>
    /// Indicates that the model parameter is a regular parameter, which is learned from the training data during the learning process.
    /// </summary>
    Parameter
}
