
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of layer used in a deep learning model.
/// </summary>
public enum DeepLearningLayerType
{
    /// <summary>
    /// A fully connected (dense) layer where each neuron is connected to every neuron in the previous layer.
    /// </summary>
    Dense,
    /// <summary>
    /// A layer with sparse connections, where each neuron is connected to only a subset of neurons in the previous layer.
    /// </summary>
    Sparse,
    /// <summary>
    /// A layer that applies convolution operations, typically used for processing grid-like data such as images.
    /// </summary>
    Convolutional,
    /// <summary>
    /// A layer designed for processing sequential data, where connections between neurons form a directed cycle.
    /// </summary>
    Recurrent,
    /// <summary>
    /// A layer that uses Long Short-Term Memory (LSTM) units for processing sequential data, capable of learning long-term dependencies.
    /// </summary>
    LSTM,
    /// <summary>
    /// A layer that uses Gated Recurrent Units (GRUs) for processing sequential data, providing a simpler alternative to LSTM layers.
    /// </summary>
    GRU,
    /// <summary>
    /// A layer that randomly sets a fraction of input units to zero during training to prevent overfitting.
    /// </summary>
    Dropout,
    /// <summary>
    /// A layer that normalizes the inputs of a previous layer to improve training speed and stability.
    /// </summary>
    BatchNormalization,
    /// <summary>
    /// A layer that applies an activation function to introduce non-linearity into the model.
    /// </summary>
    Activation,
    /// <summary>
    /// A layer that flattens the input, converting multi-dimensional data into a one-dimensional array.
    /// </summary>
    Flatten,
    /// <summary>
    /// A layer that reduces the spatial dimensions of the input using pooling operations.
    /// </summary>
    MaxPooling,
    /// <summary>
    /// A layer that reduces the spatial dimensions of the input using average pooling operations.
    /// </summary>
    AveragePooling,
    /// <summary>
    /// A layer that adds padding to the input data.
    /// </summary>
    Padding,
    /// <summary>
    /// A layer that generates embeddings, transforming categorical data into dense vector representations.
    /// </summary>
    Embedding,
    /// <summary>
    /// A layer that implements the attention mechanism, allowing the model to focus on specific parts of the input data.
    /// </summary>
    Attention,
    /// <summary>
    /// A layer that utilizes transformer architecture, commonly used in natural language processing tasks.
    /// </summary>
    Transformer,
    /// <summary>
    /// A layer that shuffles the input data to improve model generalization.
    /// </summary>
    Shuffle,
    /// <summary>
    /// A layer specialized for computer vision tasks.
    /// </summary>
    Vision,
}
