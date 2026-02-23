
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of deep learning network architecture, which can include feedforward, convolutional, recurrent, and other types of neural networks that are designed to learn complex patterns and relationships in data for various applications such as image recognition, natural language processing, and time series analysis.
/// </summary>
public enum DeepLearningNetworkType
{
    /// <summary>
    /// A feedforward neural network is a type of artificial neural network where the connections between the nodes do not form a cycle. 
    /// In this architecture, information flows in one direction, from the input layer through one or more hidden layers to the output layer. 
    /// Each layer consists of neurons that apply an activation function to the weighted sum of their inputs, allowing the network to learn complex patterns and relationships in the data. 
    /// Feedforward neural networks are commonly used for tasks such as classification and regression.
    /// Aka Artificial Neural Network (ANN) or Multilayer Perceptron (MLP).
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
    /// <summary>
    /// Long Short-Term Memory (LSTM) networks are a type of recurrent neural network (RNN) architecture that is designed to capture long-term dependencies in sequential data, addressing the vanishing gradient problem that can occur in traditional RNNs.
    /// </summary>
    LSTM,
    /// <summary>
    /// A Deep Belief Network (DBN) is a type of deep learning architecture that consists of multiple layers of stochastic, latent variables, where each layer is trained as a Restricted Boltzmann Machine (RBM) in an unsupervised manner.
    /// </summary>
    DeepBeliefNetwork,
    /// <summary>
    /// A Radial Basis Function Network (RBFN) is a type of artificial neural network that uses radial basis functions as activation functions.
    /// RBFNs are typically used for function approximation, regression, and classification tasks, where the network learns to approximate a target function by combining the outputs of radial basis functions centered at different points in the input space.
    /// Similar to KNN is a sense, RBFNs can be used for classification tasks by assigning class labels based on the output of the radial basis functions, where the class label is determined by the closest radial basis function to the input data point.
    /// </summary>
    RadialBasisFunctionNetwork,
    /// <summary>
    /// A Self-Organizing Map (SOM) is a type of unsupervised learning algorithm that is used for dimensionality reduction and clustering tasks.
    /// SOMs consist of a grid of neurons that are trained to represent the input data in a lower-dimensional space, where similar data points are mapped to nearby neurons on the grid.
    /// SOMs are particularly useful for visualizing high-dimensional data and discovering underlying patterns and structures in the data, making them a powerful tool for exploratory data analysis and clustering tasks.
    /// </summary>
    SelfOrganizingMap,
}
