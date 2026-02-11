
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of deep learning network architecture, which can include feedforward, convolutional, recurrent, and other types of neural networks that are designed to learn complex patterns and relationships in data for various applications such as image recognition, natural language processing, and time series analysis.
/// </summary>
public enum DeepLearningNetworkType
{
    /// <summary>
    /// A feedforward neural network is a type of artificial neural network where the connections between the nodes do not form a cycle. In this architecture, information flows in one direction, from the input layer through one or more hidden layers to the output layer. Each layer consists of neurons that apply an activation function to the weighted sum of their inputs, allowing the network to learn complex patterns and relationships in the data. Feedforward neural networks are commonly used for tasks such as classification and regression.
    /// </summary>
    FeedForward,
    /// <summary>
    /// A convolutional neural network (CNN) is a type of deep learning architecture that is particularly effective for processing grid-like data, such as images. 
    /// CNNs use convolutional layers to automatically learn spatial hierarchies of features from the input data, allowing them to capture local patterns and structures. 
    /// This makes CNNs well-suited for tasks like image recognition, object detection, and other computer vision applications.
    /// </summary>
    /// <remarks>
    /// A convolution means applying a filter (or kernel or matrix) to the input data matrix to produce a new matrix of features. 
    /// The filter is typically smaller than the input data and is designed to capture specific patterns or features in the data, such as edges, textures, or shapes.
    /// </remarks>
    Convolutional,
    /// <summary>
    /// Casual Convolutional Neural Networks (Causal CNNs) are a type of convolutional neural network designed for processing sequential data, such as time series or natural language.
    /// It is called "causal" because it ensures that the output at any time step is only influenced by the current and previous time steps, preventing any future information from being used in the predictions.
    /// </summary>
    /// <remarks>
    /// Causal convolutions have had success in various applications, such as time series forecasting, natural language processing, and audio processing.
    /// </remarks>
    CasualConvolutional,
    /// <summary>
    /// A recurrent neural network (RNN) is a type of deep learning architecture that is designed to process sequential data, where the connections between neurons form a directed cycle.
    /// </summary>
    Recurrent,

}
