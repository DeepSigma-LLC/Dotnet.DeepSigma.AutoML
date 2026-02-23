

namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// The three main types of generative AI models are Latent Variable Models, Adversarial Models, and Sequential Models.
/// </summary>
public enum GenerativeAIModelType
{
    /// <summary>
    /// Latent Variable Models are a class of generative models that learn to represent data in a lower-dimensional latent space, allowing them to generate new data samples by sampling from this latent space. 
    /// Examples include Variational Autoencoders (VAEs) and energy-based models (EBMs).
    /// </summary>
    LatentVariableModel,
    /// <summary>
    /// Adversarial Models, such as Generative Adversarial Networks (GANs), consist of two neural networks, a generator and a discriminator, that are trained together in a competitive process. 
    /// The generator creates synthetic data samples, while the discriminator evaluates their authenticity, leading to the generation of high-quality data that closely resembles the training data.
    /// </summary>
    AdversarialModel,
    /// <summary>
    /// Sequential Models, such as Recurrent Neural Networks (RNNs) and Transformers, are designed to generate data in a sequential manner, making them particularly effective for tasks involving time series data, natural language processing, and other applications where the order of data points is important.
    /// </summary>
    SequentialModel,
}
