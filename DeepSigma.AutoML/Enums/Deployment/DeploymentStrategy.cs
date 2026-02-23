

namespace DeepSigma.AutoML.Enums.Deployment;

/// <summary>
/// DeploymentStrategy specifies the various strategies for deploying software applications, including Shadow Deployment, AB Testing Deployment, Canary Deployment, and Blue-Green Deployment, each offering different approaches to minimize risks and ensure smooth transitions during software updates and releases.
/// </summary>
public enum DeploymentStrategy
{
    /// <summary>
    /// Shadow Deployment is a deployment strategy where a new version of an application is deployed alongside the existing version, allowing it to receive real user traffic without affecting the production environment. 
    /// This approach enables testing and validation of the new version in a live environment while minimizing risks, as any issues can be quickly identified and addressed without impacting end-users.
    /// </summary>
    ShadowDeployment,
    /// <summary>
    /// AB Testing Deployment is a deployment strategy that involves deploying two or more versions of an application simultaneously to different segments of users, allowing for comparison of their performance and user experience. 
    /// This approach enables data-driven decision-making by analyzing user interactions and feedback to determine which version performs better, ultimately guiding future development and optimization efforts.
    /// </summary>
    ABTestingDeployment,
    /// <summary>
    /// Canary Deployment is a deployment strategy where a new version of an application is gradually rolled out to a small subset of users before being fully deployed to the entire user base.
    /// This approach allows for monitoring the new version's performance and user experience in a controlled manner, enabling early detection of issues and minimizing the impact on end-users if any problems arise.
    /// The name "canary deployment" is derived from the practice of using canaries in coal mines to detect toxic gases, as the canary would show signs of distress before the miners, providing an early warning system.
    /// </summary>
    CanaryDeployment,
    /// <summary>
    /// Blue-Green Deployment is a deployment strategy that involves maintaining two separate environments, one for the current production version (blue) and another for the new version (green).
    /// The new version is deployed to the green environment and thoroughly tested before switching user traffic from the blue environment to the green environment.
    /// This approach allows for seamless transitions between versions, minimizing downtime and providing a quick rollback option if any issues arise with the new version, as the blue environment can be quickly reinstated as the production environment if needed.
    /// </summary>
    BlueGreenDeployment,

}
