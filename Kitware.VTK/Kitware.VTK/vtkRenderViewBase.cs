using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderViewBase : vtkView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderViewBase";

		public new static readonly string MRClassNameKey;

		static vtkRenderViewBase()
		{
			vtkRenderViewBase.MRClassNameKey = "class vtkRenderViewBase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderViewBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderViewBase"));
		}

		public vtkRenderViewBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderViewBase New()
		{
			vtkRenderViewBase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderViewBase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderViewBase.vtkRenderViewBase_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_GetRenderWindow_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetRenderWindow_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_GetRenderer_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetRenderer_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderViewBase_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderViewBase_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderViewBase NewInstance()
		{
			vtkRenderViewBase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_Render_08(HandleRef pThis);

		public virtual void Render()
		{
			vtkRenderViewBase.vtkRenderViewBase_Render_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_ResetCamera_09(HandleRef pThis);

		public virtual void ResetCamera()
		{
			vtkRenderViewBase.vtkRenderViewBase_ResetCamera_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_ResetCameraClippingRange_10(HandleRef pThis);

		public virtual void ResetCameraClippingRange()
		{
			vtkRenderViewBase.vtkRenderViewBase_ResetCameraClippingRange_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderViewBase_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderViewBase SafeDownCast(vtkObjectBase o)
		{
			vtkRenderViewBase vtkRenderViewBase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderViewBase = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderViewBase.Register(null);
				}
			}
			return vtkRenderViewBase;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_SetInteractor_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetInteractor_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_SetRenderWindow_13(HandleRef pThis, HandleRef win);

		public virtual void SetRenderWindow(vtkRenderWindow win)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetRenderWindow_13(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderViewBase_SetRenderer_14(HandleRef pThis, HandleRef ren);

		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetRenderer_14(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}
	}
}
