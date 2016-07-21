using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalPolyDataMapper : vtkCompositePolyDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalPolyDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalPolyDataMapper()
		{
			vtkHierarchicalPolyDataMapper.MRClassNameKey = "class vtkHierarchicalPolyDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalPolyDataMapper"));
		}

		public vtkHierarchicalPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalPolyDataMapper New()
		{
			vtkHierarchicalPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalPolyDataMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalPolyDataMapper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalPolyDataMapper NewInstance()
		{
			vtkHierarchicalPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalPolyDataMapper vtkHierarchicalPolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalPolyDataMapper = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalPolyDataMapper.Register(null);
				}
			}
			return vtkHierarchicalPolyDataMapper;
		}
	}
}
