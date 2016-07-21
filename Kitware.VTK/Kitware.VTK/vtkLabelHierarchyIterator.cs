using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkLabelHierarchyIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyIterator";

		public new static readonly string MRClassNameKey;

		static vtkLabelHierarchyIterator()
		{
			vtkLabelHierarchyIterator.MRClassNameKey = "class vtkLabelHierarchyIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchyIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyIterator"));
		}

		public vtkLabelHierarchyIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_Begin_01(HandleRef pThis, HandleRef arg0);

		public virtual void Begin(vtkIdTypeArray arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_Begin_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_BoxAllNodes_02(HandleRef pThis, HandleRef arg0);

		public virtual void BoxAllNodes(vtkPolyData arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_BoxAllNodes_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_BoxNode_03(HandleRef pThis);

		public virtual void BoxNode()
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_BoxNode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyIterator_GetAllBounds_04(HandleRef pThis);

		public virtual int GetAllBounds()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetAllBounds_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_GetBoundedSize_05(HandleRef pThis, IntPtr sz);

		public virtual void GetBoundedSize(IntPtr sz)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetBoundedSize_05(base.GetCppThis(), sz);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyIterator_GetHierarchy_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLabelHierarchy GetHierarchy()
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetHierarchy_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkLabelHierarchyIterator_GetLabelId_07(HandleRef pThis);

		public virtual long GetLabelId()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetLabelId_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_GetNodeGeometry_08(HandleRef pThis, IntPtr ctr, ref double size);

		public virtual void GetNodeGeometry(IntPtr ctr, ref double size)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetNodeGeometry_08(base.GetCppThis(), ctr, ref size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelHierarchyIterator_GetOrientation_09(HandleRef pThis);

		public virtual double GetOrientation()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetOrientation_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_GetPoint_10(HandleRef pThis, IntPtr x);

		public virtual void GetPoint(IntPtr x)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetPoint_10(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_GetSize_11(HandleRef pThis, IntPtr sz);

		public virtual void GetSize(IntPtr sz)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetSize_11(base.GetCppThis(), sz);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyIterator_GetType_12(HandleRef pThis);

		public virtual int GetTypeWrapper()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetType_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyIterator_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelHierarchyIterator_IsAtEnd_14(HandleRef pThis);

		public virtual bool IsAtEnd()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsAtEnd_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchyIterator_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyIterator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelHierarchyIterator NewInstance()
		{
			vtkLabelHierarchyIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_Next_17(HandleRef pThis);

		public virtual void Next()
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_Next_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchyIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelHierarchyIterator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchyIterator vtkLabelHierarchyIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyIterator = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyIterator.Register(null);
				}
			}
			return vtkLabelHierarchyIterator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_SetAllBounds_19(HandleRef pThis, int _arg);

		public virtual void SetAllBounds(int _arg)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SetAllBounds_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchyIterator_SetTraversedBounds_20(HandleRef pThis, HandleRef arg0);

		public virtual void SetTraversedBounds(vtkPolyData arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SetTraversedBounds_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
