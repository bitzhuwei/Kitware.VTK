using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTessellatorFilter : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatorFilter";

		public new static readonly string MRClassNameKey;

		static vtkTessellatorFilter()
		{
			vtkTessellatorFilter.MRClassNameKey = "class vtkTessellatorFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTessellatorFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatorFilter"));
		}

		public vtkTessellatorFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatorFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTessellatorFilter New()
		{
			vtkTessellatorFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTessellatorFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTessellatorFilter.vtkTessellatorFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTessellatorFilter_GetChordError_01(HandleRef pThis);

		public double GetChordError()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetChordError_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkTessellatorFilter_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(HandleRef pThis);

		public int GetMaximumNumberOfSubdivisions()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_GetMergePoints_04(HandleRef pThis);

		public virtual int GetMergePoints()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMergePoints_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_GetOutputDimension_05(HandleRef pThis);

		public virtual int GetOutputDimension()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimension_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_GetOutputDimensionMaxValue_06(HandleRef pThis);

		public virtual int GetOutputDimensionMaxValue()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimensionMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_GetOutputDimensionMinValue_07(HandleRef pThis);

		public virtual int GetOutputDimensionMinValue()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimensionMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatorFilter_GetSubdivider_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetEdgeSubdivisionCriterion GetSubdivider()
		{
			vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_GetSubdivider_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetEdgeSubdivisionCriterion = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetEdgeSubdivisionCriterion.Register(null);
				}
			}
			return vtkDataSetEdgeSubdivisionCriterion;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatorFilter_GetTessellator_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStreamingTessellator GetTessellator()
		{
			vtkStreamingTessellator vtkStreamingTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_GetTessellator_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTessellatorFilter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatorFilter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_MergePointsOff_12(HandleRef pThis);

		public virtual void MergePointsOff()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_MergePointsOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_MergePointsOn_13(HandleRef pThis);

		public virtual void MergePointsOn()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_MergePointsOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatorFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTessellatorFilter NewInstance()
		{
			vtkTessellatorFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_ResetFieldCriteria_16(HandleRef pThis);

		public virtual void ResetFieldCriteria()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_ResetFieldCriteria_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatorFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTessellatorFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTessellatorFilter vtkTessellatorFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTessellatorFilter = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTessellatorFilter.Register(null);
				}
			}
			return vtkTessellatorFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetChordError_18(HandleRef pThis, double ce);

		public virtual void SetChordError(double ce)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetChordError_18(base.GetCppThis(), ce);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetFieldCriterion_19(HandleRef pThis, int field, double chord);

		public virtual void SetFieldCriterion(int field, double chord)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetFieldCriterion_19(base.GetCppThis(), field, chord);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_20(HandleRef pThis, int num_subdiv_in);

		public virtual void SetMaximumNumberOfSubdivisions(int num_subdiv_in)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_20(base.GetCppThis(), num_subdiv_in);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetMergePoints_21(HandleRef pThis, int _arg);

		public virtual void SetMergePoints(int _arg)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetMergePoints_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetOutputDimension_22(HandleRef pThis, int _arg);

		public virtual void SetOutputDimension(int _arg)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetOutputDimension_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetSubdivider_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetSubdivider(vtkDataSetEdgeSubdivisionCriterion arg0)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetSubdivider_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatorFilter_SetTessellator_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetTessellator(vtkStreamingTessellator arg0)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetTessellator_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
