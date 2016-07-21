using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkApplyColors : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkApplyColors";

		public new static readonly string MRClassNameKey;

		static vtkApplyColors()
		{
			vtkApplyColors.MRClassNameKey = "class vtkApplyColors";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApplyColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyColors"));
		}

		public vtkApplyColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkApplyColors New()
		{
			vtkApplyColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkApplyColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkApplyColors.vtkApplyColors_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetCellColorOutputArrayName_01(HandleRef pThis);

		public virtual string GetCellColorOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkApplyColors.vtkApplyColors_GetCellColorOutputArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetCellLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetCellLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetCellLookupTable_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetDefaultCellColor_03(HandleRef pThis);

		public virtual double[] GetDefaultCellColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetDefaultCellColor_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetDefaultCellColor_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDefaultCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultCellColor_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetDefaultCellColor_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetDefaultCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultCellColor_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkApplyColors_GetDefaultCellOpacity_06(HandleRef pThis);

		public virtual double GetDefaultCellOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetDefaultCellOpacity_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetDefaultPointColor_07(HandleRef pThis);

		public virtual double[] GetDefaultPointColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetDefaultPointColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetDefaultPointColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDefaultPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultPointColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetDefaultPointColor_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetDefaultPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultPointColor_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkApplyColors_GetDefaultPointOpacity_10(HandleRef pThis);

		public virtual double GetDefaultPointOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetDefaultPointOpacity_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetPointColorOutputArrayName_11(HandleRef pThis);

		public virtual string GetPointColorOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkApplyColors.vtkApplyColors_GetPointColorOutputArrayName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetPointLookupTable_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetPointLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetPointLookupTable_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyColors_GetScaleCellLookupTable_13(HandleRef pThis);

		public virtual bool GetScaleCellLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetScaleCellLookupTable_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyColors_GetScalePointLookupTable_14(HandleRef pThis);

		public virtual bool GetScalePointLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetScalePointLookupTable_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetSelectedCellColor_15(HandleRef pThis);

		public virtual double[] GetSelectedCellColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetSelectedCellColor_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetSelectedCellColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedCellColor_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetSelectedCellColor_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetSelectedCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedCellColor_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkApplyColors_GetSelectedCellOpacity_18(HandleRef pThis);

		public virtual double GetSelectedCellOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetSelectedCellOpacity_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_GetSelectedPointColor_19(HandleRef pThis);

		public virtual double[] GetSelectedPointColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetSelectedPointColor_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetSelectedPointColor_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedPointColor_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_GetSelectedPointColor_21(HandleRef pThis, IntPtr _arg);

		public virtual void GetSelectedPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedPointColor_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkApplyColors_GetSelectedPointOpacity_22(HandleRef pThis);

		public virtual double GetSelectedPointOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetSelectedPointOpacity_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyColors_GetUseCellLookupTable_23(HandleRef pThis);

		public virtual bool GetUseCellLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetUseCellLookupTable_23(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyColors_GetUseCurrentAnnotationColor_24(HandleRef pThis);

		public virtual bool GetUseCurrentAnnotationColor()
		{
			return vtkApplyColors.vtkApplyColors_GetUseCurrentAnnotationColor_24(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyColors_GetUsePointLookupTable_25(HandleRef pThis);

		public virtual bool GetUsePointLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetUsePointLookupTable_25(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyColors_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkApplyColors.vtkApplyColors_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyColors_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkApplyColors.vtkApplyColors_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkApplyColors NewInstance()
		{
			vtkApplyColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyColors_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkApplyColors SafeDownCast(vtkObjectBase o)
		{
			vtkApplyColors vtkApplyColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApplyColors = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApplyColors.Register(null);
				}
			}
			return vtkApplyColors;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_ScaleCellLookupTableOff_31(HandleRef pThis);

		public virtual void ScaleCellLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_ScaleCellLookupTableOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_ScaleCellLookupTableOn_32(HandleRef pThis);

		public virtual void ScaleCellLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_ScaleCellLookupTableOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_ScalePointLookupTableOff_33(HandleRef pThis);

		public virtual void ScalePointLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_ScalePointLookupTableOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_ScalePointLookupTableOn_34(HandleRef pThis);

		public virtual void ScalePointLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_ScalePointLookupTableOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetCellColorOutputArrayName_35(HandleRef pThis, string _arg);

		public virtual void SetCellColorOutputArrayName(string _arg)
		{
			vtkApplyColors.vtkApplyColors_SetCellColorOutputArrayName_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetCellLookupTable_36(HandleRef pThis, HandleRef lut);

		public virtual void SetCellLookupTable(vtkScalarsToColors lut)
		{
			vtkApplyColors.vtkApplyColors_SetCellLookupTable_36(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultCellColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDefaultCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellColor_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultCellColor_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetDefaultCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellColor_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultCellOpacity_39(HandleRef pThis, double _arg);

		public virtual void SetDefaultCellOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellOpacity_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultPointColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDefaultPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultPointColor_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetDefaultPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointColor_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetDefaultPointOpacity_42(HandleRef pThis, double _arg);

		public virtual void SetDefaultPointOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointOpacity_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetPointColorOutputArrayName_43(HandleRef pThis, string _arg);

		public virtual void SetPointColorOutputArrayName(string _arg)
		{
			vtkApplyColors.vtkApplyColors_SetPointColorOutputArrayName_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetPointLookupTable_44(HandleRef pThis, HandleRef lut);

		public virtual void SetPointLookupTable(vtkScalarsToColors lut)
		{
			vtkApplyColors.vtkApplyColors_SetPointLookupTable_44(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetScaleCellLookupTable_45(HandleRef pThis, byte _arg);

		public virtual void SetScaleCellLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetScaleCellLookupTable_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetScalePointLookupTable_46(HandleRef pThis, byte _arg);

		public virtual void SetScalePointLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetScalePointLookupTable_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedCellColor_47(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellColor_47(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedCellColor_48(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelectedCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellColor_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedCellOpacity_49(HandleRef pThis, double _arg);

		public virtual void SetSelectedCellOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellOpacity_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedPointColor_50(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointColor_50(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedPointColor_51(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelectedPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointColor_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetSelectedPointOpacity_52(HandleRef pThis, double _arg);

		public virtual void SetSelectedPointOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointOpacity_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetUseCellLookupTable_53(HandleRef pThis, byte _arg);

		public virtual void SetUseCellLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUseCellLookupTable_53(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetUseCurrentAnnotationColor_54(HandleRef pThis, byte _arg);

		public virtual void SetUseCurrentAnnotationColor(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUseCurrentAnnotationColor_54(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_SetUsePointLookupTable_55(HandleRef pThis, byte _arg);

		public virtual void SetUsePointLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUsePointLookupTable_55(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UseCellLookupTableOff_56(HandleRef pThis);

		public virtual void UseCellLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_UseCellLookupTableOff_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UseCellLookupTableOn_57(HandleRef pThis);

		public virtual void UseCellLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_UseCellLookupTableOn_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UseCurrentAnnotationColorOff_58(HandleRef pThis);

		public virtual void UseCurrentAnnotationColorOff()
		{
			vtkApplyColors.vtkApplyColors_UseCurrentAnnotationColorOff_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UseCurrentAnnotationColorOn_59(HandleRef pThis);

		public virtual void UseCurrentAnnotationColorOn()
		{
			vtkApplyColors.vtkApplyColors_UseCurrentAnnotationColorOn_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UsePointLookupTableOff_60(HandleRef pThis);

		public virtual void UsePointLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_UsePointLookupTableOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyColors_UsePointLookupTableOn_61(HandleRef pThis);

		public virtual void UsePointLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_UsePointLookupTableOn_61(base.GetCppThis());
		}
	}
}
