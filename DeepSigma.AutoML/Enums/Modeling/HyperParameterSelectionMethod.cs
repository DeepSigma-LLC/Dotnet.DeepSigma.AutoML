
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the method used for hyperparameter selection in machine learning models.
/// </summary>
public enum HyperParameterSelectionMethod
{
    /// <summary>
    /// No hyperparameter selection method specified.
    /// </summary>
    None,
    /// <summary>
    /// User defined hyperparameter selection.
    /// </summary>
    UserDefined,
    /// <summary>
    /// Heuristical search based on experience or rules of thumb.
    /// </summary>
    HeursiticalSearch,
    /// <summary>
    /// Exhaustive search over a specified parameter grid.
    /// </summary>
    GridSearch,
    /// <summary>
    /// Generally automated through mathematical or agorithmic methods.
    /// </summary>
    Automated,
    /// <summary>
    /// Blend of automated, mathematical, and/or heuristical search.
    /// </summary>
    AgenticSearch
}
