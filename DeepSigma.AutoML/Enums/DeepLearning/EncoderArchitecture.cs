
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of encoder architecture used in a deep learning model, which can include autoencoders, encoder-only architectures, and decoder-only architectures that are designed to learn compact and informative representations of input data for various applications such as dimensionality reduction, feature extraction, and generative modeling.
/// </summary>
public enum EncoderArchitecture
{
    /// <summary>
    /// An autoencoder is a type of neural network architecture that consists of an encoder and a decoder. 
    /// The encoder compresses the input data into a lower-dimensional representation (latent space), while the decoder reconstructs the original data from this compressed representation.
    /// Autoencoders are commonly used for tasks such as dimensionality reduction, anomaly detection, and unsupervised learning, as they can learn efficient representations of the input data without requiring labeled examples.
    /// </summary>
    /// <remarks> 
    /// Also known as "bottleneck" architecture, where the encoder compresses the input data into a lower-dimensional representation (latent space) and the decoder reconstructs the original data from this compressed representation.
    /// An example of an autoencoder architecture is a convolutional autoencoder, which uses convolutional layers in both the encoder and decoder to learn spatial hierarchies of features from the input data, making it particularly effective for tasks such as image reconstruction and denoising.
    /// Additionally, a sequence-to-sequence autoencoder is a type of autoencoder architecture that is designed to process sequential data, such as time series or natural language, where the encoder and decoder are typically implemented using recurrent neural networks (RNNs) or transformer architectures to capture temporal dependencies and patterns in the data.
    /// The encoder architecture of an autoencoder can be designed to learn a compact and informative representation of the input data, which can be used for various downstream tasks such as classification, regression, or generative modeling, depending on the specific application and requirements of the problem at hand.
    /// </remarks>
    AutoEncoder,
    /// <summary>
    /// A transformer encoder is a type of neural network architecture that is based on the transformer model, which was originally designed for natural language processing tasks.
    /// Encoder-only architectures are commonly used for tasks such as feature extraction, language modeling, text classification, and other natural language processing tasks, where the goal is to learn a compact and informative representation of the input data that can be used for downstream tasks such as classification or regression.
    /// </summary>
    EncoderOnly,
    /// <summary>
    /// A decoder-only architecture is a type of neural network architecture that consists of only a decoder, without an encoder component.
    /// Decoder-only architectures can be used for tasks such as text generation, image generation, and other generative modeling tasks, where the model learns to generate new data based on patterns and relationships in the training data, without the need for an explicit encoding step.
    /// </summary>
    DecoderOnly,
}
