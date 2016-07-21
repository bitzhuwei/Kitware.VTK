using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetEdgeSubdivisionCriterion : vtkEdgeSubdivisionCriterion
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion";

		public new static readonly string MRClassNameKey;

		static vtkDataSetEdgeSubdivisionCriterion()
		{
			vtkDataSetEdgeSubdivisionCriterion.MRClassNameKey = "class vtkDataSetEdgeSubdivisionCriterion";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetEdgeSubdivisionCriterion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion"));
		}

		public vtkDataSetEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetEdgeSubdivisionCriterion New()
		{
			vtkDataSetEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetEdgeSubdivisionCriterion() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(HandleRef pThis, IntPtr result, IntPtr weights, int field);

		public void EvaluateCellDataField(IntPtr result, IntPtr weights, int field)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(base.GetCppThis(), result, weights, field);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkDataSetEdgeSubdivisionCriterion_EvaluateEdge_02(HandleRef pThis, IntPtr p0, IntPtr midpt, IntPtr p1, int field_start);

		public override bool EvaluateEdge(IntPtr p0, IntPtr midpt, IntPtr p1, int field_start)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateEdge_02(base.GetCppThis(), p0, midpt, p1, field_start) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_03(HandleRef pThis, IntPtr vertex, IntPtr weights, int field_start);

		public IntPtr EvaluateFields(IntPtr vertex, IntPtr weights, int field_start)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_03(base.GetCppThis(), vertex, weights, field_start);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(HandleRef pThis, IntPtr result, IntPtr weights, int field);

		public void EvaluatePointDataField(IntPtr result, IntPtr weights, int field)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(base.GetCppThis(), result, weights, field);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(HandleRef pThis);

		public virtual int GetActiveFieldCriteria()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetCell_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCell GetCell()
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetCell_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(HandleRef pThis);

		public long GetCellId()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(HandleRef pThis);

		public virtual double GetChordError2()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(HandleRef pThis, int s);

		public double GetFieldError2(int s)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetMesh()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetEdgeSubdivisionCriterion NewInstance()
		{
			vtkDataSetEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_15(HandleRef pThis);

		public virtual void ResetFieldError2()
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetCellId_17(HandleRef pThis, long cell);

		public virtual void SetCellId(long cell)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetCellId_17(base.GetCppThis(), cell);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetChordError2_18(HandleRef pThis, double _arg);

		public virtual void SetChordError2(double _arg)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetChordError2_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_19(HandleRef pThis, int s, double err);

		public virtual void SetFieldError2(int s, double err)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_19(base.GetCppThis(), s, err);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetMesh_20(HandleRef pThis, HandleRef arg0);

		public virtual void SetMesh(vtkDataSet arg0)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetMesh_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
