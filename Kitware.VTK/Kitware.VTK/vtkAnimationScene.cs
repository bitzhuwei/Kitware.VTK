using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAnimationScene : vtkAnimationCue
	{
		public enum PlayModes
		{
			PLAYMODE_REALTIME = 1,
			PLAYMODE_SEQUENCE = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationScene";

		public new static readonly string MRClassNameKey;

		static vtkAnimationScene()
		{
			vtkAnimationScene.MRClassNameKey = "class vtkAnimationScene";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnimationScene.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationScene"));
		}

		public vtkAnimationScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnimationScene New()
		{
			vtkAnimationScene result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAnimationScene() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAnimationScene.vtkAnimationScene_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_AddCue_01(HandleRef pThis, HandleRef cue);

		public void AddCue(vtkAnimationCue cue)
		{
			vtkAnimationScene.vtkAnimationScene_AddCue_01(base.GetCppThis(), (cue == null) ? default(HandleRef) : cue.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationScene_GetAnimationTime_02(HandleRef pThis);

		public override double GetAnimationTime()
		{
			return vtkAnimationScene.vtkAnimationScene_GetAnimationTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAnimationScene_GetFrameRate_03(HandleRef pThis);

		public virtual double GetFrameRate()
		{
			return vtkAnimationScene.vtkAnimationScene_GetFrameRate_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_GetLoop_04(HandleRef pThis);

		public virtual int GetLoop()
		{
			return vtkAnimationScene.vtkAnimationScene_GetLoop_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_GetNumberOfCues_05(HandleRef pThis);

		public int GetNumberOfCues()
		{
			return vtkAnimationScene.vtkAnimationScene_GetNumberOfCues_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_GetPlayMode_06(HandleRef pThis);

		public virtual int GetPlayMode()
		{
			return vtkAnimationScene.vtkAnimationScene_GetPlayMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_IsInPlay_08(HandleRef pThis);

		public int IsInPlay()
		{
			return vtkAnimationScene.vtkAnimationScene_IsInPlay_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAnimationScene_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationScene_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAnimationScene NewInstance()
		{
			vtkAnimationScene result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_Play_12(HandleRef pThis);

		public virtual void Play()
		{
			vtkAnimationScene.vtkAnimationScene_Play_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_RemoveAllCues_13(HandleRef pThis);

		public void RemoveAllCues()
		{
			vtkAnimationScene.vtkAnimationScene_RemoveAllCues_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_RemoveCue_14(HandleRef pThis, HandleRef cue);

		public void RemoveCue(vtkAnimationCue cue)
		{
			vtkAnimationScene.vtkAnimationScene_RemoveCue_14(base.GetCppThis(), (cue == null) ? default(HandleRef) : cue.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAnimationScene_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnimationScene SafeDownCast(vtkObjectBase o)
		{
			vtkAnimationScene vtkAnimationScene = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnimationScene = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnimationScene.Register(null);
				}
			}
			return vtkAnimationScene;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetAnimationTime_16(HandleRef pThis, double time);

		public void SetAnimationTime(double time)
		{
			vtkAnimationScene.vtkAnimationScene_SetAnimationTime_16(base.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetFrameRate_17(HandleRef pThis, double _arg);

		public virtual void SetFrameRate(double _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetFrameRate_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetLoop_18(HandleRef pThis, int _arg);

		public virtual void SetLoop(int _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetLoop_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetModeToRealTime_19(HandleRef pThis);

		public void SetModeToRealTime()
		{
			vtkAnimationScene.vtkAnimationScene_SetModeToRealTime_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetModeToSequence_20(HandleRef pThis);

		public void SetModeToSequence()
		{
			vtkAnimationScene.vtkAnimationScene_SetModeToSequence_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetPlayMode_21(HandleRef pThis, int _arg);

		public virtual void SetPlayMode(int _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetPlayMode_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_SetTimeMode_22(HandleRef pThis, int mode);

		public override void SetTimeMode(int mode)
		{
			vtkAnimationScene.vtkAnimationScene_SetTimeMode_22(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAnimationScene_Stop_23(HandleRef pThis);

		public void Stop()
		{
			vtkAnimationScene.vtkAnimationScene_Stop_23(base.GetCppThis());
		}
	}
}
