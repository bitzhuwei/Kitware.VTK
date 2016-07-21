using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExecutionScheduler : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutionScheduler";

		public new static readonly string MRClassNameKey;

		static vtkExecutionScheduler()
		{
			vtkExecutionScheduler.MRClassNameKey = "class vtkExecutionScheduler";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutionScheduler.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutionScheduler"));
		}

		public vtkExecutionScheduler(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExecutionScheduler New()
		{
			vtkExecutionScheduler result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionScheduler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExecutionScheduler() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExecutionScheduler.vtkExecutionScheduler_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_GetGlobalScheduler_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkExecutionScheduler GetGlobalScheduler()
		{
			vtkExecutionScheduler vtkExecutionScheduler = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_GetGlobalScheduler_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutionScheduler = (vtkExecutionScheduler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutionScheduler.Register(null);
				}
			}
			return vtkExecutionScheduler;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_GetInputsReleasedLock_02(HandleRef pThis, HandleRef exec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMutexLock GetInputsReleasedLock(vtkExecutive exec)
		{
			vtkMutexLock vtkMutexLock = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_GetInputsReleasedLock_02(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutexLock = (vtkMutexLock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutexLock.Register(null);
				}
			}
			return vtkMutexLock;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_GetInputsReleasedMessager_03(HandleRef pThis, HandleRef exec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkThreadMessager GetInputsReleasedMessager(vtkExecutive exec)
		{
			vtkThreadMessager vtkThreadMessager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_GetInputsReleasedMessager_03(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadMessager = (vtkThreadMessager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadMessager.Register(null);
				}
			}
			return vtkThreadMessager;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_GetTaskDoneMessager_04(HandleRef pThis, HandleRef exec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkThreadMessager GetTaskDoneMessager(vtkExecutive exec)
		{
			vtkThreadMessager vtkThreadMessager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_GetTaskDoneMessager_04(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadMessager = (vtkThreadMessager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadMessager.Register(null);
				}
			}
			return vtkThreadMessager;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutionScheduler_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExecutionScheduler.vtkExecutionScheduler_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutionScheduler_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExecutionScheduler.vtkExecutionScheduler_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExecutionScheduler NewInstance()
		{
			vtkExecutionScheduler result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionScheduler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_ReacquireResources_09(HandleRef pThis, HandleRef exec);

		public void ReacquireResources(vtkExecutive exec)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_ReacquireResources_09(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_ReleaseResources_10(HandleRef pThis, HandleRef exec);

		public void ReleaseResources(vtkExecutive exec)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_ReleaseResources_10(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_RescheduleFrom_11(HandleRef pThis, HandleRef sink, HandleRef resources);

		public void RescheduleFrom(vtkExecutive sink, vtkComputingResources resources)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_RescheduleFrom_11(base.GetCppThis(), (sink == null) ? default(HandleRef) : sink.GetCppThis(), (resources == null) ? default(HandleRef) : resources.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_RescheduleNetwork_12(HandleRef pThis, HandleRef sink);

		public void RescheduleNetwork(vtkExecutive sink)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_RescheduleNetwork_12(base.GetCppThis(), (sink == null) ? default(HandleRef) : sink.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExecutionScheduler SafeDownCast(vtkObjectBase o)
		{
			vtkExecutionScheduler vtkExecutionScheduler = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutionScheduler = (vtkExecutionScheduler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutionScheduler.Register(null);
				}
			}
			return vtkExecutionScheduler;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_Schedule_14(HandleRef pThis, HandleRef execs, HandleRef info);

		public void Schedule(vtkExecutiveCollection execs, vtkInformation info)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_Schedule_14(base.GetCppThis(), (execs == null) ? default(HandleRef) : execs.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_SchedulePropagate_15(HandleRef pThis, HandleRef execs, HandleRef info);

		public void SchedulePropagate(vtkExecutiveCollection execs, vtkInformation info)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_SchedulePropagate_15(base.GetCppThis(), (execs == null) ? default(HandleRef) : execs.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutionScheduler_TASK_PRIORITY_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey TASK_PRIORITY()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutionScheduler.vtkExecutionScheduler_TASK_PRIORITY_16(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkExecutionScheduler_WaitForInputsReleased_17(HandleRef pThis, HandleRef exec);

		public void WaitForInputsReleased(vtkExecutive exec)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_WaitForInputsReleased_17(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_WaitForTaskDone_18(HandleRef pThis, HandleRef exec);

		public void WaitForTaskDone(vtkExecutive exec)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_WaitForTaskDone_18(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_WaitUntilAllDone_19(HandleRef pThis);

		public void WaitUntilAllDone()
		{
			vtkExecutionScheduler.vtkExecutionScheduler_WaitUntilAllDone_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_WaitUntilDone_20(HandleRef pThis, HandleRef execs);

		public void WaitUntilDone(vtkExecutiveCollection execs)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_WaitUntilDone_20(base.GetCppThis(), (execs == null) ? default(HandleRef) : execs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutionScheduler_WaitUntilReleased_21(HandleRef pThis, HandleRef execs);

		public void WaitUntilReleased(vtkExecutiveCollection execs)
		{
			vtkExecutionScheduler.vtkExecutionScheduler_WaitUntilReleased_21(base.GetCppThis(), (execs == null) ? default(HandleRef) : execs.GetCppThis());
		}
	}
}
