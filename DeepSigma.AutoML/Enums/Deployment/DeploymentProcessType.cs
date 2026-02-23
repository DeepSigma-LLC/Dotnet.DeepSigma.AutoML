namespace DeepSigma.AutoML.Enums.Deployment;

/// <summary>
/// Specifies the types of deployment processes in software development, which include Continuous Integration, Continuous Deployment, Continuous Testing, and Continuous Monitoring, each playing a crucial role in ensuring efficient and reliable software delivery and maintenance.
/// </summary>
public enum DeploymentProcessType
{
    /// <summary>
    /// Continuous Integration refers to the practice of automatically integrating code changes from multiple contributors into a shared repository, allowing for early detection of integration issues and ensuring that the codebase remains in a deployable state.
    /// </summary>
    ContinuousIntegration,
    /// <summary>
    /// Continuous Delivery is the practice of automatically deploying code changes to production environments after passing automated tests and quality checks, enabling faster delivery of new features and bug fixes to end-users while maintaining high software quality and reliability.
    /// </summary>
    ContinuousDelivery,
    /// <summary>
    /// Continuous Testing is the practice of automatically executing tests on code changes as part of the software development process, allowing for early detection of defects and ensuring that the codebase remains stable and functional throughout the development lifecycle.
    /// </summary>
    ContinuousTesting,
    /// <summary>
    /// Continuous Monitoring is the practice of continuously monitoring the performance, availability, and security of software applications and infrastructure in production environments, allowing for proactive identification and resolution of issues to ensure optimal user experience and system reliability.
    /// </summary>
    ContinuousMonitoring,
}
