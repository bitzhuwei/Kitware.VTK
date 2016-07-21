using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabelHierarchyCompositeIterator : vtkLabelHierarchyIterator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyCompositeIterator";

		public new static readonly string MRClassNameKey;

		static vtkLabelHierarchyCompositeIterator()
		{
			vtkLabelHierarchyCompositeIterator.MRClassNameKey = "class vtkLabelHierarchyCompositeIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchyCompositeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyCompositeIterator"));
		}

		public vtkLabelHierarchyCompositeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelHierarchyCompositeIterator New()
		{
			vtkLabelHierarchyCompositeIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabelHierarchyCompositeIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_01(HandleRef pThis, HandleRef it);

		public virtual void AddIterator(vtkLabelHierarchyIterator it)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_AddIterator_01(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_02(HandleRef pThis, HandleRef it, int count);

		public virtual void AddIterator(vtkLabelHierarchyIterator it, int count)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_AddIterator_02(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis(), count);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_Begin_03(HandleRef pThis, HandleRef arg0);

		public override void Begin(vtkIdTypeArray arg0)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_Begin_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(HandleRef pThis, HandleRef arg0);

		public override void BoxAllNodes(vtkPolyData arg0)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_BoxNode_05(HandleRef pThis);

		public override void BoxNode()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_BoxNode_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_ClearIterators_06(HandleRef pThis);

		public virtual void ClearIterators()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_ClearIterators_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_GetHierarchy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkLabelHierarchy GetHierarchy()
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetHierarchy_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkLabelHierarchyCompositeIterator_GetLabelId_08(HandleRef pThis);

		public override long GetLabelId()
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetLabelId_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(HandleRef pThis, IntPtr ctr, ref double size);

		public override void GetNodeGeometry(IntPtr ctr, ref double size)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(base.GetCppThis(), ctr, ref size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyCompositeIterator_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelHierarchyCompositeIterator_IsAtEnd_11(HandleRef pThis);

		public override bool IsAtEnd()
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsAtEnd_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyCompositeIterator_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelHierarchyCompositeIterator NewInstance()
		{
			vtkLabelHierarchyCompositeIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyCompositeIterator_Next_15(HandleRef pThis);

		public override void Next()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_Next_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelHierarchyCompositeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchyCompositeIterator vtkLabelHierarchyCompositeIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyCompositeIterator = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyCompositeIterator.Register(null);
				}
			}
			return vtkLabelHierarchyCompositeIterator;
		}
	}
}
