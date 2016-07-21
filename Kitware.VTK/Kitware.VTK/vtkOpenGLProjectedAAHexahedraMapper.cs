using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLProjectedAAHexahedraMapper : vtkProjectedAAHexahedraMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProjectedAAHexahedraMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLProjectedAAHexahedraMapper()
		{
			vtkOpenGLProjectedAAHexahedraMapper.MRClassNameKey = "class vtkOpenGLProjectedAAHexahedraMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLProjectedAAHexahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProjectedAAHexahedraMapper"));
		}

		public vtkOpenGLProjectedAAHexahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedAAHexahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProjectedAAHexahedraMapper New()
		{
			vtkOpenGLProjectedAAHexahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLProjectedAAHexahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProjectedAAHexahedraMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkOpenGLProjectedAAHexahedraMapper_IsRenderSupported_02(HandleRef pThis, HandleRef w);

		public override bool IsRenderSupported(vtkRenderWindow w)
		{
			return vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_IsRenderSupported_02(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProjectedAAHexahedraMapper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedAAHexahedraMapper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLProjectedAAHexahedraMapper NewInstance()
		{
			vtkOpenGLProjectedAAHexahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProjectedAAHexahedraMapper_ReleaseGraphicsResources_06(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_ReleaseGraphicsResources_06(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProjectedAAHexahedraMapper_Render_07(HandleRef pThis, HandleRef renderer, HandleRef volume);

		public override void Render(vtkRenderer renderer, vtkVolume volume)
		{
			vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_Render_07(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedAAHexahedraMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProjectedAAHexahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLProjectedAAHexahedraMapper vtkOpenGLProjectedAAHexahedraMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedAAHexahedraMapper.vtkOpenGLProjectedAAHexahedraMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLProjectedAAHexahedraMapper = (vtkOpenGLProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLProjectedAAHexahedraMapper.Register(null);
				}
			}
			return vtkOpenGLProjectedAAHexahedraMapper;
		}
	}
}
