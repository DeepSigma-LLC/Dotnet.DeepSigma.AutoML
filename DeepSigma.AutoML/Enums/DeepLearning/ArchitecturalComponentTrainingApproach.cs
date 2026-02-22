
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Architectural component training approaches refer to the different strategies that can be used to train specific components of a deep learning model.
/// Components of a deep learning model can include layers, modules, or sub-networks that perform specific functions within the overall architecture.
/// </summary>
public enum ArchitecturalComponentTrainingApproach
{
    /// <summary>
    /// Sequential training involves training the components of a deep learning model one after the other, in a specific order.
    /// This approach can be useful when the components have dependencies on each other, as it allows for the model to learn and adapt to the outputs of the previous components during training. 
    /// However, it may also lead to longer training times and may not be suitable for all types of architectures, especially those with complex interactions between components.
    /// A downside of this approach is that components may not be able to fully leverage the information from other components during training, as they are trained in isolation.
    /// The components are not optimized together, which can lead to suboptimal performance if the components are not well-aligned or if there are interactions between them that are not captured during training.
    /// </summary>
    /// <remarks>
    /// Sequential training means that the first component is trained on the data, and then the second component is trained using the output of the first component, and so on.
    /// Training on the first component is done to completion before training on the second component begins. 
    /// This can lead to longer training times, as each component must be trained separately, and it may not be suitable for all types of architectures, especially those with complex interactions between components.
    /// </remarks>
    Sequential,
    /// <summary>
    /// Joint training, also known as end-to-end training, involves training all components of a deep learning model simultaneously, allowing them to learn and adapt together during the training process.
    /// This approach can be more efficient in terms of training time and can lead to better performance, as the components can leverage information from each other during training.
    /// However, it may also require more computational resources and may be more complex to implement, especially for architectures with a large number of components or complex interactions between them.
    /// </summary>
    Joint,
}
