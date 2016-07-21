using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTimePointUtility : vtkObject
	{
		public enum ISO8601_DATE_WrapperEnum
		{
			ISO8601_DATE = 2,
			ISO8601_DATETIME = 1,
			ISO8601_DATETIME_MILLIS = 0,
			ISO8601_TIME = 4,
			ISO8601_TIME_MILLIS = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTimePointUtility";

		public new static readonly string MRClassNameKey;

		static vtkTimePointUtility()
		{
			vtkTimePointUtility.MRClassNameKey = "class vtkTimePointUtility";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimePointUtility.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimePointUtility"));
		}

		public vtkTimePointUtility(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointUtility_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimePointUtility New()
		{
			vtkTimePointUtility result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTimePointUtility() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTimePointUtility.vtkTimePointUtility_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkTimePointUtility_DateTimeToTimePoint_01(int year, int month, int day, int hour, int minute, int sec, int millis);

		public static ulong DateTimeToTimePoint(int year, int month, int day, int hour, int minute, int sec, int millis)
		{
			return vtkTimePointUtility.vtkTimePointUtility_DateTimeToTimePoint_01(year, month, day, hour, minute, sec, millis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkTimePointUtility_DateToTimePoint_02(int year, int month, int day);

		public static ulong DateToTimePoint(int year, int month, int day)
		{
			return vtkTimePointUtility.vtkTimePointUtility_DateToTimePoint_02(year, month, day);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimePointUtility_GetDate_03(ulong time, ref int year, ref int month, ref int day);

		public static void GetDate(ulong time, ref int year, ref int month, ref int day)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetDate_03(time, ref year, ref month, ref day);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimePointUtility_GetDateTime_04(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis);

		public static void GetDateTime(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetDateTime_04(time, ref year, ref month, ref day, ref hour, ref minute, ref second, ref millis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetDay_05(ulong time);

		public static int GetDay(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetDay_05(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetHour_06(ulong time);

		public static int GetHour(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetHour_06(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetMillisecond_07(ulong time);

		public static int GetMillisecond(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMillisecond_07(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetMinute_08(ulong time);

		public static int GetMinute(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMinute_08(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetMonth_09(ulong time);

		public static int GetMonth(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMonth_09(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetSecond_10(ulong time);

		public static int GetSecond(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetSecond_10(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTimePointUtility_GetTime_11(ulong time, ref int hour, ref int minute, ref int second, ref int millis);

		public static void GetTime(ulong time, ref int hour, ref int minute, ref int second, ref int millis)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetTime_11(time, ref hour, ref minute, ref second, ref millis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_GetYear_12(ulong time);

		public static int GetYear(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetYear_12(time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTimePointUtility_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointUtility_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTimePointUtility NewInstance()
		{
			vtkTimePointUtility result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointUtility_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimePointUtility SafeDownCast(vtkObjectBase o)
		{
			vtkTimePointUtility vtkTimePointUtility = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimePointUtility = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimePointUtility.Register(null);
				}
			}
			return vtkTimePointUtility;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointUtility_TimePointToISO8601_18(ulong arg0, int format);

		public static string TimePointToISO8601(ulong arg0, int format)
		{
			return Marshal.PtrToStringAnsi(vtkTimePointUtility.vtkTimePointUtility_TimePointToISO8601_18(arg0, format));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkTimePointUtility_TimeToTimePoint_19(int hour, int minute, int second, int millis);

		public static ulong TimeToTimePoint(int hour, int minute, int second, int millis)
		{
			return vtkTimePointUtility.vtkTimePointUtility_TimeToTimePoint_19(hour, minute, second, millis);
		}
	}
}
