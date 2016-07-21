using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkUnstructuredGridVolumeMapper : vtkAbstractVolumeMapper
	{
		public enum COMPOSITE_BLEND_WrapperEnum
		{
			COMPOSITE_BLEND,
			MAXIMUM_INTENSITY_BLEND
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeMapper()
		{
			vtkUnstructuredGridVolumeMapper.MRClassNameKey = "class vtkUnstructuredGridVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeMapper"));
		}

		public vtkUnstructuredGridVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeMapper_GetBlendMode_01(HandleRef pThis);

		public virtual int GetBlendMode()
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetBlendMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeMapper_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeMapper_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeMapper NewInstance()
		{
			vtkUnstructuredGridVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_06(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_Render_07(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_Render_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeMapper vtkUnstructuredGridVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeMapper = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendMode_09(HandleRef pThis, int _arg);

		public virtual void SetBlendMode(int _arg)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendMode_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_10(HandleRef pThis);

		public void SetBlendModeToComposite()
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_11(HandleRef pThis);

		public void SetBlendModeToMaximumIntensity()
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetInput_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkUnstructuredGrid arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetInput_13(HandleRef pThis, HandleRef arg0);

		public override void SetInput(vtkDataSet arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetInput_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
