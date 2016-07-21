using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPolyDataSourceWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSourceWidget";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataSourceWidget()
		{
			vtkPolyDataSourceWidget.MRClassNameKey = "class vtkPolyDataSourceWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataSourceWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSourceWidget"));
		}

		public vtkPolyDataSourceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSourceWidget_GetPolyDataAlgorithm_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_GetPolyDataAlgorithm_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSourceWidget_GetPolyDataSource_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataSource GetPolyDataSource()
		{
			vtkPolyDataSource vtkPolyDataSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_GetPolyDataSource_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataSource = (vtkPolyDataSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataSource.Register(null);
				}
			}
			return vtkPolyDataSource;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataSourceWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataSourceWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSourceWidget_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataSourceWidget NewInstance()
		{
			vtkPolyDataSourceWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_06(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_07(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_07(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_08(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_08(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSourceWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataSourceWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataSourceWidget vtkPolyDataSourceWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataSourceWidget = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataSourceWidget.Register(null);
				}
			}
			return vtkPolyDataSourceWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataSourceWidget_UpdatePlacement_10(HandleRef pThis);

		public virtual void UpdatePlacement()
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_UpdatePlacement_10(base.GetCppThis());
		}
	}
}
