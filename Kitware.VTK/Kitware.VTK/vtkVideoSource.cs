using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVideoSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVideoSource";

		public new static readonly string MRClassNameKey;

		static vtkVideoSource()
		{
			vtkVideoSource.MRClassNameKey = "class vtkVideoSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVideoSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVideoSource"));
		}

		public vtkVideoSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVideoSource New()
		{
			vtkVideoSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVideoSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVideoSource.vtkVideoSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_AutoAdvanceOff_01(HandleRef pThis);

		public virtual void AutoAdvanceOff()
		{
			vtkVideoSource.vtkVideoSource_AutoAdvanceOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_AutoAdvanceOn_02(HandleRef pThis);

		public virtual void AutoAdvanceOn()
		{
			vtkVideoSource.vtkVideoSource_AutoAdvanceOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_FastForward_03(HandleRef pThis);

		public virtual void FastForward()
		{
			vtkVideoSource.vtkVideoSource_FastForward_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetAutoAdvance_04(HandleRef pThis);

		public virtual int GetAutoAdvance()
		{
			return vtkVideoSource.vtkVideoSource_GetAutoAdvance_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_GetClipRegion_05(HandleRef pThis);

		public virtual int[] GetClipRegion()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetClipRegion_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetClipRegion_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetClipRegion(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkVideoSource.vtkVideoSource_GetClipRegion_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetClipRegion_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetClipRegion(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetClipRegion_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_GetDataOrigin_08(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetDataOrigin_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetDataOrigin_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetDataOrigin_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetDataOrigin_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetDataOrigin_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_GetDataSpacing_11(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetDataSpacing_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetDataSpacing_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetDataSpacing_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetDataSpacing_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetDataSpacing_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetFrameBufferSize_14(HandleRef pThis);

		public virtual int GetFrameBufferSize()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameBufferSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetFrameCount_15(HandleRef pThis);

		public virtual int GetFrameCount()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameCount_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetFrameIndex_16(HandleRef pThis);

		public virtual int GetFrameIndex()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameIndex_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern float vtkVideoSource_GetFrameRate_17(HandleRef pThis);

		public virtual float GetFrameRate()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameRate_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_GetFrameSize_18(HandleRef pThis);

		public virtual int[] GetFrameSize()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetFrameSize_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetFrameSize_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetFrameSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetFrameSize_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetFrameSize_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetFrameSize(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetFrameSize_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkVideoSource_GetFrameTimeStamp_21(HandleRef pThis, int frame);

		public virtual double GetFrameTimeStamp(int frame)
		{
			return vtkVideoSource.vtkVideoSource_GetFrameTimeStamp_21(base.GetCppThis(), frame);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkVideoSource_GetFrameTimeStamp_22(HandleRef pThis);

		public double GetFrameTimeStamp()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameTimeStamp_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetInitialized_23(HandleRef pThis);

		public virtual int GetInitialized()
		{
			return vtkVideoSource.vtkVideoSource_GetInitialized_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetNumberOfOutputFrames_24(HandleRef pThis);

		public virtual int GetNumberOfOutputFrames()
		{
			return vtkVideoSource.vtkVideoSource_GetNumberOfOutputFrames_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern float vtkVideoSource_GetOpacity_25(HandleRef pThis);

		public virtual float GetOpacity()
		{
			return vtkVideoSource.vtkVideoSource_GetOpacity_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetOutputFormat_26(HandleRef pThis);

		public virtual int GetOutputFormat()
		{
			return vtkVideoSource.vtkVideoSource_GetOutputFormat_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_GetOutputWholeExtent_27(HandleRef pThis);

		public virtual int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_27(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetOutputWholeExtent_28(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_GetOutputWholeExtent_29(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputWholeExtent(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetPlaying_30(HandleRef pThis);

		public virtual int GetPlaying()
		{
			return vtkVideoSource.vtkVideoSource_GetPlaying_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_GetRecording_31(HandleRef pThis);

		public virtual int GetRecording()
		{
			return vtkVideoSource.vtkVideoSource_GetRecording_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkVideoSource_GetStartTimeStamp_32(HandleRef pThis);

		public double GetStartTimeStamp()
		{
			return vtkVideoSource.vtkVideoSource_GetStartTimeStamp_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Grab_33(HandleRef pThis);

		public virtual void Grab()
		{
			vtkVideoSource.vtkVideoSource_Grab_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Initialize_34(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkVideoSource.vtkVideoSource_Initialize_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_InternalGrab_35(HandleRef pThis);

		public virtual void InternalGrab()
		{
			vtkVideoSource.vtkVideoSource_InternalGrab_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_IsA_36(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVideoSource.vtkVideoSource_IsA_36(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVideoSource_IsTypeOf_37(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVideoSource.vtkVideoSource_IsTypeOf_37(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVideoSource NewInstance()
		{
			vtkVideoSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_NewInstance_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Play_40(HandleRef pThis);

		public virtual void Play()
		{
			vtkVideoSource.vtkVideoSource_Play_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Record_41(HandleRef pThis);

		public virtual void Record()
		{
			vtkVideoSource.vtkVideoSource_Record_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_ReleaseSystemResources_42(HandleRef pThis);

		public virtual void ReleaseSystemResources()
		{
			vtkVideoSource.vtkVideoSource_ReleaseSystemResources_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Rewind_43(HandleRef pThis);

		public virtual void Rewind()
		{
			vtkVideoSource.vtkVideoSource_Rewind_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVideoSource_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVideoSource SafeDownCast(vtkObjectBase o)
		{
			vtkVideoSource vtkVideoSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVideoSource = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVideoSource.Register(null);
				}
			}
			return vtkVideoSource;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Seek_45(HandleRef pThis, int n);

		public virtual void Seek(int n)
		{
			vtkVideoSource.vtkVideoSource_Seek_45(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetAutoAdvance_46(HandleRef pThis, int _arg);

		public virtual void SetAutoAdvance(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetAutoAdvance_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetClipRegion_47(HandleRef pThis, IntPtr r);

		public virtual void SetClipRegion(IntPtr r)
		{
			vtkVideoSource.vtkVideoSource_SetClipRegion_47(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetClipRegion_48(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		public virtual void SetClipRegion(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkVideoSource.vtkVideoSource_SetClipRegion_48(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetDataOrigin_49(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkVideoSource.vtkVideoSource_SetDataOrigin_49(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetDataOrigin_50(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetDataOrigin_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetDataSpacing_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVideoSource.vtkVideoSource_SetDataSpacing_51(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetDataSpacing_52(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetDataSpacing_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetFrameBufferSize_53(HandleRef pThis, int FrameBufferSize);

		public virtual void SetFrameBufferSize(int FrameBufferSize)
		{
			vtkVideoSource.vtkVideoSource_SetFrameBufferSize_53(base.GetCppThis(), FrameBufferSize);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetFrameCount_54(HandleRef pThis, int _arg);

		public virtual void SetFrameCount(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetFrameCount_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetFrameRate_55(HandleRef pThis, float rate);

		public virtual void SetFrameRate(float rate)
		{
			vtkVideoSource.vtkVideoSource_SetFrameRate_55(base.GetCppThis(), rate);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetFrameSize_56(HandleRef pThis, int x, int y, int z);

		public virtual void SetFrameSize(int x, int y, int z)
		{
			vtkVideoSource.vtkVideoSource_SetFrameSize_56(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetFrameSize_57(HandleRef pThis, IntPtr dim);

		public virtual void SetFrameSize(IntPtr dim)
		{
			vtkVideoSource.vtkVideoSource_SetFrameSize_57(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetNumberOfOutputFrames_58(HandleRef pThis, int _arg);

		public virtual void SetNumberOfOutputFrames(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetNumberOfOutputFrames_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOpacity_59(HandleRef pThis, float _arg);

		public virtual void SetOpacity(float _arg)
		{
			vtkVideoSource.vtkVideoSource_SetOpacity_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputFormat_60(HandleRef pThis, int format);

		public virtual void SetOutputFormat(int format)
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormat_60(base.GetCppThis(), format);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputFormatToLuminance_61(HandleRef pThis);

		public void SetOutputFormatToLuminance()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToLuminance_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputFormatToRGB_62(HandleRef pThis);

		public void SetOutputFormatToRGB()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToRGB_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputFormatToRGBA_63(HandleRef pThis);

		public void SetOutputFormatToRGBA()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToRGBA_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputWholeExtent_64(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkVideoSource.vtkVideoSource_SetOutputWholeExtent_64(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetOutputWholeExtent_65(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputWholeExtent(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetOutputWholeExtent_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_SetStartTimeStamp_66(HandleRef pThis, double t);

		public void SetStartTimeStamp(double t)
		{
			vtkVideoSource.vtkVideoSource_SetStartTimeStamp_66(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVideoSource_Stop_67(HandleRef pThis);

		public virtual void Stop()
		{
			vtkVideoSource.vtkVideoSource_Stop_67(base.GetCppThis());
		}
	}
}
