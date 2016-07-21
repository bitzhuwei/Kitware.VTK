using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReflectionFilter : vtkDataObjectAlgorithm
	{
		public enum ReflectionPlane
		{
			USE_X = 6,
			USE_X_MAX = 3,
			USE_X_MIN = 0,
			USE_Y = 7,
			USE_Y_MAX = 4,
			USE_Y_MIN = 1,
			USE_Z = 8,
			USE_Z_MAX = 5,
			USE_Z_MIN = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkReflectionFilter";

		public new static readonly string MRClassNameKey;

		static vtkReflectionFilter()
		{
			vtkReflectionFilter.MRClassNameKey = "class vtkReflectionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReflectionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReflectionFilter"));
		}

		public vtkReflectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReflectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReflectionFilter New()
		{
			vtkReflectionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReflectionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReflectionFilter.vtkReflectionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_CopyInputOff_01(HandleRef pThis);

		public virtual void CopyInputOff()
		{
			vtkReflectionFilter.vtkReflectionFilter_CopyInputOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_CopyInputOn_02(HandleRef pThis);

		public virtual void CopyInputOn()
		{
			vtkReflectionFilter.vtkReflectionFilter_CopyInputOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkReflectionFilter_GetCenter_03(HandleRef pThis);

		public virtual double GetCenter()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetCenter_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_GetCopyInput_04(HandleRef pThis);

		public virtual int GetCopyInput()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetCopyInput_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_GetPlane_05(HandleRef pThis);

		public virtual int GetPlane()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlane_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_GetPlaneMaxValue_06(HandleRef pThis);

		public virtual int GetPlaneMaxValue()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlaneMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_GetPlaneMinValue_07(HandleRef pThis);

		public virtual int GetPlaneMinValue()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlaneMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReflectionFilter_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReflectionFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReflectionFilter NewInstance()
		{
			vtkReflectionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReflectionFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReflectionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkReflectionFilter vtkReflectionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReflectionFilter = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReflectionFilter.Register(null);
				}
			}
			return vtkReflectionFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetCenter_13(HandleRef pThis, double _arg);

		public virtual void SetCenter(double _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetCenter_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetCopyInput_14(HandleRef pThis, int _arg);

		public virtual void SetCopyInput(int _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetCopyInput_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlane_15(HandleRef pThis, int _arg);

		public virtual void SetPlane(int _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlane_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToX_16(HandleRef pThis);

		public void SetPlaneToX()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToX_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToXMax_17(HandleRef pThis);

		public void SetPlaneToXMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToXMax_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToXMin_18(HandleRef pThis);

		public void SetPlaneToXMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToXMin_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToY_19(HandleRef pThis);

		public void SetPlaneToY()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToY_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToYMax_20(HandleRef pThis);

		public void SetPlaneToYMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToYMax_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToYMin_21(HandleRef pThis);

		public void SetPlaneToYMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToYMin_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToZ_22(HandleRef pThis);

		public void SetPlaneToZ()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZ_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToZMax_23(HandleRef pThis);

		public void SetPlaneToZMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZMax_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReflectionFilter_SetPlaneToZMin_24(HandleRef pThis);

		public void SetPlaneToZMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZMin_24(base.GetCppThis());
		}
	}
}
