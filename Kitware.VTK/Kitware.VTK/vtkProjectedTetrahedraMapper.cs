using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkProjectedTetrahedraMapper : vtkUnstructuredGridVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTetrahedraMapper";

		public new static readonly string MRClassNameKey;

		static vtkProjectedTetrahedraMapper()
		{
			vtkProjectedTetrahedraMapper.MRClassNameKey = "class vtkProjectedTetrahedraMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTetrahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTetrahedraMapper"));
		}

		public vtkProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTetrahedraMapper New()
		{
			vtkProjectedTetrahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProjectedTetrahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_GetVisibilitySort_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkVisibilitySort GetVisibilitySort()
		{
			vtkVisibilitySort vtkVisibilitySort = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_GetVisibilitySort_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkProjectedTetrahedraMapper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkProjectedTetrahedraMapper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkProjectedTetrahedraMapper_MapScalarsToColors_04(HandleRef colors, HandleRef property, HandleRef scalars);

		public static void MapScalarsToColors(vtkDataArray colors, vtkVolumeProperty property, vtkDataArray scalars)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_MapScalarsToColors_04((colors == null) ? default(HandleRef) : colors.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProjectedTetrahedraMapper NewInstance()
		{
			vtkProjectedTetrahedraMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTetrahedraMapper vtkProjectedTetrahedraMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTetrahedraMapper = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTetrahedraMapper.Register(null);
				}
			}
			return vtkProjectedTetrahedraMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkProjectedTetrahedraMapper_SetVisibilitySort_08(HandleRef pThis, HandleRef sort);

		public virtual void SetVisibilitySort(vtkVisibilitySort sort)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_SetVisibilitySort_08(base.GetCppThis(), (sort == null) ? default(HandleRef) : sort.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkProjectedTetrahedraMapper_TransformPoints_09(HandleRef inPoints, IntPtr projection_mat, IntPtr modelview_mat, HandleRef outPoints);

		public static void TransformPoints(vtkPoints inPoints, IntPtr projection_mat, IntPtr modelview_mat, vtkFloatArray outPoints)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_TransformPoints_09((inPoints == null) ? default(HandleRef) : inPoints.GetCppThis(), projection_mat, modelview_mat, (outPoints == null) ? default(HandleRef) : outPoints.GetCppThis());
		}
	}
}
