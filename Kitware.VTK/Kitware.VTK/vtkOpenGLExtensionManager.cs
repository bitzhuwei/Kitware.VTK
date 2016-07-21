using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLExtensionManager : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLExtensionManager";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLExtensionManager()
		{
			vtkOpenGLExtensionManager.MRClassNameKey = "class vtkOpenGLExtensionManager";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLExtensionManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLExtensionManager"));
		}

		public vtkOpenGLExtensionManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLExtensionManager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLExtensionManager New()
		{
			vtkOpenGLExtensionManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLExtensionManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLExtensionManager() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLExtensionManager_ExtensionSupported_01(HandleRef pThis, string name);

		public virtual int ExtensionSupported(string name)
		{
			return vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_ExtensionSupported_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLExtensionManager_GetExtensionsString_02(HandleRef pThis);

		public virtual string GetExtensionsString()
		{
			return Marshal.PtrToStringAnsi(vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_GetExtensionsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLExtensionManager_GetRenderWindow_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_GetRenderWindow_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLExtensionManager_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLExtensionManager_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLExtensionManager_LoadAsARBExtension_06(HandleRef pThis, string name);

		public virtual void LoadAsARBExtension(string name)
		{
			vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_LoadAsARBExtension_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLExtensionManager_LoadCorePromotedExtension_07(HandleRef pThis, string name);

		public virtual void LoadCorePromotedExtension(string name)
		{
			vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_LoadCorePromotedExtension_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLExtensionManager_LoadExtension_08(HandleRef pThis, string name);

		public virtual void LoadExtension(string name)
		{
			vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_LoadExtension_08(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLExtensionManager_LoadSupportedExtension_09(HandleRef pThis, string name);

		public virtual int LoadSupportedExtension(string name)
		{
			return vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_LoadSupportedExtension_09(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLExtensionManager_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLExtensionManager NewInstance()
		{
			vtkOpenGLExtensionManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLExtensionManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLExtensionManager_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLExtensionManager SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLExtensionManager vtkOpenGLExtensionManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLExtensionManager = (vtkOpenGLExtensionManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLExtensionManager.Register(null);
				}
			}
			return vtkOpenGLExtensionManager;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLExtensionManager_SetRenderWindow_13(HandleRef pThis, HandleRef renwin);

		public virtual void SetRenderWindow(vtkRenderWindow renwin)
		{
			vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_SetRenderWindow_13(base.GetCppThis(), (renwin == null) ? default(HandleRef) : renwin.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLExtensionManager_Update_14(HandleRef pThis);

		public virtual void Update()
		{
			vtkOpenGLExtensionManager.vtkOpenGLExtensionManager_Update_14(base.GetCppThis());
		}
	}
}
