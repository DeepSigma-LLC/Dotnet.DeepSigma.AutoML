using DeepSigma.AutoML.Enums.MachineLearning;

namespace DeepSigma.AutoML.Models;

/// <summary>
/// Represents a machine learning model.
/// </summary>
public class MachineLearningModel : Model
{
    /// <summary>
    /// Gets or sets the type of learning for the machine learning model.
    /// </summary>
    public LearningApproach LearningType {get;set;}
}
