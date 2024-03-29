﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpatialLite.Core.API {
	/// <summary>
	/// Defines common properties and methods for all geometry objects.
	/// </summary>
	public interface IGeometry {
		/// <summary>
		/// Gets the Srid of the Coordinate Reference System used by the <c>IGeometry</c> object.
		/// </summary>
		int Srid { get; }

		/// <summary>
		/// Gets a value indicating whether the <c>IGeometry</c> object has Z coordinates.
		/// </summary>
		bool Is3D { get; }

		/// <summary>
		/// Gets a value indicating whether the <c>IGeometry</c> object has M values.
		/// </summary>
		bool IsMeasured { get; }
		
		/// <summary>
		/// Computes envelope of the <c>IGeometry</c> object. The envelope is defined as a minimal bounding box for a geometry.
		/// </summary>
		/// <returns>
		/// Returns an <see cref="Envelope"/> object that specifies the minimal bounding box of the <c>IGeometry</c> object.
		/// </returns>
		Envelope GetEnvelope();

		/// <summary>
		/// Returns  the  closure  of  the  combinatorial  boundary  of  this  geometric  object
		/// </summary>
		/// <returns> the  closure  of  the  combinatorial  boundary  of  this  geometric  object</returns>
		IGeometry GetBoundary();
	}
}
