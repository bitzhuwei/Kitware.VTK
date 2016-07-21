using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageGridSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGridSource";

		public new static readonly string MRClassNameKey;

		static vtkImageGridSource()
		{
			vtkImageGridSource.MRClassNameKey = "class vtkImageGridSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGridSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGridSource"));
		}

		public vtkImageGridSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGridSource New()
		{
			vtkImageGridSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageGridSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageGridSource.vtkImageGridSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetDataExtent_01(HandleRef pThis);

		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataExtent_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataExtent_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetDataOrigin_04(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataOrigin_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataOrigin_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataOrigin_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGridSource_GetDataScalarType_07(HandleRef pThis);

		public virtual int GetDataScalarType()
		{
			return vtkImageGridSource.vtkImageGridSource_GetDataScalarType_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetDataScalarTypeAsString_08(HandleRef pThis);

		public string GetDataScalarTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageGridSource.vtkImageGridSource_GetDataScalarTypeAsString_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetDataSpacing_09(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataSpacing_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataSpacing_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataSpacing_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetDataSpacing_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataSpacing_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageGridSource_GetFillValue_12(HandleRef pThis);

		public virtual double GetFillValue()
		{
			return vtkImageGridSource.vtkImageGridSource_GetFillValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetGridOrigin_13(HandleRef pThis);

		public virtual int[] GetGridOrigin()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetGridOrigin_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetGridOrigin_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetGridOrigin(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridOrigin_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetGridOrigin_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridOrigin_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_GetGridSpacing_16(HandleRef pThis);

		public virtual int[] GetGridSpacing()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetGridSpacing_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetGridSpacing_17(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetGridSpacing(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridSpacing_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_GetGridSpacing_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridSpacing_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageGridSource_GetLineValue_19(HandleRef pThis);

		public virtual double GetLineValue()
		{
			return vtkImageGridSource.vtkImageGridSource_GetLineValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGridSource_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGridSource_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageGridSource NewInstance()
		{
			vtkImageGridSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGridSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGridSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageGridSource vtkImageGridSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGridSource = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGridSource.Register(null);
				}
			}
			return vtkImageGridSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataExtent_25(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataExtent_25(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataExtent_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataExtent_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataOrigin_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataOrigin_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataOrigin_28(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataOrigin_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarType_29(HandleRef pThis, int _arg);

		public virtual void SetDataScalarType(int _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarType_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToDouble_30(HandleRef pThis);

		public void SetDataScalarTypeToDouble()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToDouble_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToInt_31(HandleRef pThis);

		public void SetDataScalarTypeToInt()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToInt_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToShort_32(HandleRef pThis);

		public void SetDataScalarTypeToShort()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToShort_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedChar_33(HandleRef pThis);

		public void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToUnsignedChar_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedShort_34(HandleRef pThis);

		public void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToUnsignedShort_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataSpacing_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataSpacing_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetDataSpacing_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataSpacing_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetFillValue_37(HandleRef pThis, double _arg);

		public virtual void SetFillValue(double _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetFillValue_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetGridOrigin_38(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetGridOrigin(int _arg1, int _arg2, int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridOrigin_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetGridOrigin_39(HandleRef pThis, IntPtr _arg);

		public virtual void SetGridOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridOrigin_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetGridSpacing_40(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetGridSpacing(int _arg1, int _arg2, int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridSpacing_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetGridSpacing_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetGridSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridSpacing_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGridSource_SetLineValue_42(HandleRef pThis, double _arg);

		public virtual void SetLineValue(double _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetLineValue_42(base.GetCppThis(), _arg);
		}
	}
}
