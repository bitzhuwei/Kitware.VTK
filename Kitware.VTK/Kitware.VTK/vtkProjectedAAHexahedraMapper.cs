using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkProjectedAAHexahedraMapper : vtkUnstructuredGridVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedAAHexahedraMapper";

		public new static readonly string MRClassNameKey;

		static vtkProjectedAAHexahedraMapper()
		{
			vtkProjectedAAHexahedraMapper.MRClassNameKey = "class vtkProjectedAAHexahedraMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedAAHexahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedAAHexahedraMapper"));
		}

		public vtkProjectedAAHexahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedAAHexahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedAAHexahedraMapper New()
		{
			vtkProjectedAAHexahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProjectedAAHexahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedAAHexahedraMapper_GetVisibilitySort_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkVisibilitySort GetVisibilitySort()
		{
			vtkVisibilitySort vtkVisibilitySort = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_GetVisibilitySort_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVisibilitySort = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVisibilitySort.Register(null);
				}
			}
			return vtkVisibilitySort;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkProjectedAAHexahedraMapper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkProjectedAAHexahedraMapper_IsRenderSupported_03(HandleRef pThis, HandleRef w);

		public virtual bool IsRenderSupported(vtkRenderWindow w)
		{
			return vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_IsRenderSupported_03(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkProjectedAAHexahedraMapper_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedAAHexahedraMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProjectedAAHexahedraMapper NewInstance()
		{
			vtkProjectedAAHexahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedAAHexahedraMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedAAHexahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedAAHexahedraMapper vtkProjectedAAHexahedraMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedAAHexahedraMapper = (vtkProjectedAAHexahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedAAHexahedraMapper.Register(null);
				}
			}
			return vtkProjectedAAHexahedraMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkProjectedAAHexahedraMapper_SetVisibilitySort_08(HandleRef pThis, HandleRef sort);

		public virtual void SetVisibilitySort(vtkVisibilitySort sort)
		{
			vtkProjectedAAHexahedraMapper.vtkProjectedAAHexahedraMapper_SetVisibilitySort_08(base.GetCppThis(), (sort == null) ? default(HandleRef) : sort.GetCppThis());
		}
	}
}
