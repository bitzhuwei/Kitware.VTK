using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSampleFunction : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSampleFunction";

		public new static readonly string MRClassNameKey;

		static vtkSampleFunction()
		{
			vtkSampleFunction.MRClassNameKey = "class vtkSampleFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSampleFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSampleFunction"));
		}

		public vtkSampleFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSampleFunction New()
		{
			vtkSampleFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSampleFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSampleFunction.vtkSampleFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkSampleFunction.vtkSampleFunction_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkSampleFunction.vtkSampleFunction_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkSampleFunction.vtkSampleFunction_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkSampleFunction.vtkSampleFunction_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkSampleFunction_GetCapValue_05(HandleRef pThis);

		public virtual double GetCapValue()
		{
			return vtkSampleFunction.vtkSampleFunction_GetCapValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSampleFunction_GetCapping_06(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkSampleFunction.vtkSampleFunction_GetCapping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSampleFunction_GetComputeNormals_07(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkSampleFunction.vtkSampleFunction_GetComputeNormals_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_GetImplicitFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetImplicitFunction_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkSampleFunction_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSampleFunction.vtkSampleFunction_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_GetModelBounds_10(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetModelBounds_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_GetModelBounds_11(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkSampleFunction.vtkSampleFunction_GetModelBounds_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_GetNormalArrayName_12(HandleRef pThis);

		public virtual string GetNormalArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkSampleFunction.vtkSampleFunction_GetNormalArrayName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSampleFunction_GetOutputScalarType_13(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkSampleFunction.vtkSampleFunction_GetOutputScalarType_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_GetSampleDimensions_14(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetSampleDimensions_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_GetSampleDimensions_15(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkSampleFunction.vtkSampleFunction_GetSampleDimensions_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_GetScalarArrayName_16(HandleRef pThis);

		public virtual string GetScalarArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkSampleFunction.vtkSampleFunction_GetScalarArrayName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSampleFunction_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSampleFunction_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSampleFunction NewInstance()
		{
			vtkSampleFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSampleFunction_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSampleFunction SafeDownCast(vtkObjectBase o)
		{
			vtkSampleFunction vtkSampleFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSampleFunction = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSampleFunction.Register(null);
				}
			}
			return vtkSampleFunction;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetCapValue_22(HandleRef pThis, double _arg);

		public virtual void SetCapValue(double _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetCapValue_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetCapping_23(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetCapping_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetComputeNormals_24(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetComputeNormals_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetImplicitFunction_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkSampleFunction.vtkSampleFunction_SetImplicitFunction_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetModelBounds_26(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkSampleFunction.vtkSampleFunction_SetModelBounds_26(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetModelBounds_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetModelBounds_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetNormalArrayName_28(HandleRef pThis, string _arg);

		public virtual void SetNormalArrayName(string _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetNormalArrayName_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarType_29(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarType_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToChar_30(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToChar_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToDouble_31(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToDouble_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToFloat_32(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToFloat_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToInt_33(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToInt_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToLong_34(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToLong_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToShort_35(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToShort_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_36(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_37(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_38(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_39(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetSampleDimensions_40(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkSampleFunction.vtkSampleFunction_SetSampleDimensions_40(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetSampleDimensions_41(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkSampleFunction.vtkSampleFunction_SetSampleDimensions_41(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetScalarArrayName_42(HandleRef pThis, string _arg);

		public virtual void SetScalarArrayName(string _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetScalarArrayName_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSampleFunction_SetScalars_43(HandleRef pThis, HandleRef da);

		public virtual void SetScalars(vtkDataArray da)
		{
			vtkSampleFunction.vtkSampleFunction_SetScalars_43(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}
	}
}
