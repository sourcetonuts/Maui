using CommunityToolkit.Maui.Primitives;

namespace CommunityToolkit.Maui.Views;

/// <summary>
/// Event args containing information related to camera orientation changes.
/// </summary>
/// <param name="orientation">The <see cref="CameraOrientation"/> pointing to the newly captured media.</param>
public class OrientationChangedEventArgs(CameraOrientation orientation) : EventArgs
{
	/// <summary>
	/// Gets the <see cref="Stream"/> pointing to the newly captured media.
	/// </summary>
	public CameraOrientation CameraOrientation { get; } = orientation;
}
