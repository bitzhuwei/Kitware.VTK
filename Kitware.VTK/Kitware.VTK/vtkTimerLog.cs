using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTimerLog : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimerLog";

		public new static readonly string MRClassNameKey;

		static vtkTimerLog()
		{
			vtkTimerLog.MRClassNameKey = "class vtkTimerLog";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimerLog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimerLog"));
		}

		public vtkTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimerLog New()
		{
			vtkTimerLog result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTimerLog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTimerLog.vtkTimerLog_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_AllocateLog_01();

		public static void AllocateLog()
		{
			vtkTimerLog.vtkTimerLog_AllocateLog_01();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_CleanupLog_02();

		public static void CleanupLog()
		{
			vtkTimerLog.vtkTimerLog_CleanupLog_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_DumpLog_03(string filename);

		public static void DumpLog(string filename)
		{
			vtkTimerLog.vtkTimerLog_DumpLog_03(filename);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_FormatAndMarkEvent_04(string EventString);

		public static void FormatAndMarkEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_FormatAndMarkEvent_04(EventString);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkTimerLog_GetCPUTime_05();

		public static double GetCPUTime()
		{
			return vtkTimerLog.vtkTimerLog_GetCPUTime_05();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkTimerLog_GetElapsedTime_06(HandleRef pThis);

		public double GetElapsedTime()
		{
			return vtkTimerLog.vtkTimerLog_GetElapsedTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_GetEventIndent_07(int i);

		public static int GetEventIndent(int i)
		{
			return vtkTimerLog.vtkTimerLog_GetEventIndent_07(i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimerLog_GetEventString_08(int i);

		public static string GetEventString(int i)
		{
			return Marshal.PtrToStringAnsi(vtkTimerLog.vtkTimerLog_GetEventString_08(i));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkTimerLog_GetEventWallTime_09(int i);

		public static double GetEventWallTime(int i)
		{
			return vtkTimerLog.vtkTimerLog_GetEventWallTime_09(i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_GetLogging_10();

		public static int GetLogging()
		{
			return vtkTimerLog.vtkTimerLog_GetLogging_10();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_GetMaxEntries_11();

		public static int GetMaxEntries()
		{
			return vtkTimerLog.vtkTimerLog_GetMaxEntries_11();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_GetNumberOfEvents_12();

		public static int GetNumberOfEvents()
		{
			return vtkTimerLog.vtkTimerLog_GetNumberOfEvents_12();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkTimerLog_GetUniversalTime_13();

		public static double GetUniversalTime()
		{
			return vtkTimerLog.vtkTimerLog_GetUniversalTime_13();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTimerLog.vtkTimerLog_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimerLog_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTimerLog.vtkTimerLog_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_LoggingOff_16();

		public static void LoggingOff()
		{
			vtkTimerLog.vtkTimerLog_LoggingOff_16();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_LoggingOn_17();

		public static void LoggingOn()
		{
			vtkTimerLog.vtkTimerLog_LoggingOn_17();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_MarkEndEvent_18(string EventString);

		public static void MarkEndEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkEndEvent_18(EventString);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_MarkEvent_19(string EventString);

		public static void MarkEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkEvent_19(EventString);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_MarkStartEvent_20(string EventString);

		public static void MarkStartEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkStartEvent_20(EventString);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimerLog_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTimerLog NewInstance()
		{
			vtkTimerLog result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_ResetLog_23();

		public static void ResetLog()
		{
			vtkTimerLog.vtkTimerLog_ResetLog_23();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimerLog_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimerLog SafeDownCast(vtkObjectBase o)
		{
			vtkTimerLog vtkTimerLog = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimerLog = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimerLog.Register(null);
				}
			}
			return vtkTimerLog;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_SetLogging_25(int v);

		public static void SetLogging(int v)
		{
			vtkTimerLog.vtkTimerLog_SetLogging_25(v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_SetMaxEntries_26(int a);

		public static void SetMaxEntries(int a)
		{
			vtkTimerLog.vtkTimerLog_SetMaxEntries_26(a);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_StartTimer_27(HandleRef pThis);

		public void StartTimer()
		{
			vtkTimerLog.vtkTimerLog_StartTimer_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimerLog_StopTimer_28(HandleRef pThis);

		public void StopTimer()
		{
			vtkTimerLog.vtkTimerLog_StopTimer_28(base.GetCppThis());
		}
	}
}
