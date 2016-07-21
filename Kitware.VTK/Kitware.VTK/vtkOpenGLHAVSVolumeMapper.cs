using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLHAVSVolumeMapper : vtkHAVSVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHAVSVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLHAVSVolumeMapper()
		{
			vtkOpenGLHAVSVolumeMapper.MRClassNameKey = "class vtkOpenGLHAVSVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLHAVSVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHAVSVolumeMapper"));
		}

		public vtkOpenGLHAVSVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHAVSVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLHAVSVolumeMapper New()
		{
			vtkOpenGLHAVSVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLHAVSVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLHAVSVolumeMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLHAVSVolumeMapper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHAVSVolumeMapper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLHAVSVolumeMapper NewInstance()
		{
			vtkOpenGLHAVSVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLHAVSVolumeMapper_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_ReleaseGraphicsResources_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLHAVSVolumeMapper_Render_06(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_Render_06(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLHAVSVolumeMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLHAVSVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLHAVSVolumeMapper vtkOpenGLHAVSVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLHAVSVolumeMapper = (vtkOpenGLHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLHAVSVolumeMapper.Register(null);
				}
			}
			return vtkOpenGLHAVSVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLHAVSVolumeMapper_SetGPUDataStructures_08(HandleRef pThis, byte arg0);

		public override void SetGPUDataStructures(bool arg0)
		{
			vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_SetGPUDataStructures_08(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkOpenGLHAVSVolumeMapper_SupportedByHardware_09(HandleRef pThis, HandleRef r);

		public override bool SupportedByHardware(vtkRenderer r)
		{
			return vtkOpenGLHAVSVolumeMapper.vtkOpenGLHAVSVolumeMapper_SupportedByHardware_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis()) != 0;
		}
	}
}
