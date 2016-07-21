using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamingTessellator : vtkObject
	{
		public enum MaxFieldSize_WrapperEnum
		{
			MaxFieldSize = 18
		}

		public delegate void EdgeProcessorFunction(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		public delegate void TetrahedronProcessorFunction(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		public delegate void TriangleProcessorFunction(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		public delegate void VertexProcessorFunction(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingTessellator";

		public new static readonly string MRClassNameKey;

		static vtkStreamingTessellator()
		{
			vtkStreamingTessellator.MRClassNameKey = "class vtkStreamingTessellator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamingTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingTessellator"));
		}

		public vtkStreamingTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingTessellator New()
		{
			vtkStreamingTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingTessellator.vtkStreamingTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamingTessellator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamingTessellator.vtkStreamingTessellator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_AdaptivelySample0Facet_01(HandleRef pThis, IntPtr v1);

		public void AdaptivelySample0Facet(IntPtr v1)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_AdaptivelySample0Facet_01(base.GetCppThis(), v1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_AdaptivelySample1Facet_02(HandleRef pThis, IntPtr v1, IntPtr v2);

		public void AdaptivelySample1Facet(IntPtr v1, IntPtr v2)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_AdaptivelySample1Facet_02(base.GetCppThis(), v1, v2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_AdaptivelySample2Facet_03(HandleRef pThis, IntPtr v1, IntPtr v2, IntPtr v3);

		public void AdaptivelySample2Facet(IntPtr v1, IntPtr v2, IntPtr v3)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_AdaptivelySample2Facet_03(base.GetCppThis(), v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_AdaptivelySample3Facet_04(HandleRef pThis, IntPtr v1, IntPtr v2, IntPtr v3, IntPtr v4);

		public void AdaptivelySample3Facet(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr v4)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_AdaptivelySample3Facet_04(base.GetCppThis(), v1, v2, v3, v4);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkStreamingTessellator_GetCaseCount_05(HandleRef pThis, int c);

		public long GetCaseCount(int c)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetCaseCount_05(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_GetConstPrivateData_06(HandleRef pThis);

		public virtual IntPtr GetConstPrivateData()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetConstPrivateData_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern vtkStreamingTessellator.EdgeProcessorFunction vtkStreamingTessellator_GetEdgeCallback_07(HandleRef pThis);

		public virtual vtkStreamingTessellator.EdgeProcessorFunction GetEdgeCallback()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetEdgeCallback_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamingTessellator_GetEmbeddingDimension_08(HandleRef pThis, int k);

		public int GetEmbeddingDimension(int k)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetEmbeddingDimension_08(base.GetCppThis(), k);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamingTessellator_GetFieldSize_09(HandleRef pThis, int k);

		public int GetFieldSize(int k)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetFieldSize_09(base.GetCppThis(), k);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamingTessellator_GetMaximumNumberOfSubdivisions_10(HandleRef pThis);

		public int GetMaximumNumberOfSubdivisions()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetMaximumNumberOfSubdivisions_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_GetPrivateData_11(HandleRef pThis);

		public virtual IntPtr GetPrivateData()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetPrivateData_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkStreamingTessellator_GetSubcaseCount_12(HandleRef pThis, int casenum, int sub);

		public long GetSubcaseCount(int casenum, int sub)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetSubcaseCount_12(base.GetCppThis(), casenum, sub);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_GetSubdivisionAlgorithm_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEdgeSubdivisionCriterion GetSubdivisionAlgorithm()
		{
			vtkEdgeSubdivisionCriterion vtkEdgeSubdivisionCriterion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingTessellator.vtkStreamingTessellator_GetSubdivisionAlgorithm_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeSubdivisionCriterion = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeSubdivisionCriterion.Register(null);
				}
			}
			return vtkEdgeSubdivisionCriterion;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern vtkStreamingTessellator.TetrahedronProcessorFunction vtkStreamingTessellator_GetTetrahedronCallback_14(HandleRef pThis);

		public virtual vtkStreamingTessellator.TetrahedronProcessorFunction GetTetrahedronCallback()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetTetrahedronCallback_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern vtkStreamingTessellator.TriangleProcessorFunction vtkStreamingTessellator_GetTriangleCallback_15(HandleRef pThis);

		public virtual vtkStreamingTessellator.TriangleProcessorFunction GetTriangleCallback()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetTriangleCallback_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern vtkStreamingTessellator.VertexProcessorFunction vtkStreamingTessellator_GetVertexCallback_16(HandleRef pThis);

		public virtual vtkStreamingTessellator.VertexProcessorFunction GetVertexCallback()
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_GetVertexCallback_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamingTessellator_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamingTessellator_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamingTessellator.vtkStreamingTessellator_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamingTessellator NewInstance()
		{
			vtkStreamingTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingTessellator.vtkStreamingTessellator_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_ResetCounts_21(HandleRef pThis);

		public void ResetCounts()
		{
			vtkStreamingTessellator.vtkStreamingTessellator_ResetCounts_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingTessellator_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkStreamingTessellator vtkStreamingTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingTessellator.vtkStreamingTessellator_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingTessellator = (vtkStreamingTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingTessellator.Register(null);
				}
			}
			return vtkStreamingTessellator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetConstPrivateData_23(HandleRef pThis, IntPtr ConstPrivate);

		public virtual void SetConstPrivateData(IntPtr ConstPrivate)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetConstPrivateData_23(base.GetCppThis(), ConstPrivate);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetEdgeCallback_24(HandleRef pThis, vtkStreamingTessellator.EdgeProcessorFunction arg0);

		public virtual void SetEdgeCallback(vtkStreamingTessellator.EdgeProcessorFunction arg0)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetEdgeCallback_24(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetEmbeddingDimension_25(HandleRef pThis, int k, int d);

		public virtual void SetEmbeddingDimension(int k, int d)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetEmbeddingDimension_25(base.GetCppThis(), k, d);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetFieldSize_26(HandleRef pThis, int k, int s);

		public virtual void SetFieldSize(int k, int s)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetFieldSize_26(base.GetCppThis(), k, s);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetMaximumNumberOfSubdivisions_27(HandleRef pThis, int num_subdiv_in);

		public virtual void SetMaximumNumberOfSubdivisions(int num_subdiv_in)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetMaximumNumberOfSubdivisions_27(base.GetCppThis(), num_subdiv_in);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetPrivateData_28(HandleRef pThis, IntPtr Private);

		public virtual void SetPrivateData(IntPtr Private)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetPrivateData_28(base.GetCppThis(), Private);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetSubdivisionAlgorithm_29(HandleRef pThis, HandleRef arg0);

		public virtual void SetSubdivisionAlgorithm(vtkEdgeSubdivisionCriterion arg0)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetSubdivisionAlgorithm_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetTetrahedronCallback_30(HandleRef pThis, vtkStreamingTessellator.TetrahedronProcessorFunction arg0);

		public virtual void SetTetrahedronCallback(vtkStreamingTessellator.TetrahedronProcessorFunction arg0)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetTetrahedronCallback_30(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetTriangleCallback_31(HandleRef pThis, vtkStreamingTessellator.TriangleProcessorFunction arg0);

		public virtual void SetTriangleCallback(vtkStreamingTessellator.TriangleProcessorFunction arg0)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetTriangleCallback_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamingTessellator_SetVertexCallback_32(HandleRef pThis, vtkStreamingTessellator.VertexProcessorFunction arg0);

		public virtual void SetVertexCallback(vtkStreamingTessellator.VertexProcessorFunction arg0)
		{
			vtkStreamingTessellator.vtkStreamingTessellator_SetVertexCallback_32(base.GetCppThis(), arg0);
		}
	}
}
