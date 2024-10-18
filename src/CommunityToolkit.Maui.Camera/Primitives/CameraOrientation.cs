namespace CommunityToolkit.Maui.Primitives;

/// <summary>
/// Enumeration values of the possible rotation orientations supported by the camera.
/// </summary>
public enum CameraOrientation
{
	/// <summary>
	/// Camera Orientation is unknown or not yet set.
	/// </summary>
	Unknown,

	/// <summary>
	/// Camera Orientation is Portrait or the typical orientation a user holds the phone/camera.
	/// </summary>
	Portrait,

	/// <summary>
	/// Camera Orientation is upside down from Portrait.
	/// </summary>
	Landscape,

	/// <summary>
	/// Camera Orientation is Portrait or the typical orientation a user holds the phone/camera.
	/// </summary>
	ReversePortrait,

	/// <summary>
	/// Camera Orientation is reverse landscape or 180 degrees from Landscape.
	/// </summary>
	ReverseLandscape
}
