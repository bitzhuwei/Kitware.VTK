using Kitware.mummy.Runtime;
using System;

namespace Kitware.VTK
{
	public class WrappedObject : Kitware.mummy.Runtime.WrappedObject
	{
		public const string vtkChartsEL_dll = "Kitware.VTK.vtkCharts.Unmanaged.dll";

		public const string vtkCommonEL_dll = "Kitware.VTK.vtkCommon.Unmanaged.dll";

		public const string vtkFilteringEL_dll = "Kitware.VTK.vtkFiltering.Unmanaged.dll";

		public const string vtkGenericFilteringEL_dll = "Kitware.VTK.vtkGenericFiltering.Unmanaged.dll";

		public const string vtkGeovisEL_dll = "Kitware.VTK.vtkGeovis.Unmanaged.dll";

		public const string vtkGraphicsEL_dll = "Kitware.VTK.vtkGraphics.Unmanaged.dll";

		public const string vtkHybridEL_dll = "Kitware.VTK.vtkHybrid.Unmanaged.dll";

		public const string vtkIOEL_dll = "Kitware.VTK.vtkIO.Unmanaged.dll";

		public const string vtkImagingEL_dll = "Kitware.VTK.vtkImaging.Unmanaged.dll";

		public const string vtkInfovisEL_dll = "Kitware.VTK.vtkInfovis.Unmanaged.dll";

		public const string vtkParallelEL_dll = "Kitware.VTK.vtkParallel.Unmanaged.dll";

		public const string vtkRenderingEL_dll = "Kitware.VTK.vtkRendering.Unmanaged.dll";

		public const string vtkViewsEL_dll = "Kitware.VTK.vtkViews.Unmanaged.dll";

		public const string vtkVolumeRenderingEL_dll = "Kitware.VTK.vtkVolumeRendering.Unmanaged.dll";

		public const string vtkWidgetsEL_dll = "Kitware.VTK.vtkWidgets.Unmanaged.dll";

		protected WrappedObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}
	}
}
