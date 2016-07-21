using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleUser : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUser";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleUser()
		{
			vtkInteractorStyleUser.MRClassNameKey = "class vtkInteractorStyleUser";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleUser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUser"));
		}

		public vtkInteractorStyleUser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleUser New()
		{
			vtkInteractorStyleUser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleUser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleUser.vtkInteractorStyleUser_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_GetButton_01(HandleRef pThis);

		public virtual int GetButton()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetButton_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_GetChar_02(HandleRef pThis);

		public virtual int GetChar()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetChar_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_GetCtrlKey_03(HandleRef pThis);

		public virtual int GetCtrlKey()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetCtrlKey_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_GetKeySym_04(HandleRef pThis);

		public virtual string GetKeySym()
		{
			return Marshal.PtrToStringAnsi(vtkInteractorStyleUser.vtkInteractorStyleUser_GetKeySym_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_GetLastPos_05(HandleRef pThis);

		public virtual int[] GetLastPos()
		{
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_GetLastPos_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetLastPos(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_GetLastPos_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetLastPos(IntPtr _arg)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_GetOldPos_08(HandleRef pThis);

		public virtual int[] GetOldPos()
		{
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_GetOldPos_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetOldPos(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_GetOldPos_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetOldPos(IntPtr _arg)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_GetShiftKey_11(HandleRef pThis);

		public virtual int GetShiftKey()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetShiftKey_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUser_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleUser NewInstance()
		{
			vtkInteractorStyleUser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnChar_16(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnChar_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnConfigure_17(HandleRef pThis);

		public override void OnConfigure()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnConfigure_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnEnter_18(HandleRef pThis);

		public override void OnEnter()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnEnter_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnExpose_19(HandleRef pThis);

		public override void OnExpose()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnExpose_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnKeyPress_20(HandleRef pThis);

		public override void OnKeyPress()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnKeyPress_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnKeyRelease_21(HandleRef pThis);

		public override void OnKeyRelease()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnKeyRelease_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnLeave_22(HandleRef pThis);

		public override void OnLeave()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeave_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnLeftButtonDown_23(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeftButtonDown_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnLeftButtonUp_24(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeftButtonUp_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnMiddleButtonDown_25(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMiddleButtonDown_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnMiddleButtonUp_26(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMiddleButtonUp_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnMouseMove_27(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMouseMove_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnRightButtonDown_28(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnRightButtonDown_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnRightButtonUp_29(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnRightButtonUp_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUser_OnTimer_30(HandleRef pThis);

		public override void OnTimer()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnTimer_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUser_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleUser SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleUser vtkInteractorStyleUser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleUser = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleUser.Register(null);
				}
			}
			return vtkInteractorStyleUser;
		}
	}
}
