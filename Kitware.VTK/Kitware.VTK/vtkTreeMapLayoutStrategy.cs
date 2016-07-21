using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkTreeMapLayoutStrategy : vtkAreaLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkTreeMapLayoutStrategy()
		{
			vtkTreeMapLayoutStrategy.MRClassNameKey = "class vtkTreeMapLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapLayoutStrategy"));
		}

		public vtkTreeMapLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkTreeMapLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef areaArray, IntPtr pnt);

		public override long FindVertex(vtkTree tree, vtkDataArray areaArray, IntPtr pnt)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapLayoutStrategy_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapLayoutStrategy_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayoutStrategy_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeMapLayoutStrategy NewInstance()
		{
			vtkTreeMapLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayoutStrategy_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapLayoutStrategy vtkTreeMapLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayoutStrategy = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayoutStrategy.Register(null);
				}
			}
			return vtkTreeMapLayoutStrategy;
		}
	}
}
