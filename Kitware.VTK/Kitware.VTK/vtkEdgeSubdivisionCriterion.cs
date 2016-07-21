using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkEdgeSubdivisionCriterion : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeSubdivisionCriterion";

		public new static readonly string MRClassNameKey;

		static vtkEdgeSubdivisionCriterion()
		{
			vtkEdgeSubdivisionCriterion.MRClassNameKey = "class vtkEdgeSubdivisionCriterion";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeSubdivisionCriterion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeSubdivisionCriterion"));
		}

		public vtkEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkEdgeSubdivisionCriterion_DontPassField_01(HandleRef pThis, int sourceId, HandleRef t);

		public virtual bool DontPassField(int sourceId, vtkStreamingTessellator t)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_DontPassField_01(base.GetCppThis(), sourceId, (t == null) ? default(HandleRef) : t.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkEdgeSubdivisionCriterion_EvaluateEdge_02(HandleRef pThis, IntPtr p0, IntPtr p1, IntPtr p2, int field_start);

		public virtual bool EvaluateEdge(IntPtr p0, IntPtr p1, IntPtr p2, int field_start)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_EvaluateEdge_02(base.GetCppThis(), p0, p1, p2, field_start) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldIds_03(HandleRef pThis);

		public IntPtr GetFieldIds()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetFieldIds_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(HandleRef pThis);

		public IntPtr GetFieldOffsets()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(HandleRef pThis);

		public int GetNumberOfFields()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgeSubdivisionCriterion_GetOutputField_06(HandleRef pThis, int fieldId);

		public int GetOutputField(int fieldId)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetOutputField_06(base.GetCppThis(), fieldId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgeSubdivisionCriterion_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgeSubdivisionCriterion_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgeSubdivisionCriterion NewInstance()
		{
			vtkEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgeSubdivisionCriterion_PassField_10(HandleRef pThis, int sourceId, int sourceSize, HandleRef t);

		public virtual int PassField(int sourceId, int sourceSize, vtkStreamingTessellator t)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_PassField_10(base.GetCppThis(), sourceId, sourceSize, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEdgeSubdivisionCriterion_ResetFieldList_11(HandleRef pThis);

		public virtual void ResetFieldList()
		{
			vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_ResetFieldList_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeSubdivisionCriterion vtkEdgeSubdivisionCriterion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
