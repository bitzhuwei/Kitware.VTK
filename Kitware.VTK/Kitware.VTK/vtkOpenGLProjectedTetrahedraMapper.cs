using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLProjectedTetrahedraMapper : vtkProjectedTetrahedraMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLProjectedTetrahedraMapper()
		{
			vtkOpenGLProjectedTetrahedraMapper.MRClassNameKey = "class vtkOpenGLProjectedTetrahedraMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLProjectedTetrahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper"));
		}

		public vtkOpenGLProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProjectedTetrahedraMapper New()
		{
			vtkOpenGLProjectedTetrahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLProjectedTetrahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLProjectedTetrahedraMapper NewInstance()
		{
			vtkOpenGLProjectedTetrahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_05(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_Render_06(HandleRef pThis, HandleRef renderer, HandleRef volume);

		public override void Render(vtkRenderer renderer, vtkVolume volume)
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_Render_06(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLProjectedTetrahedraMapper vtkOpenGLProjectedTetrahedraMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLProjectedTetrahedraMapper = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLProjectedTetrahedraMapper.Register(null);
				}
			}
			return vtkOpenGLProjectedTetrahedraMapper;
		}
	}
}
