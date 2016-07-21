using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageReslice : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReslice";

		public new static readonly string MRClassNameKey;

		static vtkImageReslice()
		{
			vtkImageReslice.MRClassNameKey = "class vtkImageReslice";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReslice.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReslice"));
		}

		public vtkImageReslice(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReslice New()
		{
			vtkImageReslice result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageReslice() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageReslice.vtkImageReslice_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_AutoCropOutputOff_01(HandleRef pThis);

		public virtual void AutoCropOutputOff()
		{
			vtkImageReslice.vtkImageReslice_AutoCropOutputOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_AutoCropOutputOn_02(HandleRef pThis);

		public virtual void AutoCropOutputOn()
		{
			vtkImageReslice.vtkImageReslice_AutoCropOutputOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_BorderOff_03(HandleRef pThis);

		public virtual void BorderOff()
		{
			vtkImageReslice.vtkImageReslice_BorderOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_BorderOn_04(HandleRef pThis);

		public virtual void BorderOn()
		{
			vtkImageReslice.vtkImageReslice_BorderOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetAutoCropOutput_05(HandleRef pThis);

		public virtual int GetAutoCropOutput()
		{
			return vtkImageReslice.vtkImageReslice_GetAutoCropOutput_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetBackgroundColor_06(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetBackgroundColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetBackgroundColor_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageReslice.vtkImageReslice_GetBackgroundColor_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetBackgroundColor_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetBackgroundColor_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageReslice_GetBackgroundLevel_09(HandleRef pThis);

		public double GetBackgroundLevel()
		{
			return vtkImageReslice.vtkImageReslice_GetBackgroundLevel_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetBorder_10(HandleRef pThis);

		public virtual int GetBorder()
		{
			return vtkImageReslice.vtkImageReslice_GetBorder_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetInformationInput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetInformationInput_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageReslice_GetInterpolate_12(HandleRef pThis);

		public int GetInterpolate()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolate_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetInterpolationMode_13(HandleRef pThis);

		public virtual int GetInterpolationMode()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetInterpolationModeAsString_14(HandleRef pThis);

		public virtual string GetInterpolationModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageReslice.vtkImageReslice_GetInterpolationModeAsString_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetInterpolationModeMaxValue_15(HandleRef pThis);

		public virtual int GetInterpolationModeMaxValue()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationModeMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetInterpolationModeMinValue_16(HandleRef pThis);

		public virtual int GetInterpolationModeMinValue()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationModeMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkImageReslice_GetMTime_17(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageReslice.vtkImageReslice_GetMTime_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetMirror_18(HandleRef pThis);

		public virtual int GetMirror()
		{
			return vtkImageReslice.vtkImageReslice_GetMirror_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetOptimization_19(HandleRef pThis);

		public virtual int GetOptimization()
		{
			return vtkImageReslice.vtkImageReslice_GetOptimization_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetOutputDimensionality_20(HandleRef pThis);

		public virtual int GetOutputDimensionality()
		{
			return vtkImageReslice.vtkImageReslice_GetOutputDimensionality_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetOutputExtent_21(HandleRef pThis);

		public virtual int[] GetOutputExtent()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputExtent_21(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputExtent_22(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetOutputExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReslice.vtkImageReslice_GetOutputExtent_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputExtent_23(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputExtent(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputExtent_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetOutputOrigin_24(HandleRef pThis);

		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputOrigin_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputOrigin_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReslice.vtkImageReslice_GetOutputOrigin_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputOrigin_26(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputOrigin_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetOutputSpacing_27(HandleRef pThis);

		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputSpacing_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputSpacing_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReslice.vtkImageReslice_GetOutputSpacing_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetOutputSpacing_29(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputSpacing_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetResliceAxes_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetResliceAxes()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxes_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_31(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

		public void GetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_31(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_32(HandleRef pThis, IntPtr xyz);

		public void GetResliceAxesDirectionCosines(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_32(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetResliceAxesDirectionCosines_33(HandleRef pThis);

		public double[] GetResliceAxesDirectionCosines()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_33(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_GetResliceAxesOrigin_34(HandleRef pThis, IntPtr xyz);

		public void GetResliceAxesOrigin(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesOrigin_34(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetResliceAxesOrigin_35(HandleRef pThis);

		public double[] GetResliceAxesOrigin()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxesOrigin_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetResliceTransform_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetResliceTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceTransform_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_GetStencil_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetStencil_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetTransformInputSampling_38(HandleRef pThis);

		public virtual int GetTransformInputSampling()
		{
			return vtkImageReslice.vtkImageReslice_GetTransformInputSampling_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_GetWrap_39(HandleRef pThis);

		public virtual int GetWrap()
		{
			return vtkImageReslice.vtkImageReslice_GetWrap_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_InterpolateOff_40(HandleRef pThis);

		public void InterpolateOff()
		{
			vtkImageReslice.vtkImageReslice_InterpolateOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_InterpolateOn_41(HandleRef pThis);

		public void InterpolateOn()
		{
			vtkImageReslice.vtkImageReslice_InterpolateOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_IsA_42(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageReslice.vtkImageReslice_IsA_42(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageReslice_IsTypeOf_43(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageReslice.vtkImageReslice_IsTypeOf_43(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_MirrorOff_44(HandleRef pThis);

		public virtual void MirrorOff()
		{
			vtkImageReslice.vtkImageReslice_MirrorOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_MirrorOn_45(HandleRef pThis);

		public virtual void MirrorOn()
		{
			vtkImageReslice.vtkImageReslice_MirrorOn_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageReslice NewInstance()
		{
			vtkImageReslice result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_NewInstance_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_OptimizationOff_48(HandleRef pThis);

		public virtual void OptimizationOff()
		{
			vtkImageReslice.vtkImageReslice_OptimizationOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_OptimizationOn_49(HandleRef pThis);

		public virtual void OptimizationOn()
		{
			vtkImageReslice.vtkImageReslice_OptimizationOn_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_ReportReferences_50(HandleRef pThis, HandleRef arg0);

		public virtual void ReportReferences(vtkGarbageCollector arg0)
		{
			vtkImageReslice.vtkImageReslice_ReportReferences_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReslice_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReslice SafeDownCast(vtkObjectBase o)
		{
			vtkImageReslice vtkImageReslice = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReslice = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReslice.Register(null);
				}
			}
			return vtkImageReslice;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetAutoCropOutput_52(HandleRef pThis, int _arg);

		public virtual void SetAutoCropOutput(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetAutoCropOutput_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetBackgroundColor_53(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundColor_53(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetBackgroundColor_54(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundColor_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetBackgroundLevel_55(HandleRef pThis, double v);

		public void SetBackgroundLevel(double v)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundLevel_55(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetBorder_56(HandleRef pThis, int _arg);

		public virtual void SetBorder(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetBorder_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInformationInput_57(HandleRef pThis, HandleRef arg0);

		public virtual void SetInformationInput(vtkImageData arg0)
		{
			vtkImageReslice.vtkImageReslice_SetInformationInput_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInterpolate_58(HandleRef pThis, int t);

		public void SetInterpolate(int t)
		{
			vtkImageReslice.vtkImageReslice_SetInterpolate_58(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInterpolationMode_59(HandleRef pThis, int _arg);

		public virtual void SetInterpolationMode(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationMode_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInterpolationModeToCubic_60(HandleRef pThis);

		public void SetInterpolationModeToCubic()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToCubic_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInterpolationModeToLinear_61(HandleRef pThis);

		public void SetInterpolationModeToLinear()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToLinear_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetInterpolationModeToNearestNeighbor_62(HandleRef pThis);

		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToNearestNeighbor_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetMirror_63(HandleRef pThis, int _arg);

		public virtual void SetMirror(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetMirror_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOptimization_64(HandleRef pThis, int _arg);

		public virtual void SetOptimization(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetOptimization_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputDimensionality_65(HandleRef pThis, int _arg);

		public virtual void SetOutputDimensionality(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetOutputDimensionality_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputExtent_66(HandleRef pThis, int a, int b, int c, int d, int e, int f);

		public virtual void SetOutputExtent(int a, int b, int c, int d, int e, int f)
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtent_66(base.GetCppThis(), a, b, c, d, e, f);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputExtent_67(HandleRef pThis, IntPtr a);

		public virtual void SetOutputExtent(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtent_67(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputExtentToDefault_68(HandleRef pThis);

		public void SetOutputExtentToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtentToDefault_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputOrigin_69(HandleRef pThis, double x, double y, double z);

		public virtual void SetOutputOrigin(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetOutputOrigin_69(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputOrigin_70(HandleRef pThis, IntPtr a);

		public virtual void SetOutputOrigin(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputOrigin_70(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputOriginToDefault_71(HandleRef pThis);

		public void SetOutputOriginToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputOriginToDefault_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputSpacing_72(HandleRef pThis, double x, double y, double z);

		public virtual void SetOutputSpacing(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacing_72(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputSpacing_73(HandleRef pThis, IntPtr a);

		public virtual void SetOutputSpacing(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacing_73(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetOutputSpacingToDefault_74(HandleRef pThis);

		public void SetOutputSpacingToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacingToDefault_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxes_75(HandleRef pThis, HandleRef arg0);

		public virtual void SetResliceAxes(vtkMatrix4x4 arg0)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxes_75(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_76(HandleRef pThis, double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2);

		public void SetResliceAxesDirectionCosines(double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_76(base.GetCppThis(), x0, x1, x2, y0, y1, y2, z0, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_77(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

		public void SetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_77(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_78(HandleRef pThis, IntPtr xyz);

		public void SetResliceAxesDirectionCosines(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_78(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxesOrigin_79(HandleRef pThis, double x, double y, double z);

		public void SetResliceAxesOrigin(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesOrigin_79(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceAxesOrigin_80(HandleRef pThis, IntPtr xyz);

		public void SetResliceAxesOrigin(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesOrigin_80(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetResliceTransform_81(HandleRef pThis, HandleRef arg0);

		public virtual void SetResliceTransform(vtkAbstractTransform arg0)
		{
			vtkImageReslice.vtkImageReslice_SetResliceTransform_81(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetStencil_82(HandleRef pThis, HandleRef stencil);

		public void SetStencil(vtkImageStencilData stencil)
		{
			vtkImageReslice.vtkImageReslice_SetStencil_82(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetTransformInputSampling_83(HandleRef pThis, int _arg);

		public virtual void SetTransformInputSampling(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetTransformInputSampling_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_SetWrap_84(HandleRef pThis, int _arg);

		public virtual void SetWrap(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetWrap_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_TransformInputSamplingOff_85(HandleRef pThis);

		public virtual void TransformInputSamplingOff()
		{
			vtkImageReslice.vtkImageReslice_TransformInputSamplingOff_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_TransformInputSamplingOn_86(HandleRef pThis);

		public virtual void TransformInputSamplingOn()
		{
			vtkImageReslice.vtkImageReslice_TransformInputSamplingOn_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_WrapOff_87(HandleRef pThis);

		public virtual void WrapOff()
		{
			vtkImageReslice.vtkImageReslice_WrapOff_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageReslice_WrapOn_88(HandleRef pThis);

		public virtual void WrapOn()
		{
			vtkImageReslice.vtkImageReslice_WrapOn_88(base.GetCppThis());
		}
	}
}
