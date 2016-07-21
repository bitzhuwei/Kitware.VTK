using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStackedTreeLayoutStrategy : vtkAreaLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStackedTreeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkStackedTreeLayoutStrategy()
		{
			vtkStackedTreeLayoutStrategy.MRClassNameKey = "class vtkStackedTreeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStackedTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStackedTreeLayoutStrategy"));
		}

		public vtkStackedTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStackedTreeLayoutStrategy New()
		{
			vtkStackedTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStackedTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkStackedTreeLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

		public override long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(HandleRef pThis);

		public virtual double GetInteriorLogSpacingValue()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(HandleRef pThis);

		public virtual double GetInteriorRadius()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStackedTreeLayoutStrategy_GetReverse_04(HandleRef pThis);

		public virtual bool GetReverse()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetReverse_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRingThickness_05(HandleRef pThis);

		public virtual double GetRingThickness()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRingThickness_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRootEndAngle_06(HandleRef pThis);

		public virtual double GetRootEndAngle()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRootEndAngle_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRootStartAngle_07(HandleRef pThis);

		public virtual double GetRootStartAngle()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRootStartAngle_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_08(HandleRef pThis);

		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStackedTreeLayoutStrategy_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStackedTreeLayoutStrategy_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_Layout_11(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray);

		public override void Layout(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_Layout_11(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (sectorArray == null) ? default(HandleRef) : sectorArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_LayoutEdgePoints_12(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray, HandleRef edgeRoutingTree);

		public override void LayoutEdgePoints(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray, vtkTree edgeRoutingTree)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_LayoutEdgePoints_12(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (sectorArray == null) ? default(HandleRef) : sectorArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis(), (edgeRoutingTree == null) ? default(HandleRef) : edgeRoutingTree.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStackedTreeLayoutStrategy NewInstance()
		{
			vtkStackedTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_ReverseOff_15(HandleRef pThis);

		public virtual void ReverseOff()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_ReverseOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_ReverseOn_16(HandleRef pThis);

		public virtual void ReverseOn()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_ReverseOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStackedTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkStackedTreeLayoutStrategy vtkStackedTreeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStackedTreeLayoutStrategy = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStackedTreeLayoutStrategy.Register(null);
				}
			}
			return vtkStackedTreeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_18(HandleRef pThis, double _arg);

		public virtual void SetInteriorLogSpacingValue(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorRadius_19(HandleRef pThis, double _arg);

		public virtual void SetInteriorRadius(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetInteriorRadius_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetReverse_20(HandleRef pThis, byte _arg);

		public virtual void SetReverse(bool _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetReverse_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRingThickness_21(HandleRef pThis, double _arg);

		public virtual void SetRingThickness(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRingThickness_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRootEndAngle_22(HandleRef pThis, double _arg);

		public virtual void SetRootEndAngle(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRootEndAngle_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRootStartAngle_23(HandleRef pThis, double _arg);

		public virtual void SetRootStartAngle(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRootStartAngle_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_24(HandleRef pThis, byte _arg);

		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_25(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOff()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_26(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOn()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_26(base.GetCppThis());
		}
	}
}
