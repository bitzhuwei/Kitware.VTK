using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAnimationCue : vtkObject
	{
		public enum TimeCodes
		{
			TIMEMODE_NORMALIZED,
			TIMEMODE_RELATIVE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationCue";

		public new static readonly string MRClassNameKey;

		static vtkAnimationCue()
		{
			vtkAnimationCue.MRClassNameKey = "class vtkAnimationCue";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnimationCue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationCue"));
		}

		public vtkAnimationCue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationCue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnimationCue New()
		{
			vtkAnimationCue result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAnimationCue() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAnimationCue.vtkAnimationCue_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_Finalize_01(HandleRef pThis);

		public virtual void FinalizeWrapper()
		{
			vtkAnimationCue.vtkAnimationCue_Finalize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationCue_GetAnimationTime_02(HandleRef pThis);

		public virtual double GetAnimationTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetAnimationTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationCue_GetClockTime_03(HandleRef pThis);

		public virtual double GetClockTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetClockTime_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationCue_GetDeltaTime_04(HandleRef pThis);

		public virtual double GetDeltaTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetDeltaTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationCue_GetEndTime_05(HandleRef pThis);

		public virtual double GetEndTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetEndTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationCue_GetStartTime_06(HandleRef pThis);

		public virtual double GetStartTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetStartTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationCue_GetTimeMode_07(HandleRef pThis);

		public virtual int GetTimeMode()
		{
			return vtkAnimationCue.vtkAnimationCue_GetTimeMode_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_Initialize_08(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkAnimationCue.vtkAnimationCue_Initialize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationCue_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationCue_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationCue_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAnimationCue NewInstance()
		{
			vtkAnimationCue result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationCue_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnimationCue SafeDownCast(vtkObjectBase o)
		{
			vtkAnimationCue vtkAnimationCue = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnimationCue = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnimationCue.Register(null);
				}
			}
			return vtkAnimationCue;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_SetEndTime_14(HandleRef pThis, double _arg);

		public virtual void SetEndTime(double _arg)
		{
			vtkAnimationCue.vtkAnimationCue_SetEndTime_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_SetStartTime_15(HandleRef pThis, double _arg);

		public virtual void SetStartTime(double _arg)
		{
			vtkAnimationCue.vtkAnimationCue_SetStartTime_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_SetTimeMode_16(HandleRef pThis, int mode);

		public virtual void SetTimeMode(int mode)
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeMode_16(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_SetTimeModeToNormalized_17(HandleRef pThis);

		public void SetTimeModeToNormalized()
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeModeToNormalized_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_SetTimeModeToRelative_18(HandleRef pThis);

		public void SetTimeModeToRelative()
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeModeToRelative_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationCue_Tick_19(HandleRef pThis, double currenttime, double deltatime, double clocktime);

		public virtual void Tick(double currenttime, double deltatime, double clocktime)
		{
			vtkAnimationCue.vtkAnimationCue_Tick_19(base.GetCppThis(), currenttime, deltatime, clocktime);
		}
	}
}
