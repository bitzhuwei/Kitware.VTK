using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGreedyTerrainDecimation : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGreedyTerrainDecimation";

		public new static readonly string MRClassNameKey;

		static vtkGreedyTerrainDecimation()
		{
			vtkGreedyTerrainDecimation.MRClassNameKey = "class vtkGreedyTerrainDecimation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGreedyTerrainDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGreedyTerrainDecimation"));
		}

		public vtkGreedyTerrainDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGreedyTerrainDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGreedyTerrainDecimation New()
		{
			vtkGreedyTerrainDecimation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGreedyTerrainDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(HandleRef pThis);

		public virtual void BoundaryVertexDeletionOff()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(HandleRef pThis);

		public virtual void BoundaryVertexDeletionOn()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteError_05(HandleRef pThis);

		public virtual double GetAbsoluteError()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteError_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

		public virtual double GetAbsoluteErrorMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(HandleRef pThis);

		public virtual double GetAbsoluteErrorMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(HandleRef pThis);

		public virtual int GetBoundaryVertexDeletion()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_GetComputeNormals_09(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetComputeNormals_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasure_10(HandleRef pThis);

		public virtual int GetErrorMeasure()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasure_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(HandleRef pThis);

		public virtual int GetErrorMeasureMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(HandleRef pThis);

		public virtual int GetErrorMeasureMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTriangles_13(HandleRef pThis);

		public virtual long GetNumberOfTriangles()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTriangles_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_14(HandleRef pThis);

		public virtual long GetNumberOfTrianglesMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_15(HandleRef pThis);

		public virtual long GetNumberOfTrianglesMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetReduction_16(HandleRef pThis);

		public virtual double GetReduction()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReduction_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetReductionMaxValue_17(HandleRef pThis);

		public virtual double GetReductionMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReductionMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetReductionMinValue_18(HandleRef pThis);

		public virtual double GetReductionMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReductionMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeError_19(HandleRef pThis);

		public virtual double GetRelativeError()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeError_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_20(HandleRef pThis);

		public virtual double GetRelativeErrorMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_21(HandleRef pThis);

		public virtual double GetRelativeErrorMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGreedyTerrainDecimation_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGreedyTerrainDecimation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGreedyTerrainDecimation NewInstance()
		{
			vtkGreedyTerrainDecimation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGreedyTerrainDecimation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGreedyTerrainDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkGreedyTerrainDecimation vtkGreedyTerrainDecimation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGreedyTerrainDecimation = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGreedyTerrainDecimation.Register(null);
				}
			}
			return vtkGreedyTerrainDecimation;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetAbsoluteError_27(HandleRef pThis, double _arg);

		public virtual void SetAbsoluteError(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetAbsoluteError_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_28(HandleRef pThis, int _arg);

		public virtual void SetBoundaryVertexDeletion(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetComputeNormals_29(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetComputeNormals_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasure_30(HandleRef pThis, int _arg);

		public virtual void SetErrorMeasure(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasure_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_31(HandleRef pThis);

		public void SetErrorMeasureToAbsoluteError()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_32(HandleRef pThis);

		public void SetErrorMeasureToNumberOfTriangles()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_33(HandleRef pThis);

		public void SetErrorMeasureToRelativeError()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_34(HandleRef pThis);

		public void SetErrorMeasureToSpecifiedReduction()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetNumberOfTriangles_35(HandleRef pThis, long _arg);

		public virtual void SetNumberOfTriangles(long _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetNumberOfTriangles_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetReduction_36(HandleRef pThis, double _arg);

		public virtual void SetReduction(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetReduction_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGreedyTerrainDecimation_SetRelativeError_37(HandleRef pThis, double _arg);

		public virtual void SetRelativeError(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetRelativeError_37(base.GetCppThis(), _arg);
		}
	}
}
