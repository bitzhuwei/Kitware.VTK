using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClosedSurfacePointPlacer : vtkPointPlacer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClosedSurfacePointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkClosedSurfacePointPlacer()
		{
			vtkClosedSurfacePointPlacer.MRClassNameKey = "class vtkClosedSurfacePointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClosedSurfacePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosedSurfacePointPlacer"));
		}

		public vtkClosedSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClosedSurfacePointPlacer New()
		{
			vtkClosedSurfacePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClosedSurfacePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistance_05(HandleRef pThis);

		public virtual double GetMinimumDistance()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistance_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(HandleRef pThis);

		public virtual double GetMinimumDistanceMaxValue()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(HandleRef pThis);

		public virtual double GetMinimumDistanceMinValue()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClosedSurfacePointPlacer NewInstance()
		{
			vtkClosedSurfacePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_12(HandleRef pThis);

		public void RemoveAllBoundingPlanes()
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_RemoveBoundingPlane_13(HandleRef pThis, HandleRef plane);

		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_RemoveBoundingPlane_13(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClosedSurfacePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkClosedSurfacePointPlacer vtkClosedSurfacePointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClosedSurfacePointPlacer = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClosedSurfacePointPlacer.Register(null);
				}
			}
			return vtkClosedSurfacePointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetBoundingPlanes_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_16(HandleRef pThis, HandleRef planes);

		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetBoundingPlanes_16(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkClosedSurfacePointPlacer_SetMinimumDistance_17(HandleRef pThis, double _arg);

		public virtual void SetMinimumDistance(double _arg)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetMinimumDistance_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_18(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ValidateWorldPosition_18(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_19(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ValidateWorldPosition_19(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
