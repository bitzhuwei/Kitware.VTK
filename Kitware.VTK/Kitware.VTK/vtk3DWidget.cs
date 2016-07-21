using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtk3DWidget : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DWidget";

		public new static readonly string MRClassNameKey;

		static vtk3DWidget()
		{
			vtk3DWidget.MRClassNameKey = "class vtk3DWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DWidget"));
		}

		public vtk3DWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetHandleSize_01(HandleRef pThis);

		public virtual double GetHandleSize()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetHandleSizeMaxValue_02(HandleRef pThis);

		public virtual double GetHandleSizeMaxValue()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSizeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetHandleSizeMinValue_03(HandleRef pThis);

		public virtual double GetHandleSizeMinValue()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSizeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtk3DWidget_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetPlaceFactor_05(HandleRef pThis);

		public virtual double GetPlaceFactor()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactor_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetPlaceFactorMaxValue_06(HandleRef pThis);

		public virtual double GetPlaceFactorMaxValue()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactorMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtk3DWidget_GetPlaceFactorMinValue_07(HandleRef pThis);

		public virtual double GetPlaceFactorMinValue()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactorMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtk3DWidget_GetProp3D_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_GetProp3D_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtk3DWidget_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtk3DWidget.vtk3DWidget_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtk3DWidget_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtk3DWidget.vtk3DWidget_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtk3DWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtk3DWidget NewInstance()
		{
			vtk3DWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_PlaceWidget_12(HandleRef pThis, IntPtr bounds);

		public virtual void PlaceWidget(IntPtr bounds)
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_12(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_PlaceWidget_13(HandleRef pThis);

		public virtual void PlaceWidget()
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_PlaceWidget_14(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public virtual void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_14(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtk3DWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtk3DWidget SafeDownCast(vtkObjectBase o)
		{
			vtk3DWidget vtk3DWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DWidget = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DWidget.Register(null);
				}
			}
			return vtk3DWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_SetHandleSize_16(HandleRef pThis, double _arg);

		public virtual void SetHandleSize(double _arg)
		{
			vtk3DWidget.vtk3DWidget_SetHandleSize_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_SetInput_17(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataSet arg0)
		{
			vtk3DWidget.vtk3DWidget_SetInput_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_SetPlaceFactor_18(HandleRef pThis, double _arg);

		public virtual void SetPlaceFactor(double _arg)
		{
			vtk3DWidget.vtk3DWidget_SetPlaceFactor_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtk3DWidget_SetProp3D_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetProp3D(vtkProp3D arg0)
		{
			vtk3DWidget.vtk3DWidget_SetProp3D_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
