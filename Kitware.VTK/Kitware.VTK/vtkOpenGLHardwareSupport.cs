using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLHardwareSupport : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHardwareSupport";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLHardwareSupport()
		{
			vtkOpenGLHardwareSupport.MRClassNameKey = "class vtkOpenGLHardwareSupport";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLHardwareSupport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHardwareSupport"));
		}

		public vtkOpenGLHardwareSupport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHardwareSupport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLHardwareSupport New()
		{
			vtkOpenGLHardwareSupport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHardwareSupport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLHardwareSupport() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHardwareSupport_GetExtensionManager_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkOpenGLExtensionManager GetExtensionManager()
		{
			vtkOpenGLExtensionManager vtkOpenGLExtensionManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_GetExtensionManager_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkOpenGLHardwareSupport_GetNumberOfFixedTextureUnits_02(HandleRef pThis);

		public int GetNumberOfFixedTextureUnits()
		{
			return vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_GetNumberOfFixedTextureUnits_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLHardwareSupport_GetNumberOfTextureUnits_03(HandleRef pThis);

		public int GetNumberOfTextureUnits()
		{
			return vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_GetNumberOfTextureUnits_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkOpenGLHardwareSupport_GetSupportsMultiTexturing_04(HandleRef pThis);

		public bool GetSupportsMultiTexturing()
		{
			return vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_GetSupportsMultiTexturing_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLHardwareSupport_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLHardwareSupport_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHardwareSupport_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLHardwareSupport NewInstance()
		{
			vtkOpenGLHardwareSupport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHardwareSupport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHardwareSupport_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLHardwareSupport SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLHardwareSupport vtkOpenGLHardwareSupport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLHardwareSupport = (vtkOpenGLHardwareSupport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLHardwareSupport.Register(null);
				}
			}
			return vtkOpenGLHardwareSupport;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLHardwareSupport_SetExtensionManager_10(HandleRef pThis, HandleRef extensionManager);

		public void SetExtensionManager(vtkOpenGLExtensionManager extensionManager)
		{
			vtkOpenGLHardwareSupport.vtkOpenGLHardwareSupport_SetExtensionManager_10(base.GetCppThis(), (extensionManager == null) ? default(HandleRef) : extensionManager.GetCppThis());
		}
	}
}
