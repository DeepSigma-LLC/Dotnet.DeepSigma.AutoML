namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the memory length type of a model, indicating whether it utilizes short-term or long-term memory for processing and learning from data.
/// </summary>
public enum ModelMemoryLengthType
{
    /// <summary>
    /// MemorylessModel refers to models that do not utilize any form of memory, relying solely on the current input data for making predictions or decisions without considering past information.
    /// </summary>
    /// <remarks>
    /// An example of a MemorylessModel is a hidden Markov model, which makes predictions based only on the current state without retaining any history of previous states.
    /// </remarks>
    MemorylessModel,
    /// <summary>
    /// ShortMemoryModel refers to models that primarily utilize short-term memory, focusing on recent data points and patterns for making predictions or decisions.
    /// </summary>
    ShortMemoryModel,
    /// <summary>
    /// LongMemoryModel refers to models that leverage long-term memory, allowing them to capture and utilize patterns and dependencies over extended periods of time for improved forecasting and analysis.
    /// </summary>
    LongMemoryModel,
    /// <summary>
    /// LongShortTermMemoryModel refers to models that combine both short-term and long-term memory capabilities, enabling them to effectively learn from recent data while also retaining important information from the past for more accurate predictions and decision-making.
    /// </summary>
    LongShortTermMemoryModel,
}
