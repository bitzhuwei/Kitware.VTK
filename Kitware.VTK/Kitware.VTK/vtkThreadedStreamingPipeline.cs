using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThreadedStreamingPipeline : vtkCompositeDataPipeline
	{
		public enum PROCESSING_UNIT_CPU_WrapperEnum
		{
			PROCESSING_UNIT_CPU = 1,
			PROCESSING_UNIT_GPU,
			PROCESSING_UNIT_NONE = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedStreamingPipeline";

		public new static readonly string MRClassNameKey;

		static vtkThreadedStreamingPipeline()
		{
			vtkThreadedStreamingPipeline.MRClassNameKey = "class vtkThreadedStreamingPipeline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedStreamingPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedStreamingPipeline"));
		}

		public vtkThreadedStreamingPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreadedStreamingPipeline New()
		{
			vtkThreadedStreamingPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedStreamingPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThreadedStreamingPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_AUTO_PROPAGATE_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey AUTO_PROPAGATE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_AUTO_PROPAGATE_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_EXTRA_INFORMATION_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey EXTRA_INFORMATION()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_EXTRA_INFORMATION_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedStreamingPipeline_ForceUpdateData_03(HandleRef pThis, int processingUnit, HandleRef info);

		public int ForceUpdateData(int processingUnit, vtkInformation info)
		{
			return vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_ForceUpdateData_03(base.GetCppThis(), processingUnit, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_GetResources_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkComputingResources GetResources()
		{
			vtkComputingResources vtkComputingResources = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_GetResources_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputingResources = (vtkComputingResources)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputingResources.Register(null);
				}
			}
			return vtkComputingResources;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedStreamingPipeline_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedStreamingPipeline_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThreadedStreamingPipeline NewInstance()
		{
			vtkThreadedStreamingPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedStreamingPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_09(HandleRef execs);

		public static void Pull(vtkExecutiveCollection execs)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_09((execs == null) ? default(HandleRef) : execs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_10(HandleRef execs, HandleRef info);

		public static void Pull(vtkExecutiveCollection execs, vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_10((execs == null) ? default(HandleRef) : execs.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_11(HandleRef exec);

		public static void Pull(vtkExecutive exec)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_11((exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_12(HandleRef exec, HandleRef info);

		public static void Pull(vtkExecutive exec, vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_12((exec == null) ? default(HandleRef) : exec.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_13(HandleRef pThis);

		public void Pull()
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Pull_14(HandleRef pThis, HandleRef info);

		public void Pull(vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Pull_14(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_15(HandleRef execs);

		public static void Push(vtkExecutiveCollection execs)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_15((execs == null) ? default(HandleRef) : execs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_16(HandleRef execs, HandleRef info);

		public static void Push(vtkExecutiveCollection execs, vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_16((execs == null) ? default(HandleRef) : execs.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_17(HandleRef exec);

		public static void Push(vtkExecutive exec)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_17((exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_18(HandleRef exec, HandleRef info);

		public static void Push(vtkExecutive exec, vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_18((exec == null) ? default(HandleRef) : exec.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_19(HandleRef pThis);

		public void Push()
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_Push_20(HandleRef pThis, HandleRef info);

		public void Push(vtkInformation info)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_Push_20(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_ReleaseInputs_21(HandleRef pThis);

		public void ReleaseInputs()
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_ReleaseInputs_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedStreamingPipeline_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreadedStreamingPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedStreamingPipeline vtkThreadedStreamingPipeline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedStreamingPipeline = (vtkThreadedStreamingPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedStreamingPipeline.Register(null);
				}
			}
			return vtkThreadedStreamingPipeline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_SetAutoPropagatePush_23(byte enabled);

		public static void SetAutoPropagatePush(bool enabled)
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_SetAutoPropagatePush_23(enabled ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_SetMultiThreadedEnabled_24(byte enabled);

		public static void SetMultiThreadedEnabled(bool enabled)
		{
            vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_SetMultiThreadedEnabled_24(enabled ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedStreamingPipeline_UpdateRequestDataTimeFromSource_25(HandleRef pThis);

		public void UpdateRequestDataTimeFromSource()
		{
			vtkThreadedStreamingPipeline.vtkThreadedStreamingPipeline_UpdateRequestDataTimeFromSource_25(base.GetCppThis());
		}
	}
}
