
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// EncoderArchitectureType is an enumeration that defines different types of encoder architectures used in deep learning models, particularly in the context of natural language processing (NLP) and machine learning tasks, where the choice of encoder architecture can significantly impact the model's ability to learn and represent complex relationships in the input data, ultimately affecting its performance on various tasks such as classification, regression, and generative modeling.
/// </summary>
public enum EncoderArchitectureType
{
    /// <summary>
    /// An autoencoder is a type of neural network architecture that consists of an encoder and a decoder. 
    /// The encoder compresses the input data into a lower-dimensional representation (latent space), while the decoder reconstructs the original data from this compressed representation.
    /// </summary>
    AutoEncoder,
    /// <summary>
    /// A cross-encoder is a type of encoder architecture that processes two or more inputs simultaneously, allowing the model to learn interactions and relationships between the inputs, which can be particularly useful in tasks such as sentence similarity, information retrieval, and natural language understanding, where the goal is to capture the relationships between different pieces of data while maintaining their individual characteristics.
    /// However, cross-encoders can be computationally expensive and may not scale well to large datasets or long input sequences, as they require processing all inputs together, which can lead to increased memory usage and longer training times compared to other encoder architectures that process inputs independently.
    /// </summary>
    CrossEncoder,
    /// <summary>
    /// Bi-Encoder is a type of encoder architecture that consists of two separate encoders that process different inputs independently, allowing for the learning of distinct representations for each input, which can be particularly useful in tasks such as sentence similarity, information retrieval, and natural language understanding, where the goal is to capture the relationships between two different pieces of data while maintaining their individual characteristics.
    /// The performance of Bi-Encoders are usually not as good as cross-encoders, but they are much more computationally efficient and can scale better to larger datasets and longer input sequences, as they process each input independently, which can lead to reduced memory usage and faster training times compared to cross-encoders that require processing all inputs together.
    /// </summary>
    BiEncoder,
    
}
