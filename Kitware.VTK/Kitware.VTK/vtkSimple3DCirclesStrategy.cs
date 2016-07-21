using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimple3DCirclesStrategy : vtkGraphLayoutStrategy
	{
		public enum FixedDistanceMethod_WrapperEnum
		{
			FixedDistanceMethod = 1,
			FixedRadiusMethod = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSimple3DCirclesStrategy";

		public new static readonly string MRClassNameKey;

		static vtkSimple3DCirclesStrategy()
		{
			vtkSimple3DCirclesStrategy.MRClassNameKey = "class vtkSimple3DCirclesStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimple3DCirclesStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple3DCirclesStrategy"));
		}

		public vtkSimple3DCirclesStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimple3DCirclesStrategy New()
		{
			vtkSimple3DCirclesStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimple3DCirclesStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOff_01(HandleRef pThis);

		public virtual void AutoHeightOff()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_AutoHeightOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOn_02(HandleRef pThis);

		public virtual void AutoHeightOn()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_AutoHeightOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(HandleRef pThis);

		public virtual void ForceToUseUniversalStartPointsFinderOff()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(HandleRef pThis);

		public virtual void ForceToUseUniversalStartPointsFinderOn()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple3DCirclesStrategy_GetAutoHeight_05(HandleRef pThis);

		public virtual int GetAutoHeight()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetAutoHeight_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetDirection_06(HandleRef pThis);

		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_GetDirection_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_GetDirection_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetDirection(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(HandleRef pThis);

		public virtual int GetForceToUseUniversalStartPointsFinder()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple3DCirclesStrategy_GetHeight_10(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHeight_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIntArray GetHierarchicalLayers()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdTypeArray GetHierarchicalOrder()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractArray GetMarkedStartVertices()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple3DCirclesStrategy_GetMethod_14(HandleRef pThis);

		public virtual int GetMethod()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMethod_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple3DCirclesStrategy_GetMinimumDegree_15(HandleRef pThis);

		public virtual double GetMinimumDegree()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMinimumDegree_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple3DCirclesStrategy_GetMinimumRadian_16(HandleRef pThis);

		public virtual double GetMinimumRadian()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMinimumRadian_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetOrigin_17(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple3DCirclesStrategy_GetRadius_20(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetRadius_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple3DCirclesStrategy_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple3DCirclesStrategy_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_Layout_23(HandleRef pThis);

		public override void Layout()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_Layout_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimple3DCirclesStrategy NewInstance()
		{
			vtkSimple3DCirclesStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimple3DCirclesStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSimple3DCirclesStrategy vtkSimple3DCirclesStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimple3DCirclesStrategy = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimple3DCirclesStrategy.Register(null);
				}
			}
			return vtkSimple3DCirclesStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetAutoHeight_27(HandleRef pThis, int _arg);

		public virtual void SetAutoHeight(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetAutoHeight_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetDirection_28(HandleRef pThis, double dx, double dy, double dz);

		public virtual void SetDirection(double dx, double dy, double dz)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetDirection_28(base.GetCppThis(), dx, dy, dz);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetDirection_29(HandleRef pThis, IntPtr d);

		public virtual void SetDirection(IntPtr d)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetDirection_29(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_30(HandleRef pThis, int _arg);

		public virtual void SetForceToUseUniversalStartPointsFinder(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetGraph_31(HandleRef pThis, HandleRef graph);

		public override void SetGraph(vtkGraph graph)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetGraph_31(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetHeight_32(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHeight_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalLayers_33(HandleRef pThis, HandleRef _arg);

		public virtual void SetHierarchicalLayers(vtkIntArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHierarchicalLayers_33(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalOrder_34(HandleRef pThis, HandleRef _arg);

		public virtual void SetHierarchicalOrder(vtkIdTypeArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHierarchicalOrder_34(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetMarkedStartVertices_35(HandleRef pThis, HandleRef _arg);

		public virtual void SetMarkedStartVertices(vtkAbstractArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMarkedStartVertices_35(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetMethod_36(HandleRef pThis, int _arg);

		public virtual void SetMethod(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMethod_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetMinimumDegree_37(HandleRef pThis, double degree);

		public virtual void SetMinimumDegree(double degree)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMinimumDegree_37(base.GetCppThis(), degree);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetMinimumRadian_38(HandleRef pThis, double _arg);

		public virtual void SetMinimumRadian(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMinimumRadian_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetOrigin_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_40(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetOrigin_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple3DCirclesStrategy_SetRadius_41(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetRadius_41(base.GetCppThis(), _arg);
		}
	}
}
