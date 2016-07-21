using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAreaLayoutStrategy : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkAreaLayoutStrategy()
		{
			vtkAreaLayoutStrategy.MRClassNameKey = "class vtkAreaLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayoutStrategy"));
		}

		public vtkAreaLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkAreaLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

		public virtual long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentage_02(HandleRef pThis);

		public virtual double GetShrinkPercentage()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentage_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_03(HandleRef pThis);

		public virtual double GetShrinkPercentageMaxValue()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_04(HandleRef pThis);

		public virtual double GetShrinkPercentageMinValue()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAreaLayoutStrategy_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAreaLayoutStrategy_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayoutStrategy_Layout_07(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

		public virtual void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_Layout_07(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayoutStrategy_LayoutEdgePoints_08(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray, HandleRef edgeLayoutTree);

		public virtual void LayoutEdgePoints(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray, vtkTree edgeLayoutTree)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_LayoutEdgePoints_08(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis(), (edgeLayoutTree == null) ? default(HandleRef) : edgeLayoutTree.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayoutStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAreaLayoutStrategy NewInstance()
		{
			vtkAreaLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayoutStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAreaLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayoutStrategy_SetShrinkPercentage_11(HandleRef pThis, double _arg);

		public virtual void SetShrinkPercentage(double _arg)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_SetShrinkPercentage_11(base.GetCppThis(), _arg);
		}
	}
}
