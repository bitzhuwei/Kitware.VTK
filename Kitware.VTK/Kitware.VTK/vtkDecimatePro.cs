using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDecimatePro : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePro";

		public new static readonly string MRClassNameKey;

		static vtkDecimatePro()
		{
			vtkDecimatePro.MRClassNameKey = "class vtkDecimatePro";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDecimatePro.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePro"));
		}

		public vtkDecimatePro(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePro_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDecimatePro New()
		{
			vtkDecimatePro result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDecimatePro() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDecimatePro.vtkDecimatePro_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_AccumulateErrorOff_01(HandleRef pThis);

		public virtual void AccumulateErrorOff()
		{
			vtkDecimatePro.vtkDecimatePro_AccumulateErrorOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_AccumulateErrorOn_02(HandleRef pThis);

		public virtual void AccumulateErrorOn()
		{
			vtkDecimatePro.vtkDecimatePro_AccumulateErrorOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_BoundaryVertexDeletionOff_03(HandleRef pThis);

		public virtual void BoundaryVertexDeletionOff()
		{
			vtkDecimatePro.vtkDecimatePro_BoundaryVertexDeletionOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_BoundaryVertexDeletionOn_04(HandleRef pThis);

		public virtual void BoundaryVertexDeletionOn()
		{
			vtkDecimatePro.vtkDecimatePro_BoundaryVertexDeletionOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetAbsoluteError_05(HandleRef pThis);

		public virtual double GetAbsoluteError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteError_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

		public virtual double GetAbsoluteErrorMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteErrorMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetAbsoluteErrorMinValue_07(HandleRef pThis);

		public virtual double GetAbsoluteErrorMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteErrorMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetAccumulateError_08(HandleRef pThis);

		public virtual int GetAccumulateError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAccumulateError_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetBoundaryVertexDeletion_09(HandleRef pThis);

		public virtual int GetBoundaryVertexDeletion()
		{
			return vtkDecimatePro.vtkDecimatePro_GetBoundaryVertexDeletion_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetDegree_10(HandleRef pThis);

		public virtual int GetDegree()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegree_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetDegreeMaxValue_11(HandleRef pThis);

		public virtual int GetDegreeMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegreeMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetDegreeMinValue_12(HandleRef pThis);

		public virtual int GetDegreeMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegreeMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetErrorIsAbsolute_13(HandleRef pThis);

		public virtual int GetErrorIsAbsolute()
		{
			return vtkDecimatePro.vtkDecimatePro_GetErrorIsAbsolute_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetFeatureAngle_14(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngle_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetFeatureAngleMaxValue_15(HandleRef pThis);

		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngleMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetFeatureAngleMinValue_16(HandleRef pThis);

		public virtual double GetFeatureAngleMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngleMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetInflectionPointRatio_17(HandleRef pThis);

		public virtual double GetInflectionPointRatio()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatio_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetInflectionPointRatioMaxValue_18(HandleRef pThis);

		public virtual double GetInflectionPointRatioMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatioMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetInflectionPointRatioMinValue_19(HandleRef pThis);

		public virtual double GetInflectionPointRatioMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatioMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_GetInflectionPoints_20(HandleRef pThis, IntPtr inflectionPoints);

		public void GetInflectionPoints(IntPtr inflectionPoints)
		{
			vtkDecimatePro.vtkDecimatePro_GetInflectionPoints_20(base.GetCppThis(), inflectionPoints);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePro_GetInflectionPoints_21(HandleRef pThis);

		public IntPtr GetInflectionPoints()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPoints_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetMaximumError_22(HandleRef pThis);

		public virtual double GetMaximumError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumError_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetMaximumErrorMaxValue_23(HandleRef pThis);

		public virtual double GetMaximumErrorMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumErrorMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetMaximumErrorMinValue_24(HandleRef pThis);

		public virtual double GetMaximumErrorMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumErrorMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkDecimatePro_GetNumberOfInflectionPoints_25(HandleRef pThis);

		public long GetNumberOfInflectionPoints()
		{
			return vtkDecimatePro.vtkDecimatePro_GetNumberOfInflectionPoints_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetPreSplitMesh_26(HandleRef pThis);

		public virtual int GetPreSplitMesh()
		{
			return vtkDecimatePro.vtkDecimatePro_GetPreSplitMesh_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetPreserveTopology_27(HandleRef pThis);

		public virtual int GetPreserveTopology()
		{
			return vtkDecimatePro.vtkDecimatePro_GetPreserveTopology_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetSplitAngle_28(HandleRef pThis);

		public virtual double GetSplitAngle()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngle_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetSplitAngleMaxValue_29(HandleRef pThis);

		public virtual double GetSplitAngleMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngleMaxValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetSplitAngleMinValue_30(HandleRef pThis);

		public virtual double GetSplitAngleMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngleMinValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_GetSplitting_31(HandleRef pThis);

		public virtual int GetSplitting()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitting_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetTargetReduction_32(HandleRef pThis);

		public virtual double GetTargetReduction()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReduction_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetTargetReductionMaxValue_33(HandleRef pThis);

		public virtual double GetTargetReductionMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReductionMaxValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePro_GetTargetReductionMinValue_34(HandleRef pThis);

		public virtual double GetTargetReductionMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReductionMinValue_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_IsA_35(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_IsA_35(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePro_IsTypeOf_36(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_IsTypeOf_36(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePro_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDecimatePro NewInstance()
		{
			vtkDecimatePro result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_NewInstance_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_PreSplitMeshOff_39(HandleRef pThis);

		public virtual void PreSplitMeshOff()
		{
			vtkDecimatePro.vtkDecimatePro_PreSplitMeshOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_PreSplitMeshOn_40(HandleRef pThis);

		public virtual void PreSplitMeshOn()
		{
			vtkDecimatePro.vtkDecimatePro_PreSplitMeshOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_PreserveTopologyOff_41(HandleRef pThis);

		public virtual void PreserveTopologyOff()
		{
			vtkDecimatePro.vtkDecimatePro_PreserveTopologyOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_PreserveTopologyOn_42(HandleRef pThis);

		public virtual void PreserveTopologyOn()
		{
			vtkDecimatePro.vtkDecimatePro_PreserveTopologyOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePro_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDecimatePro SafeDownCast(vtkObjectBase o)
		{
			vtkDecimatePro vtkDecimatePro = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDecimatePro = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDecimatePro.Register(null);
				}
			}
			return vtkDecimatePro;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetAbsoluteError_44(HandleRef pThis, double _arg);

		public virtual void SetAbsoluteError(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetAbsoluteError_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetAccumulateError_45(HandleRef pThis, int _arg);

		public virtual void SetAccumulateError(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetAccumulateError_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetBoundaryVertexDeletion_46(HandleRef pThis, int _arg);

		public virtual void SetBoundaryVertexDeletion(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetBoundaryVertexDeletion_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetDegree_47(HandleRef pThis, int _arg);

		public virtual void SetDegree(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetDegree_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetErrorIsAbsolute_48(HandleRef pThis, int _arg);

		public virtual void SetErrorIsAbsolute(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetErrorIsAbsolute_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetFeatureAngle_49(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetFeatureAngle_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetInflectionPointRatio_50(HandleRef pThis, double _arg);

		public virtual void SetInflectionPointRatio(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetInflectionPointRatio_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetMaximumError_51(HandleRef pThis, double _arg);

		public virtual void SetMaximumError(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetMaximumError_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetPreSplitMesh_52(HandleRef pThis, int _arg);

		public virtual void SetPreSplitMesh(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetPreSplitMesh_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetPreserveTopology_53(HandleRef pThis, int _arg);

		public virtual void SetPreserveTopology(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetPreserveTopology_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetSplitAngle_54(HandleRef pThis, double _arg);

		public virtual void SetSplitAngle(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetSplitAngle_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetSplitting_55(HandleRef pThis, int _arg);

		public virtual void SetSplitting(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetSplitting_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SetTargetReduction_56(HandleRef pThis, double _arg);

		public virtual void SetTargetReduction(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetTargetReduction_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SplittingOff_57(HandleRef pThis);

		public virtual void SplittingOff()
		{
			vtkDecimatePro.vtkDecimatePro_SplittingOff_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePro_SplittingOn_58(HandleRef pThis);

		public virtual void SplittingOn()
		{
			vtkDecimatePro.vtkDecimatePro_SplittingOn_58(base.GetCppThis());
		}
	}
}
