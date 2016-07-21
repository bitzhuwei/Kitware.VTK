using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoundedPlanePointPlacer : vtkPointPlacer
	{
		public enum Oblique_WrapperEnum
		{
			Oblique = 3,
			XAxis = 0,
			YAxis,
			ZAxis
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBoundedPlanePointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkBoundedPlanePointPlacer()
		{
			vtkBoundedPlanePointPlacer.MRClassNameKey = "class vtkBoundedPlanePointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoundedPlanePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundedPlanePointPlacer"));
		}

		public vtkBoundedPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoundedPlanePointPlacer New()
		{
			vtkBoundedPlanePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoundedPlanePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormal_05(HandleRef pThis);

		public virtual int GetProjectionNormal()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_06(HandleRef pThis);

		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_07(HandleRef pThis);

		public virtual int GetProjectionNormalMinValue()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBoundedPlanePointPlacer_GetProjectionPosition_08(HandleRef pThis);

		public virtual double GetProjectionPosition()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionPosition_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoundedPlanePointPlacer NewInstance()
		{
			vtkBoundedPlanePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_13(HandleRef pThis);

		public void RemoveAllBoundingPlanes()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_RemoveBoundingPlane_14(HandleRef pThis, HandleRef plane);

		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_RemoveBoundingPlane_14(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoundedPlanePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkBoundedPlanePointPlacer vtkBoundedPlanePointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoundedPlanePointPlacer = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoundedPlanePointPlacer.Register(null);
				}
			}
			return vtkBoundedPlanePointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetBoundingPlanes_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_17(HandleRef pThis, HandleRef planes);

		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetBoundingPlanes_17(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetObliquePlane_18(HandleRef pThis, HandleRef arg0);

		public void SetObliquePlane(vtkPlane arg0)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetObliquePlane_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormal_19(HandleRef pThis, int _arg);

		public virtual void SetProjectionNormal(int _arg)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormal_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_20(HandleRef pThis);

		public void SetProjectionNormalToOblique()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_21(HandleRef pThis);

		public void SetProjectionNormalToXAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_22(HandleRef pThis);

		public void SetProjectionNormalToYAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_23(HandleRef pThis);

		public void SetProjectionNormalToZAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionPosition_24(HandleRef pThis, double position);

		public void SetProjectionPosition(double position)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionPosition_24(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_UpdateWorldPosition_25(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

		public override int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_UpdateWorldPosition_25(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_26(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ValidateWorldPosition_26(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_27(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ValidateWorldPosition_27(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
