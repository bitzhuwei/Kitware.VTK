using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextInteractorStyle : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextInteractorStyle";

		public new static readonly string MRClassNameKey;

		static vtkContextInteractorStyle()
		{
			vtkContextInteractorStyle.MRClassNameKey = "class vtkContextInteractorStyle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextInteractorStyle"));
		}

		public vtkContextInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextInteractorStyle New()
		{
			vtkContextInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContextInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContextInteractorStyle.vtkContextInteractorStyle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextInteractorStyle_GetScene_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_GetScene_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextScene = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextScene.Register(null);
				}
			}
			return vtkContextScene;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextInteractorStyle_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextInteractorStyle_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextInteractorStyle_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextInteractorStyle NewInstance()
		{
			vtkContextInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnLeftButtonDown_06(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnLeftButtonDown_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnLeftButtonUp_07(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnLeftButtonUp_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnMiddleButtonDown_08(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMiddleButtonDown_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnMiddleButtonUp_09(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMiddleButtonUp_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnMouseWheelBackward_11(HandleRef pThis);

		public override void OnMouseWheelBackward()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseWheelBackward_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnMouseWheelForward_12(HandleRef pThis);

		public override void OnMouseWheelForward()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseWheelForward_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnRightButtonDown_13(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnRightButtonDown_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnRightButtonUp_14(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnRightButtonUp_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnSceneModified_15(HandleRef pThis);

		public virtual void OnSceneModified()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnSceneModified_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_OnSelection_16(HandleRef pThis, IntPtr rect);

		public virtual void OnSelection(IntPtr rect)
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnSelection_16(base.GetCppThis(), rect);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextInteractorStyle_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkContextInteractorStyle vtkContextInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextInteractorStyle = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextInteractorStyle.Register(null);
				}
			}
			return vtkContextInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextInteractorStyle_SetScene_18(HandleRef pThis, HandleRef scene);

		public void SetScene(vtkContextScene scene)
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_SetScene_18(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}
	}
}
