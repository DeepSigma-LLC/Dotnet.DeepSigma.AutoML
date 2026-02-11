
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of neuron cell used in a recurrent neural network (RNN) architecture, which can include gated recurrent units (GRUs) and long short-term memory (LSTM) cells that are designed to capture long-term dependencies and mitigate the vanishing gradient problem in sequential data processing tasks such as natural language processing, time series analysis, and speech recognition.
/// </summary>
public enum DeepLearningCellType
{
    /// <summary>
    /// A simple recurrent cell that processes sequential data by maintaining a hidden state that is updated at each time step based on the current input and the previous hidden state.
    /// </summary>
    GatedRecurrentUnit,
    /// <summary>
    /// A more complex recurrent cell that includes additional gates to control the flow of information and mitigate the vanishing gradient problem, allowing it to capture long-term dependencies in sequential data.
    /// </summary>
    LongShortTermMemoryCell,
}
