using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiThreader : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiThreader";

		public new static readonly string MRClassNameKey;

		static vtkMultiThreader()
		{
			vtkMultiThreader.MRClassNameKey = "class vtkMultiThreader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiThreader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiThreader"));
		}

		public vtkMultiThreader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiThreader New()
		{
			vtkMultiThreader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiThreader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiThreader.vtkMultiThreader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkMultiThreader_GetCurrentThreadID_01();

		public static uint GetCurrentThreadID()
		{
			return vtkMultiThreader.vtkMultiThreader_GetCurrentThreadID_01();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();

		public static int GetGlobalDefaultNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();

		public static int GetGlobalMaximumNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_GetNumberOfThreads_04(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreads_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_GetNumberOfThreadsMaxValue_05(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreadsMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_GetNumberOfThreadsMinValue_06(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreadsMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_IsThreadActive_08(HandleRef pThis, int threadID);

		public int IsThreadActive(int threadID)
		{
			return vtkMultiThreader.vtkMultiThreader_IsThreadActive_08(base.GetCppThis(), threadID);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_MultipleMethodExecute_10(HandleRef pThis);

		public void MultipleMethodExecute()
		{
			vtkMultiThreader.vtkMultiThreader_MultipleMethodExecute_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiThreader NewInstance()
		{
			vtkMultiThreader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiThreader SafeDownCast(vtkObjectBase o)
		{
			vtkMultiThreader vtkMultiThreader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiThreader = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiThreader.Register(null);
				}
			}
			return vtkMultiThreader;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_SetGlobalDefaultNumberOfThreads_14(int val);

		public static void SetGlobalDefaultNumberOfThreads(int val)
		{
			vtkMultiThreader.vtkMultiThreader_SetGlobalDefaultNumberOfThreads_14(val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_SetGlobalMaximumNumberOfThreads_15(int val);

		public static void SetGlobalMaximumNumberOfThreads(int val)
		{
			vtkMultiThreader.vtkMultiThreader_SetGlobalMaximumNumberOfThreads_15(val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_SetNumberOfThreads_16(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkMultiThreader.vtkMultiThreader_SetNumberOfThreads_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_SingleMethodExecute_17(HandleRef pThis);

		public void SingleMethodExecute()
		{
			vtkMultiThreader.vtkMultiThreader_SingleMethodExecute_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMultiThreader_TerminateThread_18(HandleRef pThis, int thread_id);

		public void TerminateThread(int thread_id)
		{
			vtkMultiThreader.vtkMultiThreader_TerminateThread_18(base.GetCppThis(), thread_id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMultiThreader_ThreadsEqual_19(uint t1, uint t2);

		public static int ThreadsEqual(uint t1, uint t2)
		{
			return vtkMultiThreader.vtkMultiThreader_ThreadsEqual_19(t1, t2);
		}
	}
}
