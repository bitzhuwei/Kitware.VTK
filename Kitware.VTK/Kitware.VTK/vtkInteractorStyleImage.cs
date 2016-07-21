using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleImage : vtkInteractorStyleTrackballCamera
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleImage";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleImage()
		{
			vtkInteractorStyleImage.MRClassNameKey = "class vtkInteractorStyleImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleImage"));
		}

		public vtkInteractorStyleImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleImage New()
		{
			vtkInteractorStyleImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleImage.vtkInteractorStyleImage_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_EndPick_01(HandleRef pThis);

		public virtual void EndPick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_EndPick_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_EndWindowLevel_02(HandleRef pThis);

		public virtual void EndWindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_EndWindowLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelCurrentPosition_03(HandleRef pThis);

		public virtual int[] GetWindowLevelCurrentPosition()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_04(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetWindowLevelCurrentPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_04(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetWindowLevelCurrentPosition(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelStartPosition_06(HandleRef pThis);

		public virtual int[] GetWindowLevelStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetWindowLevelStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetWindowLevelStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleImage_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleImage_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleImage_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleImage NewInstance()
		{
			vtkInteractorStyleImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnChar_13(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnChar_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnLeftButtonDown_14(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnLeftButtonDown_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnLeftButtonUp_15(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnLeftButtonUp_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnMouseMove_16(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnMouseMove_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnRightButtonDown_17(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnRightButtonDown_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_OnRightButtonUp_18(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnRightButtonUp_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_Pick_19(HandleRef pThis);

		public virtual void Pick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_Pick_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleImage_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleImage SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleImage vtkInteractorStyleImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleImage = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleImage.Register(null);
				}
			}
			return vtkInteractorStyleImage;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_StartPick_21(HandleRef pThis);

		public virtual void StartPick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_StartPick_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_StartWindowLevel_22(HandleRef pThis);

		public virtual void StartWindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_StartWindowLevel_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleImage_WindowLevel_23(HandleRef pThis);

		public virtual void WindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_WindowLevel_23(base.GetCppThis());
		}
	}
}
