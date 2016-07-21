using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTDxInteractorStyle : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyle";

		public new static readonly string MRClassNameKey;

		static vtkTDxInteractorStyle()
		{
			vtkTDxInteractorStyle.MRClassNameKey = "class vtkTDxInteractorStyle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyle"));
		}

		public vtkTDxInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyle_GetSettings_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTDxInteractorStyleSettings GetSettings()
		{
			vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_GetSettings_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleSettings = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleSettings.Register(null);
				}
			}
			return vtkTDxInteractorStyleSettings;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyle_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyle_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyle_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTDxInteractorStyle NewInstance()
		{
			vtkTDxInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyle_OnButtonPressedEvent_05(HandleRef pThis, int button);

		public virtual void OnButtonPressedEvent(int button)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_OnButtonPressedEvent_05(base.GetCppThis(), button);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyle_OnButtonReleasedEvent_06(HandleRef pThis, int button);

		public virtual void OnButtonReleasedEvent(int button)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_OnButtonReleasedEvent_06(base.GetCppThis(), button);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyle_ProcessEvent_07(HandleRef pThis, HandleRef renderer, uint arg1, IntPtr calldata);

		public virtual void ProcessEvent(vtkRenderer renderer, uint arg1, IntPtr calldata)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_ProcessEvent_07(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), arg1, calldata);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyle_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyle vtkTDxInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyle = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyle.Register(null);
				}
			}
			return vtkTDxInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyle_SetSettings_09(HandleRef pThis, HandleRef settings);

		public virtual void SetSettings(vtkTDxInteractorStyleSettings settings)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_SetSettings_09(base.GetCppThis(), (settings == null) ? default(HandleRef) : settings.GetCppThis());
		}
	}
}
