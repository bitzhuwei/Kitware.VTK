using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolygonalSurfacePointPlacer : vtkPolyDataPointPlacer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfacePointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkPolygonalSurfacePointPlacer()
		{
			vtkPolygonalSurfacePointPlacer.MRClassNameKey = "class vtkPolygonalSurfacePointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalSurfacePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfacePointPlacer"));
		}

		public vtkPolygonalSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalSurfacePointPlacer New()
		{
			vtkPolygonalSurfacePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolygonalSurfacePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalSurfacePointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		public override void AddProp(vtkProp arg0)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetCellPicker_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCellPicker GetCellPicker()
		{
			vtkCellPicker vtkCellPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetCellPicker_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellPicker = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellPicker.Register(null);
				}
			}
			return vtkCellPicker;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(HandleRef pThis);

		public virtual double GetDistanceOffset()
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetPolys_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataCollection GetPolys()
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetPolys_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolygonalSurfacePointPlacer NewInstance()
		{
			vtkPolygonalSurfacePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalSurfacePointPlacer_RemoveAllProps_11(HandleRef pThis);

		public override void RemoveAllProps()
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_RemoveAllProps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalSurfacePointPlacer_RemoveViewProp_12(HandleRef pThis, HandleRef prop);

		public override void RemoveViewProp(vtkProp prop)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_RemoveViewProp_12(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalSurfacePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalSurfacePointPlacer vtkPolygonalSurfacePointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalSurfacePointPlacer = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalSurfacePointPlacer.Register(null);
				}
			}
			return vtkPolygonalSurfacePointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalSurfacePointPlacer_SetDistanceOffset_14(HandleRef pThis, double _arg);

		public virtual void SetDistanceOffset(double _arg)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SetDistanceOffset_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_15(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_16(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_16(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_17(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
