using UnityEngine;
using System.Collections;

public static class MazeDirections {

	// Use this for initialization
	public const int Count = 4;

	public static MazeDirection RandomValue {
		get {
			return (MazeDirection)Random.Range(0, Count);
		}
	// Update is called once per frame
	}

	private static IntVector2[] vectors = {
		new IntVector2 (0,1),
		new IntVector2 (1,0),
		new IntVector2 (0, -1),
		new IntVector2 (-1, 0)
	};

	public static IntVector2 ToIntVector2 (this MazeDirection direction) {
		return vectors[(int)direction];
	}
}
