using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageImport : vtkImageAlgorithm
	{
		public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

		public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

		public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

		public delegate IntPtr OriginCallbackType(IntPtr arg0);

		public delegate int PipelineModifiedCallbackType(IntPtr arg0);

		public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

		public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

		public delegate IntPtr SpacingCallbackType(IntPtr arg0);

		public delegate void UpdateDataCallbackType(IntPtr arg0);

		public delegate void UpdateInformationCallbackType(IntPtr arg0);

		public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkImageImport";

		public new static readonly string MRClassNameKey;

		static vtkImageImport()
		{
			vtkImageImport.MRClassNameKey = "class vtkImageImport";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageImport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageImport"));
		}

		public vtkImageImport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageImport New()
		{
			vtkImageImport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImport.vtkImageImport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageImport() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageImport.vtkImageImport_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_CopyImportVoidPointer_01(HandleRef pThis, IntPtr ptr, int size);

		public void CopyImportVoidPointer(IntPtr ptr, int size)
		{
			vtkImageImport.vtkImageImport_CopyImportVoidPointer_01(base.GetCppThis(), ptr, size);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.BufferPointerCallbackType vtkImageImport_GetBufferPointerCallback_02(HandleRef pThis);

		public virtual vtkImageImport.BufferPointerCallbackType GetBufferPointerCallback()
		{
			return vtkImageImport.vtkImageImport_GetBufferPointerCallback_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetCallbackUserData_03(HandleRef pThis);

		public virtual IntPtr GetCallbackUserData()
		{
			return vtkImageImport.vtkImageImport_GetCallbackUserData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetDataExtent_04(HandleRef pThis);

		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataExtent_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataExtent_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageImport.vtkImageImport_GetDataExtent_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataExtent_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataExtent_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.DataExtentCallbackType vtkImageImport_GetDataExtentCallback_07(HandleRef pThis);

		public virtual vtkImageImport.DataExtentCallbackType GetDataExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetDataExtentCallback_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetDataOrigin_08(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataOrigin_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataOrigin_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageImport.vtkImageImport_GetDataOrigin_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataOrigin_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataOrigin_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImport_GetDataScalarType_11(HandleRef pThis);

		public virtual int GetDataScalarType()
		{
			return vtkImageImport.vtkImageImport_GetDataScalarType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetDataScalarTypeAsString_12(HandleRef pThis);

		public string GetDataScalarTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageImport.vtkImageImport_GetDataScalarTypeAsString_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetDataSpacing_13(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataSpacing_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataSpacing_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageImport.vtkImageImport_GetDataSpacing_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetDataSpacing_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataSpacing_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetImportVoidPointer_16(HandleRef pThis);

		public IntPtr GetImportVoidPointer()
		{
			return vtkImageImport.vtkImageImport_GetImportVoidPointer_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.NumberOfComponentsCallbackType vtkImageImport_GetNumberOfComponentsCallback_17(HandleRef pThis);

		public virtual vtkImageImport.NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
		{
			return vtkImageImport.vtkImageImport_GetNumberOfComponentsCallback_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImport_GetNumberOfScalarComponents_18(HandleRef pThis);

		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageImport.vtkImageImport_GetNumberOfScalarComponents_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.OriginCallbackType vtkImageImport_GetOriginCallback_19(HandleRef pThis);

		public virtual vtkImageImport.OriginCallbackType GetOriginCallback()
		{
			return vtkImageImport.vtkImageImport_GetOriginCallback_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.NumberOfComponentsCallbackType vtkImageImport_GetPipelineModifiedCallback_20(HandleRef pThis);

		public virtual vtkImageImport.NumberOfComponentsCallbackType GetPipelineModifiedCallback()
		{
			return vtkImageImport.vtkImageImport_GetPipelineModifiedCallback_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.PropagateUpdateExtentCallbackType vtkImageImport_GetPropagateUpdateExtentCallback_21(HandleRef pThis);

		public virtual vtkImageImport.PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetPropagateUpdateExtentCallback_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetScalarArrayName_22(HandleRef pThis);

		public virtual string GetScalarArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkImageImport.vtkImageImport_GetScalarArrayName_22(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.ScalarTypeCallbackType vtkImageImport_GetScalarTypeCallback_23(HandleRef pThis);

		public virtual vtkImageImport.ScalarTypeCallbackType GetScalarTypeCallback()
		{
			return vtkImageImport.vtkImageImport_GetScalarTypeCallback_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.OriginCallbackType vtkImageImport_GetSpacingCallback_24(HandleRef pThis);

		public virtual vtkImageImport.OriginCallbackType GetSpacingCallback()
		{
			return vtkImageImport.vtkImageImport_GetSpacingCallback_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.UpdateDataCallbackType vtkImageImport_GetUpdateDataCallback_25(HandleRef pThis);

		public virtual vtkImageImport.UpdateDataCallbackType GetUpdateDataCallback()
		{
			return vtkImageImport.vtkImageImport_GetUpdateDataCallback_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.UpdateDataCallbackType vtkImageImport_GetUpdateInformationCallback_26(HandleRef pThis);

		public virtual vtkImageImport.UpdateDataCallbackType GetUpdateInformationCallback()
		{
			return vtkImageImport.vtkImageImport_GetUpdateInformationCallback_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_GetWholeExtent_27(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetWholeExtent_27(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetWholeExtent_28(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageImport.vtkImageImport_GetWholeExtent_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_GetWholeExtent_29(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetWholeExtent_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageImport.DataExtentCallbackType vtkImageImport_GetWholeExtentCallback_30(HandleRef pThis);

		public virtual vtkImageImport.DataExtentCallbackType GetWholeExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetWholeExtentCallback_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_InvokeExecuteDataCallbacks_31(HandleRef pThis);

		public void InvokeExecuteDataCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeExecuteDataCallbacks_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_InvokeExecuteInformationCallbacks_32(HandleRef pThis);

		public void InvokeExecuteInformationCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeExecuteInformationCallbacks_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImport_InvokePipelineModifiedCallbacks_33(HandleRef pThis);

		public int InvokePipelineModifiedCallbacks()
		{
			return vtkImageImport.vtkImageImport_InvokePipelineModifiedCallbacks_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_InvokeUpdateInformationCallbacks_34(HandleRef pThis);

		public void InvokeUpdateInformationCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeUpdateInformationCallbacks_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImport_IsA_35(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageImport.vtkImageImport_IsA_35(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImport_IsTypeOf_36(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageImport.vtkImageImport_IsTypeOf_36(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_LegacyCheckWholeExtent_37(HandleRef pThis);

		public void LegacyCheckWholeExtent()
		{
			vtkImageImport.vtkImageImport_LegacyCheckWholeExtent_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageImport NewInstance()
		{
			vtkImageImport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImport.vtkImageImport_NewInstance_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImport_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageImport SafeDownCast(vtkObjectBase o)
		{
			vtkImageImport vtkImageImport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImport.vtkImageImport_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageImport = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageImport.Register(null);
				}
			}
			return vtkImageImport;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetBufferPointerCallback_41(HandleRef pThis, vtkImageImport.BufferPointerCallbackType _arg);

		public virtual void SetBufferPointerCallback(vtkImageImport.BufferPointerCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetBufferPointerCallback_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetCallbackUserData_42(HandleRef pThis, IntPtr _arg);

		public virtual void SetCallbackUserData(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetCallbackUserData_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataExtent_43(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageImport.vtkImageImport_SetDataExtent_43(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataExtent_44(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataExtent_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataExtentCallback_45(HandleRef pThis, vtkImageImport.DataExtentCallbackType _arg);

		public virtual void SetDataExtentCallback(vtkImageImport.DataExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetDataExtentCallback_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataExtentToWholeExtent_46(HandleRef pThis);

		public void SetDataExtentToWholeExtent()
		{
			vtkImageImport.vtkImageImport_SetDataExtentToWholeExtent_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataOrigin_47(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageImport.vtkImageImport_SetDataOrigin_47(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataOrigin_48(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataOrigin_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarType_49(HandleRef pThis, int _arg);

		public virtual void SetDataScalarType(int _arg)
		{
			vtkImageImport.vtkImageImport_SetDataScalarType_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToDouble_50(HandleRef pThis);

		public void SetDataScalarTypeToDouble()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToDouble_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToFloat_51(HandleRef pThis);

		public void SetDataScalarTypeToFloat()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToFloat_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToInt_52(HandleRef pThis);

		public void SetDataScalarTypeToInt()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToInt_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToShort_53(HandleRef pThis);

		public void SetDataScalarTypeToShort()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToShort_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedChar_54(HandleRef pThis);

		public void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToUnsignedChar_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedShort_55(HandleRef pThis);

		public void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToUnsignedShort_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataSpacing_56(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageImport.vtkImageImport_SetDataSpacing_56(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetDataSpacing_57(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataSpacing_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetImportVoidPointer_58(HandleRef pThis, IntPtr ptr);

		public void SetImportVoidPointer(IntPtr ptr)
		{
			vtkImageImport.vtkImageImport_SetImportVoidPointer_58(base.GetCppThis(), ptr);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetImportVoidPointer_59(HandleRef pThis, IntPtr ptr, int save);

		public void SetImportVoidPointer(IntPtr ptr, int save)
		{
			vtkImageImport.vtkImageImport_SetImportVoidPointer_59(base.GetCppThis(), ptr, save);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetNumberOfComponentsCallback_60(HandleRef pThis, vtkImageImport.NumberOfComponentsCallbackType _arg);

		public virtual void SetNumberOfComponentsCallback(vtkImageImport.NumberOfComponentsCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetNumberOfComponentsCallback_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetNumberOfScalarComponents_61(HandleRef pThis, int _arg);

		public virtual void SetNumberOfScalarComponents(int _arg)
		{
			vtkImageImport.vtkImageImport_SetNumberOfScalarComponents_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetOriginCallback_62(HandleRef pThis, vtkImageImport.OriginCallbackType _arg);

		public virtual void SetOriginCallback(vtkImageImport.OriginCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetOriginCallback_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetPipelineModifiedCallback_63(HandleRef pThis, vtkImageImport.NumberOfComponentsCallbackType _arg);

		public virtual void SetPipelineModifiedCallback(vtkImageImport.NumberOfComponentsCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetPipelineModifiedCallback_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetPropagateUpdateExtentCallback_64(HandleRef pThis, vtkImageImport.PropagateUpdateExtentCallbackType _arg);

		public virtual void SetPropagateUpdateExtentCallback(vtkImageImport.PropagateUpdateExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetPropagateUpdateExtentCallback_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetScalarArrayName_65(HandleRef pThis, string _arg);

		public virtual void SetScalarArrayName(string _arg)
		{
			vtkImageImport.vtkImageImport_SetScalarArrayName_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetScalarTypeCallback_66(HandleRef pThis, vtkImageImport.ScalarTypeCallbackType _arg);

		public virtual void SetScalarTypeCallback(vtkImageImport.ScalarTypeCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetScalarTypeCallback_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetSpacingCallback_67(HandleRef pThis, vtkImageImport.OriginCallbackType _arg);

		public virtual void SetSpacingCallback(vtkImageImport.OriginCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetSpacingCallback_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetUpdateDataCallback_68(HandleRef pThis, vtkImageImport.UpdateDataCallbackType _arg);

		public virtual void SetUpdateDataCallback(vtkImageImport.UpdateDataCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetUpdateDataCallback_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetUpdateInformationCallback_69(HandleRef pThis, vtkImageImport.UpdateDataCallbackType _arg);

		public virtual void SetUpdateInformationCallback(vtkImageImport.UpdateDataCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetUpdateInformationCallback_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetWholeExtent_70(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageImport.vtkImageImport_SetWholeExtent_70(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetWholeExtent_71(HandleRef pThis, IntPtr _arg);

		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetWholeExtent_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageImport_SetWholeExtentCallback_72(HandleRef pThis, vtkImageImport.DataExtentCallbackType _arg);

		public virtual void SetWholeExtentCallback(vtkImageImport.DataExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetWholeExtentCallback_72(base.GetCppThis(), _arg);
		}
	}
}
