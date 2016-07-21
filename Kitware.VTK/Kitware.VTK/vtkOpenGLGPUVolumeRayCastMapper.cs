using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLGPUVolumeRayCastMapper : vtkGPUVolumeRayCastMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLGPUVolumeRayCastMapper()
		{
			vtkOpenGLGPUVolumeRayCastMapper.MRClassNameKey = "class vtkOpenGLGPUVolumeRayCastMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGPUVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper"));
		}

		public vtkOpenGLGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLGPUVolumeRayCastMapper New()
		{
			vtkOpenGLGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLGPUVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsRenderSupported_02(HandleRef pThis, HandleRef window, HandleRef property);

		public override int IsRenderSupported(vtkRenderWindow window, vtkVolumeProperty property)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_IsRenderSupported_02(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLGPUVolumeRayCastMapper NewInstance()
		{
			vtkOpenGLGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_OpenGLErrorMessage_06(uint errorCode);

		public static string OpenGLErrorMessage(uint errorCode)
		{
			return Marshal.PtrToStringAnsi(vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_OpenGLErrorMessage_06(errorCode));
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_PrintError_07(string headerMessage);

		public static void PrintError(string headerMessage)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_PrintError_07(headerMessage);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGPUVolumeRayCastMapper vtkOpenGLGPUVolumeRayCastMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGPUVolumeRayCastMapper = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGPUVolumeRayCastMapper.Register(null);
				}
			}
			return vtkOpenGLGPUVolumeRayCastMapper;
		}
	}
}
