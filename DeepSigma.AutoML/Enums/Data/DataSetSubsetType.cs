namespace DeepSigma.AutoML.Enums.Data;

/// <summary>
/// Specifies the type of dataset subset.
/// </summary>
public enum DataSetSubsetType
{
    /// <summary>
    /// Training subset used to train the model.
    /// </summary>
    Training,
    /// <summary>
    /// Validation subset used to validate the model during training.
    /// </summary>
    Validation,
    /// <summary>
    /// Testing subset used to test the model after training.
    /// </summary>
    Testing
}
