
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// ModelSequenceClassificationType is an enumeration that defines the different types of sequence classification tasks that a machine learning model can perform, particularly in the context of natural language processing (NLP) and other sequential data processing tasks.
/// </summary>
public enum ModelSequenceClassificationType
{
    /// <summary>
    /// SequenceToValue refers to a type of sequence classification task where the model takes a sequence of input data (such as text, time series, or any sequential data) and produces a single output value or label that represents the classification result for the entire sequence.
    /// Representation models that are designed to capture the overall meaning or context of the input sequence and produce a single output that summarizes the information contained in the sequence.
    /// </summary>
    SequenceToValue,
    /// <summary>
    /// SequenceToSequence refers to a type of sequence classification task where the model takes a sequence of input data and produces a sequence of output values or labels, where each output corresponds to a specific element in the input sequence.
    /// Generation models that are designed to capture the relationships between elements in the input sequence and produce a corresponding output sequence that reflects those relationships, often used in tasks such as machine translation, text summarization, or any task where the output is a sequence of values rather than a single value.
    /// </summary>
    SequenceToSequence
}
