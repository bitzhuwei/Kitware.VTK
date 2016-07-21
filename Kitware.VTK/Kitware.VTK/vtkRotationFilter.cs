using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRotationFilter : vtkUnstructuredGridAlgorithm
	{
		public enum RotationAxis
		{
			USE_X,
			USE_Y,
			USE_Z
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkRotationFilter";

		public new static readonly string MRClassNameKey;

		static vtkRotationFilter()
		{
			vtkRotationFilter.MRClassNameKey = "class vtkRotationFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRotationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRotationFilter"));
		}

		public vtkRotationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRotationFilter New()
		{
			vtkRotationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRotationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRotationFilter.vtkRotationFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_CopyInputOff_01(HandleRef pThis);

		public virtual void CopyInputOff()
		{
			vtkRotationFilter.vtkRotationFilter_CopyInputOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_CopyInputOn_02(HandleRef pThis);

		public virtual void CopyInputOn()
		{
			vtkRotationFilter.vtkRotationFilter_CopyInputOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRotationFilter_GetAngle_03(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAngle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_GetAxis_04(HandleRef pThis);

		public virtual int GetAxis()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxis_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_GetAxisMaxValue_05(HandleRef pThis);

		public virtual int GetAxisMaxValue()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxisMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_GetAxisMinValue_06(HandleRef pThis);

		public virtual int GetAxisMinValue()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxisMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationFilter_GetCenter_07(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_GetCenter_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_GetCenter_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRotationFilter.vtkRotationFilter_GetCenter_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_GetCenter_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenter(IntPtr _arg)
		{
			vtkRotationFilter.vtkRotationFilter_GetCenter_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_GetCopyInput_10(HandleRef pThis);

		public virtual int GetCopyInput()
		{
			return vtkRotationFilter.vtkRotationFilter_GetCopyInput_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_GetNumberOfCopies_11(HandleRef pThis);

		public virtual int GetNumberOfCopies()
		{
			return vtkRotationFilter.vtkRotationFilter_GetNumberOfCopies_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationFilter_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRotationFilter NewInstance()
		{
			vtkRotationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationFilter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRotationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRotationFilter vtkRotationFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRotationFilter = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRotationFilter.Register(null);
				}
			}
			return vtkRotationFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetAngle_17(HandleRef pThis, double _arg);

		public virtual void SetAngle(double _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetAngle_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetAxis_18(HandleRef pThis, int _arg);

		public virtual void SetAxis(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetAxis_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetAxisToX_19(HandleRef pThis);

		public void SetAxisToX()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToX_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetAxisToY_20(HandleRef pThis);

		public void SetAxisToY()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToY_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetAxisToZ_21(HandleRef pThis);

		public void SetAxisToZ()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToZ_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetCenter_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRotationFilter.vtkRotationFilter_SetCenter_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetCenter_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetCenter_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetCopyInput_24(HandleRef pThis, int _arg);

		public virtual void SetCopyInput(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetCopyInput_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationFilter_SetNumberOfCopies_25(HandleRef pThis, int _arg);

		public virtual void SetNumberOfCopies(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetNumberOfCopies_25(base.GetCppThis(), _arg);
		}
	}
}
