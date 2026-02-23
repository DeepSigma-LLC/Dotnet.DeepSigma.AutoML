

namespace DeepSigma.AutoML.Enums.Evaluation;

/// <summary>
/// Specifies the metrics used to evaluate the performance of a classification model.
/// </summary>
public enum ClassificationMetric
{
    /// <summary>
    /// Accuracy is the proportion of correctly classified instances among the total number of instances, providing a general measure of a model's performance but may not be sufficient for imbalanced datasets where one class is more prevalent than others.
    /// Equation: Accuracy = (TP + TN) / (TP + TN + FP + FN), where TP is true positives, TN is true negatives, FP is false positives, and FN is false negatives.
    /// Said differently, (correct predictions) / (total predictions).
    /// </summary>
    Accuracy,
    /// <summary>
    /// Precision is the proportion of true positive predictions among all positive predictions made by the model, indicating how many of the predicted positive instances are actually correct, and is particularly important in scenarios where false positives are costly or undesirable.
    /// Equation: Precision = TP / (TP + FP), where TP is true positives and FP is false positives.
    /// Said differently, (correct positive predictions) / (total positive predictions).
    /// </summary>
    Precision,
    /// <summary>
    /// Specificity, also known as the true negative rate, is the proportion of true negative predictions among all actual negative instances, indicating how well the model identifies negative cases and is crucial in scenarios where false negatives are costly or undesirable.
    /// Equation: Specificity = TN / (TN + FP), where TN is true negatives and FP is false positives.
    /// Said differently, (correct negative predictions) / (total negative predictions).
    /// </summary>
    Specificity,
    /// <summary>
    /// Recall, also known as sensitivity or the true positive rate, is the proportion of true positive predictions among all actual positive instances, indicating how well the model identifies positive cases and is particularly important in scenarios where false negatives are costly or undesirable.
    /// Equation: Recall = TP / (TP + FN), where TP is true positives and FN is false negatives.
    /// Said differently, (correct positive predictions) / (total actual positives).
    /// </summary>
    Recall,
    /// <summary>
    /// F1 Score is the harmonic mean of precision and recall, providing a single metric that balances both precision and recall, and is particularly useful in scenarios where there is an imbalance between the positive and negative classes, as it takes into account both false positives and false negatives.
    /// The F1 Score ranges from 0 to 1, where a score of 1 indicates perfect precision and recall, while a score of 0 indicates the worst performance.
    /// The advantage of using the F1 Score is that it provides a more comprehensive evaluation of a model's performance, especially in cases where there is a trade-off between precision and recall, as it considers both metrics simultaneously and can help identify models that perform well in terms of both precision and recall, rather than just one or the other.
    /// Equation: F1 Score = 2 * (Precision * Recall) / (Precision + Recall), where Precision is TP / (TP + FP) and Recall is TP / (TP + FN).
    /// </summary>
    F1Score,
}
