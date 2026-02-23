
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// GenerativeModel is an enumeration that defines different types of generative models used in machine learning and artificial intelligence, where the choice of generative model can significantly impact the model's ability to learn and represent complex patterns in the data, ultimately affecting its performance on various tasks such as image generation, text generation, and other applications where the goal is to generate new data that closely resembles the training data while also allowing for some degree of variability and creativity in the generated samples.
/// </summary>
public enum GenerativeModel
{
    /// <summary>
    /// Generative Adversarial Networks (GANs) are a class of deep learning models that consist of two neural networks, a generator and a discriminator, that are trained simultaneously in a competitive manner.
    /// </summary>
    GenerativeAdversarialNetwork,
    /// <summary>
    /// Autoencoders are a type of neural network architecture that consists of an encoder and a decoder. 
    /// The encoder compresses the input data into a lower-dimensional representation (latent space), while the decoder reconstructs the original data from this compressed representation.
    /// </summary>
    AutoEncoder,
    /// <summary>
    /// Decoder-only architectures are a type of neural network architecture that consists of only a decoder, without an encoder component.
    /// Decoder-only architectures can be used for tasks such as text generation, image generation, and other generative modeling tasks, where the model learns to generate new data based on patterns and relationships in the training data, without the need for an explicit encoding step.
    /// </summary>
    DecoderOnly,
    /// <summary>
    /// Diffusion models are a class of generative models that learn to generate data by modeling the process of diffusion, where data is transformed through a series of steps that gradually add noise to the data and then reverse this process to generate new samples.
    /// Diffusion models have shown promise in generating high-quality images and other types of data, and they are particularly effective for tasks such as image synthesis, super-resolution, and other applications where the goal is to generate new data that closely resembles the training data while also allowing for some degree of variability and creativity in the generated samples.
    /// </summary>
    DiffusionModel,
    /// <summary>
    /// Transformer models are a type of deep learning architecture that is based on the transformer model, which was originally designed for natural language processing tasks.
    /// Transformer models have since been adapted for a wide range of applications, including image generation, music generation, and other generative modeling tasks, where the model learns to generate new data based on patterns and relationships in the training data, while also allowing for some degree of variability and creativity in the generated samples.
    /// </summary>
    Transformer,
    /// <summary>
    /// AutoRegressive models are a class of generative models that generate data sequentially, where each new data point is generated based on the previously generated data points.
    /// AutoRegressive models are commonly used for tasks such as language modeling, where the model learns to predict the next word in a sequence based on the previous words, and they can also be applied to other types of sequential data, such as time series or music generation, where the model learns to capture temporal dependencies and patterns in the data to generate new samples that closely resemble the training data while also allowing for some degree of variability and creativity in the generated samples.
    /// </summary>
    AutoRegressiveModel,
    /// <summary>
    /// Energy-Based Models (EBMs) are a class of generative models that learn to generate data by modeling the energy function of the data distribution, where the model learns to assign low energy to data points that are likely to be generated and high energy to data points that are unlikely to be generated, allowing it to generate new samples by sampling from the low-energy regions of the data distribution.
    /// EBMs have shown promise in generating high-quality images and other types of data, and they are particularly effective for tasks such as image synthesis, super-resolution, and other applications where the goal is to generate new data that closely resembles the training data while also allowing for some degree of variability and creativity in the generated samples.
    /// </summary>
    EnergyBasedModel,
    
}
