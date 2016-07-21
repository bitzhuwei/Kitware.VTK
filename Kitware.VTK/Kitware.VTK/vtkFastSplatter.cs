using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFastSplatter : vtkImageAlgorithm
	{
		public enum ClampLimit_WrapperEnum
		{
			ClampLimit = 1,
			FreezeScaleLimit = 3,
			NoneLimit = 0,
			ScaleLimit = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkFastSplatter";

		public new static readonly string MRClassNameKey;

		static vtkFastSplatter()
		{
			vtkFastSplatter.MRClassNameKey = "class vtkFastSplatter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFastSplatter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFastSplatter"));
		}

		public vtkFastSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkFastSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFastSplatter New()
		{
			vtkFastSplatter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFastSplatter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFastSplatter.vtkFastSplatter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkFastSplatter_GetLimitMode_01(HandleRef pThis);

		public virtual int GetLimitMode()
		{
			return vtkFastSplatter.vtkFastSplatter_GetLimitMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkFastSplatter_GetMaxValue_02(HandleRef pThis);

		public virtual double GetMaxValue()
		{
			return vtkFastSplatter.vtkFastSplatter_GetMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkFastSplatter_GetMinValue_03(HandleRef pThis);

		public virtual double GetMinValue()
		{
			return vtkFastSplatter.vtkFastSplatter_GetMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkFastSplatter_GetModelBounds_04(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_GetModelBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_GetModelBounds_05(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkFastSplatter.vtkFastSplatter_GetModelBounds_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkFastSplatter_GetNumberOfPointsSplatted_06(HandleRef pThis);

		public virtual int GetNumberOfPointsSplatted()
		{
			return vtkFastSplatter.vtkFastSplatter_GetNumberOfPointsSplatted_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkFastSplatter_GetOutputDimensions_07(HandleRef pThis);

		public virtual int[] GetOutputDimensions()
		{
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_GetOutputDimensions_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetOutputDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_GetOutputDimensions_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputDimensions(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkFastSplatter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkFastSplatter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkFastSplatter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFastSplatter NewInstance()
		{
			vtkFastSplatter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkFastSplatter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFastSplatter SafeDownCast(vtkObjectBase o)
		{
			vtkFastSplatter vtkFastSplatter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFastSplatter = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFastSplatter.Register(null);
				}
			}
			return vtkFastSplatter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetLimitMode_15(HandleRef pThis, int _arg);

		public virtual void SetLimitMode(int _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitMode_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetLimitModeToClamp_16(HandleRef pThis);

		public void SetLimitModeToClamp()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToClamp_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetLimitModeToFreezeScale_17(HandleRef pThis);

		public void SetLimitModeToFreezeScale()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToFreezeScale_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetLimitModeToNone_18(HandleRef pThis);

		public void SetLimitModeToNone()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToNone_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetLimitModeToScale_19(HandleRef pThis);

		public void SetLimitModeToScale()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToScale_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetMaxValue_20(HandleRef pThis, double _arg);

		public virtual void SetMaxValue(double _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetMaxValue_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetMinValue_21(HandleRef pThis, double _arg);

		public virtual void SetMinValue(double _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetMinValue_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetModelBounds_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkFastSplatter.vtkFastSplatter_SetModelBounds_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetModelBounds_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetModelBounds_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetOutputDimensions_24(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetOutputDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkFastSplatter.vtkFastSplatter_SetOutputDimensions_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetOutputDimensions_25(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputDimensions(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetOutputDimensions_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkFastSplatter_SetSplatConnection_26(HandleRef pThis, HandleRef arg0);

		public void SetSplatConnection(vtkAlgorithmOutput arg0)
		{
			vtkFastSplatter.vtkFastSplatter_SetSplatConnection_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
