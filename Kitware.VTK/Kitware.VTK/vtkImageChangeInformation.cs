using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageChangeInformation : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageChangeInformation";

		public new static readonly string MRClassNameKey;

		static vtkImageChangeInformation()
		{
			vtkImageChangeInformation.MRClassNameKey = "class vtkImageChangeInformation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageChangeInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageChangeInformation"));
		}

		public vtkImageChangeInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageChangeInformation New()
		{
			vtkImageChangeInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageChangeInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageChangeInformation.vtkImageChangeInformation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_CenterImageOff_01(HandleRef pThis);

		public virtual void CenterImageOff()
		{
			vtkImageChangeInformation.vtkImageChangeInformation_CenterImageOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_CenterImageOn_02(HandleRef pThis);

		public virtual void CenterImageOn()
		{
			vtkImageChangeInformation.vtkImageChangeInformation_CenterImageOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageChangeInformation_GetCenterImage_03(HandleRef pThis);

		public virtual int GetCenterImage()
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_GetCenterImage_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetExtentTranslation_04(HandleRef pThis);

		public virtual int[] GetExtentTranslation()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetExtentTranslation_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetExtentTranslation(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetExtentTranslation_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtentTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetInformationInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetInformationInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetOriginScale_08(HandleRef pThis);

		public virtual double[] GetOriginScale()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOriginScale_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOriginScale(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOriginScale_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetOriginScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetOriginTranslation_11(HandleRef pThis);

		public virtual double[] GetOriginTranslation()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOriginTranslation_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOriginTranslation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOriginTranslation_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetOriginTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputExtentStart_14(HandleRef pThis);

		public virtual int[] GetOutputExtentStart()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputExtentStart_15(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetOutputExtentStart(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputExtentStart_16(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputExtentStart(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputOrigin_17(HandleRef pThis);

		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputOrigin_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputOrigin_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputSpacing_20(HandleRef pThis);

		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputSpacing_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetOutputSpacing_22(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_GetSpacingScale_23(HandleRef pThis);

		public virtual double[] GetSpacingScale()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetSpacingScale_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSpacingScale(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_GetSpacingScale_25(HandleRef pThis, IntPtr _arg);

		public virtual void GetSpacingScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageChangeInformation_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageChangeInformation_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageChangeInformation NewInstance()
		{
			vtkImageChangeInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageChangeInformation_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageChangeInformation SafeDownCast(vtkObjectBase o)
		{
			vtkImageChangeInformation vtkImageChangeInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageChangeInformation = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageChangeInformation.Register(null);
				}
			}
			return vtkImageChangeInformation;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetCenterImage_31(HandleRef pThis, int _arg);

		public virtual void SetCenterImage(int _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetCenterImage_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetExtentTranslation_32(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetExtentTranslation(int _arg1, int _arg2, int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetExtentTranslation_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetExtentTranslation_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetExtentTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetExtentTranslation_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetInformationInput_34(HandleRef pThis, HandleRef arg0);

		public virtual void SetInformationInput(vtkImageData arg0)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetInformationInput_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOriginScale_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOriginScale(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginScale_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOriginScale_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetOriginScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginScale_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOriginTranslation_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOriginTranslation(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginTranslation_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOriginTranslation_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetOriginTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginTranslation_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputExtentStart_39(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetOutputExtentStart(int _arg1, int _arg2, int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputExtentStart_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputExtentStart_40(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputExtentStart(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputExtentStart_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputOrigin_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputOrigin_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputOrigin_42(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputOrigin(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputOrigin_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputSpacing_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputSpacing_43(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetOutputSpacing_44(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputSpacing(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputSpacing_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetSpacingScale_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpacingScale(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetSpacingScale_45(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageChangeInformation_SetSpacingScale_46(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpacingScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetSpacingScale_46(base.GetCppThis(), _arg);
		}
	}
}
