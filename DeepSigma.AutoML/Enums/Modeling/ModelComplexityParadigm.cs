namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Model complexity paradigms refer to the different ways in which the relationship between model complexity and generalization performance can be understood and characterized in machine learning, particularly in the context of deep learning models.
/// </summary>
public enum ModelComplexityParadigm
{
    /// <summary>
    /// The single descent paradigm refers to the traditional understanding of the relationship between model complexity and generalization performance in machine learning.
    /// In this paradigm, as the complexity of a model increases, its performance on the training data improves, but its performance on unseen data (generalization) initially improves and then deteriorates, leading to a U-shaped curve when plotting generalization error against model complexity.
    /// </summary>
    SingleDescent,
    /// <summary>
    /// The double descent paradigm is a more recent understanding of the relationship between model complexity and generalization performance, which challenges the traditional single descent paradigm.
    /// In the double descent paradigm, as the complexity of a model increases, its performance on the training data improves, but its performance on unseen data (generalization) initially improves, then deteriorates (similar to the single descent), and then improves again as the model becomes even more complex.
    /// </summary>
    DoubleDescent,
}
