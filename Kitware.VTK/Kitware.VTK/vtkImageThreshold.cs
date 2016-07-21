using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageThreshold : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageThreshold";

		public new static readonly string MRClassNameKey;

		static vtkImageThreshold()
		{
			vtkImageThreshold.MRClassNameKey = "class vtkImageThreshold";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageThreshold"));
		}

		public vtkImageThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageThreshold New()
		{
			vtkImageThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageThreshold.vtkImageThreshold_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageThreshold_GetInValue_01(HandleRef pThis);

		public virtual double GetInValue()
		{
			return vtkImageThreshold.vtkImageThreshold_GetInValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageThreshold_GetLowerThreshold_02(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkImageThreshold.vtkImageThreshold_GetLowerThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageThreshold_GetOutValue_03(HandleRef pThis);

		public virtual double GetOutValue()
		{
			return vtkImageThreshold.vtkImageThreshold_GetOutValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageThreshold_GetOutputScalarType_04(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageThreshold.vtkImageThreshold_GetOutputScalarType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageThreshold_GetReplaceIn_05(HandleRef pThis);

		public virtual int GetReplaceIn()
		{
			return vtkImageThreshold.vtkImageThreshold_GetReplaceIn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageThreshold_GetReplaceOut_06(HandleRef pThis);

		public virtual int GetReplaceOut()
		{
			return vtkImageThreshold.vtkImageThreshold_GetReplaceOut_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageThreshold_GetUpperThreshold_07(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkImageThreshold.vtkImageThreshold_GetUpperThreshold_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageThreshold_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageThreshold_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageThreshold_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageThreshold NewInstance()
		{
			vtkImageThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ReplaceInOff_12(HandleRef pThis);

		public virtual void ReplaceInOff()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceInOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ReplaceInOn_13(HandleRef pThis);

		public virtual void ReplaceInOn()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceInOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ReplaceOutOff_14(HandleRef pThis);

		public virtual void ReplaceOutOff()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceOutOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ReplaceOutOn_15(HandleRef pThis);

		public virtual void ReplaceOutOn()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceOutOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageThreshold_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkImageThreshold vtkImageThreshold = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageThreshold = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageThreshold.Register(null);
				}
			}
			return vtkImageThreshold;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetInValue_17(HandleRef pThis, double val);

		public void SetInValue(double val)
		{
			vtkImageThreshold.vtkImageThreshold_SetInValue_17(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutValue_18(HandleRef pThis, double val);

		public void SetOutValue(double val)
		{
			vtkImageThreshold.vtkImageThreshold_SetOutValue_18(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarType_19(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarType_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToChar_20(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToChar_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToDouble_21(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToDouble_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToFloat_22(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToFloat_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToInt_23(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToInt_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToLong_24(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToLong_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToShort_25(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToShort_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToSignedChar_26(HandleRef pThis);

		public void SetOutputScalarTypeToSignedChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToSignedChar_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_27(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_28(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_29(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_30(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetReplaceIn_31(HandleRef pThis, int _arg);

		public virtual void SetReplaceIn(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetReplaceIn_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_SetReplaceOut_32(HandleRef pThis, int _arg);

		public virtual void SetReplaceOut(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetReplaceOut_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ThresholdBetween_33(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdBetween_33(base.GetCppThis(), lower, upper);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ThresholdByLower_34(HandleRef pThis, double thresh);

		public void ThresholdByLower(double thresh)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdByLower_34(base.GetCppThis(), thresh);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageThreshold_ThresholdByUpper_35(HandleRef pThis, double thresh);

		public void ThresholdByUpper(double thresh)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdByUpper_35(base.GetCppThis(), thresh);
		}
	}
}
